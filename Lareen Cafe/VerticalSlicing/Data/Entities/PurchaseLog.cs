using LareenCafe.Api.VerticalSlicing.Data.Entities;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class PurchaseLog : BaseEntity
    {
        //public WareHouse wareHouses { get; set; }

        //public RawMaterial rawMaterial { get; set; }

        public double Amount { get; set; }

        public DateTime PurchaseDate { get; set; }

        public PurchasesDetails PurchasesDetails { get; set; }
    }
}
