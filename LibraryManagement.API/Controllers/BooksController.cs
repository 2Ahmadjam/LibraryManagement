using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.API.Services;
using KitapYonetim.Common.EF;

namespace LibraryManagement.API.Controllers
{
    [Route("api/Controller")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly IBooksService _service;

        public BooksController(IBooksService service)//dependency injection 
        {
            _service = service;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var result = await _service.GetBooks();
            return result.ToList();
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _service.GetBookById(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // PUT: api/Books/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")] //update
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            await _service.UpdateBook(book);

            return NoContent();
        }

        // POST: api/Books
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]//create
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            var createdBook = _service.CreateBook(book);

            return Ok(book);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {

            await _service.DeleteBook(id);


            return NoContent();
        }


    }
}
