using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using NTQTRAINING_PRJ.Models;
using NTQTRAINING_PRJ.Protos;
using System.ComponentModel;
using static NTQTRAINING_PRJ.Protos.ProductsServices;

namespace NTQTRAINING_PRJ.Services
{
    public class ProductsServices: ProductsServicesBase
    {

        public NTQTRAININGContext NtqTrainingContext;
        public ProductsServices(NTQTRAININGContext ntqtrainingcontext)
        {
            NtqTrainingContext = ntqtrainingcontext;
        }
        public override Task<Protos.ListProduct> GetAll(Protos.ProductEmpty request, ServerCallContext context)
        {
            ListProduct listProduct = new ListProduct();
            var result = from prd in NtqTrainingContext.Products
                         select new Protos.Product()
                         {
                             Id = prd.Id,
                             Name = prd.Name,
                             TagName = prd.TagName,
                             Active = prd.Active ?? true,
                             CategoryId = prd.CategoryId,
                             CreatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(prd.CreatedDate, DateTimeKind.Utc)),
                             UpdatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(prd.UpdatedDate, DateTimeKind.Utc)),
                         };
            listProduct.Items.AddRange(result.ToArray());
            return Task.FromResult(listProduct);
        }

        public override Task<Protos.Product> Create(Protos.Product request, ServerCallContext context)
        {
            return null;
        }

        public override Task<ProductEmpty> Delete(ProductId request, ServerCallContext context)
        {
            return null;
        }

        public override Task<Protos.Product> Update(Protos.Product request, ServerCallContext context)
        {
            return null;
        }
    }
}
