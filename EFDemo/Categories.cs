using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace csdemo01.EFDemo
{
    [Table("ProductCategories")]
    class Categories
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
    }
}
