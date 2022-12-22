using BookWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookWebApp.Controllers
{
    public class BooksController : Controller
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public BooksController(IConfiguration configuration)
        {
            var apiUrl = configuration.GetValue<string>("ApiUrl");
            _httpClient.BaseAddress = new Uri(apiUrl + "api/");
        }

        public async Task<IActionResult> Index()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "Books");
            var response = await _httpClient.SendAsync(request);
            var books = await response.Content.ReadFromJsonAsync<List<BookModel>>();
            ViewBag.Books = books;
            return View();
        }

        public async Task<IActionResult> AddBookAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "Books");
            request.Content = JsonContent.Create<BookModel>(new BookModel()
            {
                Author = "Author - " + DateTime.Now.ToString(),
                Title = "Title - " + DateTime.Now.ToString(),
                Page = 300
            });
            var response = await _httpClient.SendAsync(request);
            return RedirectToAction("Index");
        }
     

    }
}
