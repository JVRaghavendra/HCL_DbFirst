using HCL_DbFirst.BusinessEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL_DbFirst.DatabaseLogic.DbConnect
{
    public class EmployeeManagementContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-MHF1QN4;initial Catalog=HCL_DbFirst;Integrated Security=True;");
        }
    }
}
