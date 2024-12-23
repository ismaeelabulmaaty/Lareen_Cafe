using LareenCafe.Api.VerticalSlicing.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lareen_Cafe.VerticalSlicing.Data.Entities
{
    public class Supplier : BaseEntity
    {
        
        public string SupplierName { get; set; }

        public string SupplierMobile { get; set; }

        public string? Address { get; set; }

        public double SupplierBalance { get; set; }

        public ICollection<Purchase> Purchase { get; set; } = new List<Purchase>();


    }
}
