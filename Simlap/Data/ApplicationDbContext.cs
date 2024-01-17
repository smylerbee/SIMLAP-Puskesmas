using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Simlap.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Spm> Spms { get; set; }
        public DbSet<SpmHeader> SpmHeaders { get; set; }
        public DbSet<SpmInfo> SpmInfos { get; set; }
        public DbSet<LapSpm> LapSpms { get; set; }
        public DbSet<Pegawai> Pegawais { get; set; }
        public DbSet<Uptd> Uptds { get; set; }
        public DbSet<UserPkm> UserPkms { get; set; }
    }
}