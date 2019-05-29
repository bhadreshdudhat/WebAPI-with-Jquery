using BLL.Domain;
using System.Data.Entity;

namespace DAL.Repositories
{
    public class FDB5331Context : DbContext
    {
        public FDB5331Context()
            : base("name=FDB5331Entities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Student> Students { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
