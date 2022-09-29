using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using NTQTRAINING_PRJ.Models;
using NTQTRAINING_PRJ.Protos;
using System.ComponentModel;
using static NTQTRAINING_PRJ.Protos.ProductDetailsServices;

namespace NTQTRAINING_PRJ.Services
{
    public class ProductDetailsServices : ProductDetailsServicesBase
    {

        public NTQTRAININGContext NtqTrainingContext;
        public ProductDetailsServices(NTQTRAININGContext ntqtrainingcontext)
        {
            NtqTrainingContext = ntqtrainingcontext;
        }
        public override Task<Protos.ListProductDetail> GetAll(Protos.ProductDetailEmpty request, ServerCallContext context)
        {
            ListProductDetail listProductDetail = new ListProductDetail();
            var result = from prod in NtqTrainingContext.ProductDetails
                         select new Protos.ProductDetail()
                         {
                             Id = prod.Id,
                             Price = prod.Price,
                             Color = prod.Color,
                             StartingDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind((DateTime)prod.StartingDate, DateTimeKind.Utc)),
                             ClosingDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind((DateTime)prod.ClosingDate, DateTimeKind.Utc)),
                             ProductId = prod.ProductId,
                             MadeBy = prod.MadeBy,
                             CreatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(prod.CreatedDate, DateTimeKind.Utc)),
                             UpdatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(prod.UpdatedDate, DateTimeKind.Utc)),
                         };
            listProductDetail.Items.AddRange(result.ToArray());


            return Task.FromResult(listProductDetail);
        }

        public override Task<Protos.ProductDetailResponseResult> Create(Protos.ProductDetail request, ServerCallContext context)
        {
            try
            {
                Models.ProductDetail newProductDetail = new Models.ProductDetail();
                newProductDetail.Id = request.Id;
                newProductDetail.Price = request.Price;
                newProductDetail.Color = request.Color;
                newProductDetail.StartingDate = request.StartingDate.ToDateTime();
                newProductDetail.ClosingDate = request.ClosingDate.ToDateTime();
                newProductDetail.ProductId = request.ProductId;
                newProductDetail.MadeBy = request.MadeBy;
                newProductDetail.CreatedDate = request.CreatedDate.ToDateTime();
                newProductDetail.UpdatedDate = request.UpdatedDate.ToDateTime();

                NtqTrainingContext.ProductDetails.Add(newProductDetail);
                NtqTrainingContext.SaveChanges();

                return Task.FromResult(new ProductDetailResponseResult
                {
                    Item = request,
                    Result = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult(new ProductDetailResponseResult
                {
                    Item = request,
                    Result = false
                });
            }
        }

        public override Task<Protos.ProductDetailResponseResult> Delete(ProductDetailId request, ServerCallContext context)
        {
            var product = NtqTrainingContext.ProductDetails.FirstOrDefault(c => c.Id == request.Id);
            if (product == null)
            {
                return Task.FromResult(new ProductDetailResponseResult
                {
                    Item = new Protos.ProductDetail(),
                    Result = false
                });
            }
            else
            {
                NtqTrainingContext.ProductDetails.Remove(product);
                NtqTrainingContext.SaveChanges();
                return Task.FromResult(new ProductDetailResponseResult
                {
                    Item = new Protos.ProductDetail(),
                    Result = true
                });
            }
        }

        public override Task<Protos.ProductDetailResponseResult> Update(Protos.ProductDetail request, ServerCallContext context)
        {
            var productDetail = NtqTrainingContext.ProductDetails.Find(request.Id);
            if (productDetail == null)
            {
                return Task.FromResult(new Protos.ProductDetailResponseResult
                {
                    Item = null,
                    Result = false
                });
            }
            else
            {
                productDetail.Price = request.Price;
                productDetail.Color = request.Color;
                productDetail.StartingDate = request.StartingDate.ToDateTime();
                productDetail.ClosingDate = request.ClosingDate.ToDateTime();
                productDetail.ProductId = request.ProductId;
                productDetail.MadeBy = request.MadeBy;
                productDetail.CreatedDate = request.CreatedDate.ToDateTime();
                productDetail.UpdatedDate = request.UpdatedDate.ToDateTime();

                NtqTrainingContext.SaveChanges();
                return Task.FromResult(new Protos.ProductDetailResponseResult
                {
                    Item = request,
                    Result = true
                });
            }
        }
    }
}
