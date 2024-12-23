using LareenCafe.Api.VerticalSlicing.Data.Entities;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class WareHouse : BaseEntity
    {
        public string WareHouseCode { get; set; }
        public string WareHouseName { get; set; }

        public ICollection<Purchase> purchases { get; set; } = new List<Purchase>();
        public ICollection<AccountsPayableReceivable> accountsPayableReceivables { get; set; }

    }
}
