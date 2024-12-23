using LareenCafe.Api.VerticalSlicing.Data.Entities;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class Customer : BaseEntity
    {
        public string CustomerName { get; set; }

        public string? CustomerMobile { get; set; }

        public string? CustomerAddress { get; set; }

        public double? CustomerBalance { get; set; }

        public ICollection<Order> orders { get; set; }
    }
}
