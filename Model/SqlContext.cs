using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SqlContext:DbContext
    {
        public SqlContext() : base("Dbcon"){ 
        
        
        }
        public virtual DbSet<Category> Catagories  { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
