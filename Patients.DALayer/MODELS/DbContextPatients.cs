using Patients.DALayer.MODELS.ENTITIES;
using System.Data.Entity;

namespace Patients.DALayer.MODELS.DATA
{
    public class DbContextPatients : DbContext
    {
        public DbContextPatients() : base("name=PatientsDbContext")
        { }
        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
    }
}
