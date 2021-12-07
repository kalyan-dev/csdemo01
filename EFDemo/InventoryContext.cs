using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace csdemo01.EFDemo
{
    class InventoryContext:DbContext
    {
        public InventoryContext() 
            :base(@"Data Source=DESKTOP-DTHUJB7\SQLDEV2017;Initial Catalog=rccltest;Integrated Security=True")
        { }

        public DbSet<Categories> Categories { get; set; }

        public DbSet<Book> books { get; set; }
    }
}
