using BookApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private static readonly List<Book> books = new List<Book>()
        {
            Book.Random(),
            Book.Random(),
            Book.Random(),
        };

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(books);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetBook([FromRoute] string id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            return Ok(book);
        }


        [HttpPost]
        public IActionResult AddBook([FromBody] Book book)
        {
            book.Id = Guid.NewGuid().ToString();
            books.Add(book);
            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateBook([FromRoute] string id, [FromBody] Book newBook)
        {
            var oldBook = books.FirstOrDefault(x => x.Id == id);
            if(oldBook != null)
            {
                oldBook.Author = newBook.Author;
                oldBook.Title = newBook.Title;
                oldBook.Page = newBook.Page;
            }
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteBook([FromRoute] string id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book != null)
                books.Remove(book);

            return Ok();
        }

    }
}
