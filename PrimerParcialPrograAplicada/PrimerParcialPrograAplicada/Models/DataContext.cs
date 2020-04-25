using System.Data.Entity;

namespace PrimerParcialPrograAplicada.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base ("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<PrimerParcialPrograAplicada.Models.callau> callaus { get; set; }
    }
    
}