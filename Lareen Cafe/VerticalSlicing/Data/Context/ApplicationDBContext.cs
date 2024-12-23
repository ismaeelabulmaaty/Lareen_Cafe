using Lareen_Cafe.VerticalSlicing.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace LareenCafe.Api.VerticalSlicing.Data.Context
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
           : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderLog> orderLogs { get; set; }
        public DbSet<AccountsPayableReceivable> accountsPayableReceivables { get; set; }
        public DbSet<OrderType> orderType { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductsCostControl> ProductsCostControls { get; set; }
        public DbSet<ProductUnit> ProductUnits { get; set; }
        public DbSet<Purchase> purchases { get; set; }
        public DbSet<PurchaseLog> purchaseLogs { get; set; }
        public DbSet<PurchasesDetails> purchasesDetails { get; set; }
        public DbSet<PurchaseType> PurchaseTypes { get; set; }
        public DbSet<RawMatCategory> rawMatCategories { get; set; }
        public DbSet<RawMaterial> rawMaterials { get; set; }
        public DbSet<RawMatUnit> rawMatUnits { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<Treasury> treasuries { get; set; }
        public DbSet<WareHouse> wareHouses { get; set; }

        public DbSet<User> users{ get; set; }

        public DbSet<UserRole> userRoles{ get; set; }

        public DbSet<Role> roles { get; set; }

        public DbSet<RefreshToken> refreshTokens { get; set; }


    }
}
