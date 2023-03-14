using ENTITIES.HRM_Web_UTTOSoftware.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.HRM_Web_UTTOSoftware.Concrete.Context
{
    public class HRMContextDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:utto.database.windows.net,1433;Initial Catalog=ANK9_Team2_HRM_WebProject;Persist Security Info=False;User ID=utto;Password=team2.DB;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        DbSet<Person> Persons { get; set; }
    }
}
