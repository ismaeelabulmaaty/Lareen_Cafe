using LareenCafe.Api.VerticalSlicing.Data.Entities;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class OrderDetails : BaseEntity
    {
        public Product product { get; set; }

        public string productName { get; set; }

        public double productPrice { get; set; }

        public double Quantity { get; set; }

        public double TotalOrderDetails { get; set; }
        public Order order { get; set; }
    }
}
