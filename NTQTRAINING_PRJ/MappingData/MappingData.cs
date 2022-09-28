namespace NTQTRAINING_PRJ.MappingData
{
    public class MappingData
    {
        public Protos.Category EntityToProto(Models.Category request)
        {
            Protos.Category categoryProto = new Protos.Category();
            categoryProto.Id = request.Id;
            categoryProto.Name = request.Name;
            categoryProto.TagName = request.TagName;
            categoryProto.Active = request.Active?? true;
            categoryProto.CreatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(request.CreatedDate, DateTimeKind.Utc));
            categoryProto.UpdatedDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.SpecifyKind(request.UpdatedDate, DateTimeKind.Utc));
            return categoryProto;
        }

        public Models.Category ProtoToEntity(Protos.Category request)
        {
            Models.Category categoryEntity = new Models.Category();
            categoryEntity.Id = request.Id;
            categoryEntity.Name = request.Name;
            categoryEntity.TagName = request.TagName;
            categoryEntity.Active = request.Active;
            categoryEntity.CreatedDate = request.CreatedDate.ToDateTime();
            categoryEntity.UpdatedDate = request.UpdatedDate.ToDateTime();
            return categoryEntity;
        }
    }
}
