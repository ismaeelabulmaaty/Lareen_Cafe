using LareenCafe.Api.VerticalSlicing.Data.Entities;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class Purchase : BaseEntity
    {
        public Supplier  supplier { get; set; } 
        public DateTime PurchaseDate { get; set; }

        public double TotalPriceBefore { get; set; }

        public double discountAmount { get; set; }

        public double TotalAfterDiscount { get; set; }

        public double RemainingTotal { get; set; }

        public PurchaseType PurchaseType { get; set; }

        public WareHouse wareHouse { get; set; }

        public ICollection<PurchasesDetails> Purchases { get; set; } = new List<PurchasesDetails>();
    }
}
