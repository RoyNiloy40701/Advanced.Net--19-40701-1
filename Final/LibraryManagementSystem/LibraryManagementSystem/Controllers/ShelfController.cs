using BusinessLogic.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Provider;

namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShelfController : ControllerBase
    {
        protected readonly IEntityProvider<Shelf, int> _shelfProvider;
        public ShelfController(IEntityProvider<Shelf, int> entityProvider)
        {
            _shelfProvider = entityProvider;
        }

        [Route("shelf")]
        [HttpGet]
        public ActionResult<Shelf> GetShelf(int id)
        {
            var shelf = _shelfProvider.Get(id);
            return Ok(shelf);
        }

        [Route("shelves")]
        [HttpGet]
        public ActionResult<List<Shelf>> GetShelves()
        {
            var shelves = _shelfProvider.GetAll();
            return Ok(shelves);
        }

        [Route("shelf/add")]
        [HttpGet]
        public ActionResult<bool> AddShelf(Shelf shelf)
        {
            return Ok(_shelfProvider.Add(shelf));
        }

        [Route("shelf/remove")]
        [HttpGet]
        public ActionResult<bool> RemoveShelf(int id)
        {
            return Ok(_shelfProvider.Remove(id));
        }

        [Route("shelf/update")]
        [HttpGet]
        public ActionResult<bool> UpdateShelf(Shelf shelf)
        {
            return Ok(_shelfProvider.Update(shelf));
        }
    }
}
