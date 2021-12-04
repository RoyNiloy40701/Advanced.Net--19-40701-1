using BusinessLogic.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Provider;

namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        protected readonly IEntityProvider<Book, int> _bookProvider;
        public BookController(IEntityProvider<Book, int> entityProvider)
        {
            _bookProvider = entityProvider;
        }

        [Route("book")]
        [HttpGet]
        public ActionResult<Book> GetBook(int id)
        {
            var book = _bookProvider.Get(id);
            return Ok(book);
        }

        [Route("books")]
        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            var books = _bookProvider.GetAll();
            return Ok(books);
        }

        [Route("books/shelf")]
        [HttpGet]
        public ActionResult<List<Book>> GetBooksShelf(int id)
        {
            var books = _bookProvider.GetBooksInShelf(id);
            return Ok(books);
        }

        [Route("book/add")]
        [HttpGet]
        public ActionResult<bool> AddBook(Book book)
        {
            return Ok(_bookProvider.Add(book));
        }

        [Route("book/remove")]
        [HttpGet]
        public ActionResult<bool> RemoveBook(int id)
        {
            return Ok(_bookProvider.Remove(id));
        }

        [Route("book/update")]
        [HttpGet]
        public ActionResult<bool> UpdateBook(Book book)
        {
            return Ok(_bookProvider.Update(book));
        }
    }
}
