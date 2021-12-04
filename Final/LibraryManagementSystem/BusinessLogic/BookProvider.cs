using BusinessLogic.Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provider
{
    public class BookProvider : IEntityProvider<Book, int>
    {
        protected readonly AppDbContext _appDbContext;
        public BookProvider(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public bool Add(Book entity)
        {
            _appDbContext.Add<Book>(entity);
            return (_appDbContext.SaveChanges() > 0);
        }

        public List<Book> GetAll()
        {
            return _appDbContext.Books.ToList<Book>();
        }

        public List<Book> GetBooksInShelf(int id)
        {
            var books = (from book in _appDbContext.Books where book.ShelfId == id select book).ToList<Book>();
            return books;
        }

        public Book Get(int id)
        {
            return _appDbContext.Find<Book>(id);
        }

        public bool Remove(int id)
        {
            var book = (from book in _appDbContext.Books where book.Id == id select book).FirstOrDefault<Book>();
            _appDbContext.Remove(book);
            return (_appDbContext.SaveChanges() > 0);
        }

        public bool Update(Book entity)
        {
            _appDbContext.Update(entity);
            return (_appDbContext.SaveChanges() > 0);
        }
    }
}
