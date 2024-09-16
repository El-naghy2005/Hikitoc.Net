using Microsoft.EntityFrameworkCore;
using hikitocAPI.Models.Domain;


namespace hikitocAPI.Data
{
    public class HikitocDbContext : DbContext // سيقوم سياق قاعده البيانات بتغليف هذه الخصائص الثلاثه وتعيينها
                                              // في جداول في قاعده البيانات عندما تبدا عمليه الترحيل
    {
        public HikitocDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<SolarSystem> SolarSystems { get; set; }
        public DbSet<Water> Waters { get; set; }

        //protected override void  OnModelCreatting(ModelBuilder modelBilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBilder.Entity<Planet>().ToTable("NewPlanets");
        //    modelBilder.Entity<SolarSystem>().ToTable("NewSolarSystem");
        //    modelBilder.Entity<Water>().ToTable("Waters");
        //}
    }
}
