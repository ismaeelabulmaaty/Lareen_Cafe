namespace LareenCafe.Api.VerticalSlicing.Data.Entities
{
    public class BaseEntity
    {
        public int      Id { get; set; }
        public bool     IsDeleted { get; set; }
        public int      CreatedBy { get; set; }
        public int      ModifiedBy { get; set; }
        public DateTime LastCreatedBy { get; set; }
        public DateTime LastModifiedBy { get; set; }

    }
}
