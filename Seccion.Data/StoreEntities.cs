using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Seccion.Data.Configuration;
using Seccion.Model.IdentityModel;
using Seccion.Model.TblModels;

namespace Seccion.Data
{
    public class StoreEntities : IdentityDbContext<ApplicationUser>
    {
        public StoreEntities()
        {
        }

        public StoreEntities(DbContextOptions options) : base(options) { }

        //public DbSet<Gadget> Gadgets { get; set; }
        //public DbSet<Category> Categories { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        public DbSet<TbEmployee> Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new GadgetConfiguration());
            //modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new TbEmployeeConfiguration());
        }
    }
}
