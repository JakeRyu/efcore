using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using TPT;

namespace TPH
{
    public class AppContext : DbContext
    {
        public static readonly LoggerFactory MyLoggerFactory
            = new LoggerFactory(new[] {new ConsoleLoggerProvider((str, logLevel) => true, true)});

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory)
                .UseSqlServer(
                "Server=tcp:zqla14cbns.database.windows.net,1433;Initial Catalog=TPH;Persist Security Info=False;User ID=dbadmin;Password=Hyundai1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;",
              option => option.MinBatchSize(1));
        }

        public DbSet<InvestorProduct> InvestorProducts { get; set; }
        public DbSet<SippInvestorProduct> SippInvestorProducts { get; set; }
    }
}