using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using NTQTRAINING_PRJ.Models;
using NTQTRAINING_PRJ.Protos;
using System.ComponentModel;
using static NTQTRAINING_PRJ.Protos.CategoriesSevices;

namespace NTQTRAINING_PRJ.Services
{
    public class CategoriesServices : CategoriesSevicesBase
    {
        public NTQTRAININGContext NtqTrainingContext;
        public CategoriesServices(NTQTRAININGContext ntqtrainingcontext)
        {
            NtqTrainingContext = ntqtrainingcontext;
        }

        //private IRepository<Models.Category> _reponsitory;
        public override Task<Protos.ResponseSesult> Create(Protos.Category request, ServerCallContext context)
        {

            try
            {
                Models.Category newCategory = new Models.Category();
                newCategory.Name = request.Name;
                newCategory.TagName = request.TagName;
                newCategory.Active = request.Active;
                newCategory.CreatedDate = request.CreatedDate.ToDateTime();
                newCategory.UpdatedDate = request.UpdatedDate.ToDateTime();
                NtqTrainingContext.Categories.Add(newCategory);
                NtqTrainingContext.SaveChanges();
                return Task.FromResult(new ResponseSesult
                {
                    Item = request,
                    Result = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult(new ResponseSesult
                {
                    Item = request,
                    Result = false
                });
            }
        }


        public override Task<Protos.ResponseSesult> Delete(Protos.CategoryId request, ServerCallContext context)
        {
            using (var transaction = NtqTrainingContext.Database.BeginTransaction())
            {
                try
                {
                    var category = NtqTrainingContext.Categories.FirstOrDefault(c => c.Id == request.Id);
                    if (category == null)
                    {
                        return Task.FromResult(new ResponseSesult
                        {
                            Item = new Protos.Category(),
                            Result = false
                        });
                    }
                    else
                    {
                        NtqTrainingContext.Categories.Remove(category);
                        NtqTrainingContext.SaveChanges();
                        transaction.Commit();
                        return Task.FromResult(new ResponseSesult
                        {
                            Item = new Protos.Category(),
                            Result = true
                        });
                    }
                }
                catch
                {
                    transaction.Rollback();
                    return Task.FromResult(new ResponseSesult
                    {
                        Item = new Protos.Category(),
                        Result = false
                    });
                }
                
            }

        }

        public override Task<Protos.ListCategory> GetAll(Protos.CategoryEmpty request, ServerCallContext context)
        {
            ListCategory listCategory = new ListCategory();
            var result = from cte in NtqTrainingContext.Categories
                         select new Protos.Category()
                         {
                             Id = cte.Id,
                             Name = cte.Name,
                             TagName = cte.TagName,
                             Active = cte.Active ?? true,
                             CreatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(cte.CreatedDate, DateTimeKind.Utc)),
                             UpdatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(cte.UpdatedDate, DateTimeKind.Utc)),
                         };
            listCategory.Items.AddRange(result.ToArray());
            return Task.FromResult(listCategory);
        }

        public override Task<Protos.ResponseSesult> GetCategoryById(CategoryId request, ServerCallContext context)
        {
            var category = NtqTrainingContext.Categories.Find(request.Id);
            if (category == null)
            {
                return Task.FromResult(new Protos.ResponseSesult
                {
                    Item = null,
                    Result = false
                });
            }
            else
            {
                return Task.FromResult(new Protos.ResponseSesult
                {
                    Item = new Protos.Category
                    {
                        Id = category.Id,
                        Name = category.Name,
                        TagName = category.TagName,
                        Active = category.Active ?? true,
                        CreatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(category.CreatedDate, DateTimeKind.Utc)),
                        UpdatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(category.UpdatedDate, DateTimeKind.Utc)),
                    },
                    Result = true
                });
            }
        }

        public override Task<Protos.ResponseSesult> Update(Protos.Category request, ServerCallContext context)
        {
            var category = NtqTrainingContext.Categories.Find(request.Id);
            if (category == null)
            {
                return Task.FromResult(new Protos.ResponseSesult
                {
                    Item = null,
                    Result = false
                });
            }
            else
            {
                category.Id = request.Id;
                category.Name = request.Name;
                category.TagName = request.TagName;
                category.Active = request.Active;
                category.CreatedDate = request.CreatedDate.ToDateTime();
                category.UpdatedDate = request.UpdatedDate.ToDateTime();
                NtqTrainingContext.SaveChanges();
                return Task.FromResult(new Protos.ResponseSesult
                {
                    Item = request,
                    Result = true
                });
            }
        }
    }
}
