using System.Data.Entity;

namespace HospitalProject_N01338717.Data
{
    public class HospitalProjectContext:DbContext
    {
        public HospitalProjectContext():base("name=HospitalProjectContext")
        {

        }

        public System.Data.Entity.DbSet<HospitalProject_N01338717.Models.Registration> Registrations { get; set; }
    }
}