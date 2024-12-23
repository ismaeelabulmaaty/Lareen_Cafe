using LareenCafe.Api.VerticalSlicing.Data.Entities;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class ProductsCostControl : BaseEntity
    {
        public RawMaterial RawMaterial { get; set; }

        public Product product { get; set; }
        public double RawMaterialAmount { get; set; }

        public double RawMaterialCost { get; set; }

        public double RawMaterialsActualPrice { get; set; }

    }
}
