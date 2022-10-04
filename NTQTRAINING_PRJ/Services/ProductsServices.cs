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
            var result = from prod in NtqTrainingContext.Products
                         select new Protos.Product()
                         {
                             Id = prod.Id,
                             Name = prod.Name,
                             TagName = prod.TagName,
                             Active = prod.Active ?? true,
                             CategoryId = prod.CategoryId,
                             CreatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(prod.CreatedDate, DateTimeKind.Utc)),
                             UpdatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(prod.UpdatedDate, DateTimeKind.Utc)),
                         };
            listProduct.Items.AddRange(result.ToArray());
            return Task.FromResult(listProduct);
        }

        public override Task<Protos.ProductResponseResult> Create(Protos.Product request, ServerCallContext context)
        {
            try
            {
                Models.Product newProduct = new Models.Product();
                newProduct.Id = request.Id;
                newProduct.Name = request.Name;
                newProduct.TagName = request.TagName;
                newProduct.Active = request.Active;
                newProduct.CategoryId = request.CategoryId;
                newProduct.CreatedDate = request.CreatedDate.ToDateTime();
                newProduct.UpdatedDate = request.UpdatedDate.ToDateTime();

                NtqTrainingContext.Products.Add(newProduct);
                NtqTrainingContext.SaveChanges();

                return Task.FromResult(new ProductResponseResult
                {
                    Item = request,
                    Result = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult(new ProductResponseResult
                {
                    Item = request,
                    Result = false
                });
            }
        }

        public override Task<Protos.ProductResponseResult> Delete(ProductId request, ServerCallContext context)
        {
            using (var transaction = NtqTrainingContext.Database.BeginTransaction())
            {
                try
                {
                    var product = NtqTrainingContext.Products.FirstOrDefault(c => c.Id == request.Id);
                    if (product == null)
                    {
                        return Task.FromResult(new ProductResponseResult
                        {
                            Item = new Protos.Product(),
                            Result = false
                        });
                    }
                    else
                    {
                        NtqTrainingContext.Products.Remove(product);
                        NtqTrainingContext.SaveChanges();
                        transaction.Commit();
                        return Task.FromResult(new ProductResponseResult
                        {
                            Item = new Protos.Product(),
                            Result = true
                        });
                    }
                }
                catch
                {
                    transaction.Rollback();
                    return Task.FromResult(new ProductResponseResult
                    {
                        Item = new Protos.Product(),
                        Result = false
                    });
                }
            }
        }

        public override Task<Protos.ProductResponseResult> Update(Protos.Product request, ServerCallContext context)
        {
            var product = NtqTrainingContext.Products.Find(request.Id);
            if (product == null)
            {
                return Task.FromResult(new Protos.ProductResponseResult
                {
                    Item = null,
                    Result = false
                });
            }
            else
            {
                product.Name = request.Name;
                product.TagName = request.TagName;
                product.Active = request.Active;
                product.CategoryId = request.CategoryId;
                product.CreatedDate = request.CreatedDate.ToDateTime();
                product.UpdatedDate = request.UpdatedDate.ToDateTime();
                
                NtqTrainingContext.SaveChanges();
                return Task.FromResult(new Protos.ProductResponseResult
                {
                    Item = request,
                    Result = true
                });
            }
        }
    }
}
