using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo
    {
        static onlinetechshopdbEntities db;
  
        static ProductRepo()
        {
            db = new onlinetechshopdbEntities();
        }

        public static List<product> GetAll()
        {
            return db.products.ToList();
        }

        public static product Get(int id)
        {
            return db.products.FirstOrDefault(e => e.pid == id);
        }

        public static void Edit(product p)
        {
            var pr = db.products.FirstOrDefault(e => e.pid == p.pid);
            db.Entry(pr).CurrentValues.SetValues(p);
            db.SaveChanges();
        }
        public static void Delete(int id)
        {
            var pr = db.products.FirstOrDefault(e => e.pid ==id);
            db.products.Remove(pr);
            db.SaveChanges();
        }

    }
}
