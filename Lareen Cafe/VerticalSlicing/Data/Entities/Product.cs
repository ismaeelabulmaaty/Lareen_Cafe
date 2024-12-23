using LareenCafe.Api.VerticalSlicing.Data.Entities;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class Product : BaseEntity
    {
        public string productName { get; set; }

        public ProductCategory productCategory { get; set; }

        public ProductUnit productUnit { get; set; }

        public ICollection<ProductsCostControl> productsCostControls { get; set; } = new List<ProductsCostControl>();

    }
}
