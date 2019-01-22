using Microsoft.EntityFrameworkCore;
using TPT;

namespace TPH
{
    public class AppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=tcp:zqla14cbns.database.windows.net,1433;Initial Catalog=TPT;Persist Security Info=False;User ID=dbadmin;Password=Hyundai1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public DbSet<InvestorProduct> InvestorProducts { get; set; }
        public DbSet<SippInvestorProduct> SippInvestorProducts { get; set; }
    }
}