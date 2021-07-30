using Microsoft.EntityFrameworkCore;
using TransactionTest.Models;

namespace TransactionTest.Context
{
    public class CovidDBContext : DbContext
    {
        public CovidDBContext(DbContextOptions<CovidDBContext> options) : base(options)
        {
        }

        public DbSet<Citizen> Citizen { get; set; }
        public DbSet<CovidTest> CovidTest { get; set; }

    }
}
