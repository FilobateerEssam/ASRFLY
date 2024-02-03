using ASRFLY.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASRFLY.Data.SqlServer
{
    public class DBContext : DbContext
    {
        public DBContext()
        {
            
        }

        // Configiration Set Connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // for Development
            var sqlcon = "Server=DESKTOP-PSM134C\\SQLEXPRESS;Database=ASRFLY_DB;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(sqlcon);

        }

        // Models After Ref

        public DbSet<Categories> Categories { get; set; }


    }

}
