using BusinessLogic.Entities;
using DataAccess;
using Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ShelfProvider : IEntityProvider(Shelf, int)
    {
        protected readonly AppDbContext _appDbContext;
        public ShelfProvider(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public bool Add(Shelf entity)
        {
            _appDbContext.Add<Shelf>(entity);
            return (_appDbContext.SaveChanges() > 0);
        }

        public List<Shelf> GetAll()
        {
            return _appDbContext.Shelves.ToList<Shelf>();
        }

        public List<Shelf> GetBooksInShelf(int id)
        {
            return null;
        }

        public bool Get(int id)
        {
            return _appDbContext.Find<Shelf>(id);
        }

        public bool Remove(int id)
        {
            var shelf = (from shelf in _appDbContext.Shelves where shelf.Id == id select shelf).FirstOrDefault<Shelf>();
            _appDbContext.Remove(shelf);
            return (_appDbContext.SaveChanges() > 0);
        }

        public bool Update(Shelf entity)
        {
            _appDbContext.Update(entity);
            return (_appDbContext.SaveChanges() > 0);
        }
    }
}
