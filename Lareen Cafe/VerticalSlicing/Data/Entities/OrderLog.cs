using LareenCafe.Api.VerticalSlicing.Data.Entities;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class OrderLog : BaseEntity
    {
        //public Branch branch { get; set; }

        //public Product product { get; set; }

        public double Amount { get; set; }

        public DateTime OrderDate { get; set; }

        public OrderDetails orderDetails { get; set; }
    }
}
