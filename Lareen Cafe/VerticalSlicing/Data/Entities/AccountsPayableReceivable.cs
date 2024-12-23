using LareenCafe.Api.VerticalSlicing.Data.Entities;
using Microsoft.VisualBasic;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class AccountsPayableReceivable : BaseEntity
    {
        public int CreditOrDebit { get; set; }

        public double Amount { get; set; }

        public DateTime DueDate { get; set; }

        public int Status { get; set; }

        /// entered 1 -- due 2 - paid 3

        //public ICollection<Customers>? customer { get; set; } = new List<Customers>();
        //public ICollection<Suppliers>? supplier { get; set; } = new List<Suppliers>();

        public Order? order { get; set; } // will be defaulted to 0 if not order
        public Purchase? purchase { get; set; } // will be defaulted to 0 if not purchase
        //public Branch? branche { get; set; }
        //public WareHouse? warehouse { get; set; }
    }
}
