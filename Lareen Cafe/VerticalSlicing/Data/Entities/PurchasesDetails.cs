using LareenCafe.Api.VerticalSlicing.Data.Entities;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class PurchasesDetails : BaseEntity
    {

        public Purchase purchases { get; set; }

        //public WareHouse wareHouse { get; set; }

        public RawMaterial rawMaterial { get; set; }

        public double PurchasePrice { get; set; }

        public double PurchaseQuantity { get; set; }

        public double TotalPurchaseDetails { get; set; }
    }
}
