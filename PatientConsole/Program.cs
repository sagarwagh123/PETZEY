using Patients.DALayer.MODELS.DATA;
using Patients.DALayer.MODELS.ENTITIES;

namespace PatientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContextPatients db = new DbContextPatients();
            System.Console.WriteLine("hello");
            var o = new Owner() {Name="gg" };
            db.Owners.Add(o);
            db.SaveChanges();
            System.Console.ReadLine();
        }
    }
}
