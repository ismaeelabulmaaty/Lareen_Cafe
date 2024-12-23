using LareenCafe.Api.VerticalSlicing.Data.Entities;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class Order : BaseEntity
    {
        public Customer customer { get; set; }

        public OrderType orderType { get; set; }

        public double TotalOrderBefore { get; set; }

        public double OrderDiscount { get; set; }

        public double TotalOrderAfterDicount { get; set; }

        public double RemainingBalance { get; set; }

        public Branch branch { get; set; }

        public ICollection<OrderDetails> orderDetails { get; set; } = new List<OrderDetails>();


    }
}
