using Microsoft.EntityFrameworkCore;
using VNR_InternShip_Technical_Test.Data.Entities;

namespace VNR_InternShip_Technical_Test.Data
{
    public class VNR_Technical_Test_Context : DbContext
    {
        public VNR_Technical_Test_Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<KhoaHoc> KhoaHoc { get; set; }
    }
}
