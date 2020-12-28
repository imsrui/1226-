using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;

namespace DAL
{
    public class ProductManager : IProductManager
    {
        private SqlContext db = new SqlContext();
        public int Add(Product product)
        {
            db.Entry(product).State = EntityState.Added;
            return db.SaveChanges();
        }

        public int Delete(Guid id)
        {
            db.Entry(id).State = EntityState.Deleted;
            return db.SaveChanges();

        }

        public int Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            return db.SaveChanges();

        }
    }
}
