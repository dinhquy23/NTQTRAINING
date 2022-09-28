using Grpc.Core;
using NTQTRAINING_PRJ.Models;
using NTQTRAINING_PRJ.Protos;
using static NTQTRAINING_PRJ.Protos.CategoriesSevices;

namespace NTQTRAINING_PRJ.Services
{
    public class CategoriesServices: CategoriesSevicesBase
    {
        public NTQTRAININGContext NtqTrainingContext;
        public CategoriesServices(NTQTRAININGContext ntqtrainingcontext)
        {
            NtqTrainingContext = ntqtrainingcontext;
        }

        //private IRepository<Models.Category> _reponsitory;
        public override Task<Protos.Category> Create(Protos.Category request, ServerCallContext context)
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
                return Task.FromResult(request);
            }
           catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Task.FromResult(request);
            }
        }


        public override Task<Protos.CategoryEmpty> Delete(Protos.CategoryId request, ServerCallContext context)
        {

            var category = NtqTrainingContext.Categories.FirstOrDefault(c => c.Id == request.Id);
            if (category == null)
            {
                return Task.FromResult<Protos.CategoryEmpty>(null);
            }
            else
            {
                NtqTrainingContext.Categories.Remove(category);
                NtqTrainingContext.SaveChanges();
                return Task.FromResult(new CategoryEmpty());
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
                             Active= cte.Active ?? true,
                             CreatedDate= Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(cte.CreatedDate, DateTimeKind.Utc)),
                             UpdatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(cte.UpdatedDate, DateTimeKind.Utc)),
                         };
            listCategory.Items.AddRange(result.ToArray());
            return Task.FromResult(listCategory);
        }

        public override Task<Protos.Category> GetCategoryById(CategoryId request, ServerCallContext context)
        {
            var category = NtqTrainingContext.Categories.Find(request.Id);
            if(category == null)
            {
                return null;
            }
            else
            {
                return Task.FromResult(new Protos.Category
                {
                    Name=category.Name,
                    TagName=category.TagName,
                    Active=category.Active ?? true,
                    CreatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(category.CreatedDate, DateTimeKind.Utc)),
                    UpdatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(category.UpdatedDate, DateTimeKind.Utc)),
                });
            }
        }

        public override Task<Protos.Category> Update(Protos.Category request, ServerCallContext context)
        {
            var category=NtqTrainingContext.Categories.Find(request.Id);
            if(category == null)
            {
                return Task.FromResult<Protos.Category>(null);
            }
            else
            {
                category.Name = request.Name;
                category.TagName = request.TagName;
                category.Active = request.Active;
                category.CreatedDate = request.CreatedDate.ToDateTime();
                category.UpdatedDate = request.UpdatedDate.ToDateTime();
                //NtqTrainingContext.Categories.Update(category);
                NtqTrainingContext.SaveChanges();
                return Task.FromResult(request);
            }
        }
    }
}
