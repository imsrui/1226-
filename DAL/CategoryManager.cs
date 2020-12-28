using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryManager : ICategoryManager
    {
        private SqlContext db = new SqlContext();
        public int CateAdd(Category category)
        {
          
            db.Entry(category).State = EntityState.Added;
            return db.SaveChanges();
        }

        public int CateDelete(Guid id)
        {
            db.Entry(id).State = EntityState.Deleted;
            return db.SaveChanges();
        }

        public int CateEdit(Category catagory)
        {
            db.Entry(catagory).State = EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
