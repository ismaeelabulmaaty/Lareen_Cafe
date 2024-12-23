using LareenCafe.Api.VerticalSlicing.Data.Entities;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class RawMaterial : BaseEntity
    {
        public string RawMaterialName { get; set; }


        public RawMatCategory rawMatCategory { get; set; }

        public RawMatUnit rawMatUnits { get; set; }

        public ICollection<ProductsCostControl>  productsCostControls { get; set; } = new List<ProductsCostControl>();

        public ICollection<PurchasesDetails> purchasesDetails { get; set; } = new List<PurchasesDetails>();


    }
}
