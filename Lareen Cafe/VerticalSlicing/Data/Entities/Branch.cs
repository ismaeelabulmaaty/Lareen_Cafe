using LareenCafe.Api.VerticalSlicing.Data.Entities;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class Branch : BaseEntity
    {
        public string BranchName { get; set; }

        public Treasury Treasury { get; set; }

        public WareHouse wareHouse { get; set; }

        public ICollection<Order> orders { get; set; }
        public ICollection<AccountsPayableReceivable> accountsPayableReceivables { get; set; }

    }
}
