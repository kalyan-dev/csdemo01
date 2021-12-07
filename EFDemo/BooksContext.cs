using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.EFDemo
{
    class BooksContext:DbContext
        

    {
        public BooksContext() 
            :base(@"Data Source=DESKTOP-DTHUJB7\SQLDEV2017;Initial Catalog=rccltest;Integrated Security=True")
        { }

        public DbSet<Book> books { get; set; }
    }
}
