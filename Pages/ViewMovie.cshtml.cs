using Clase3.Models;
using Clase3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class ViewMovieModel : PageModel
    {
        [BindProperty]
        public Movie MovieDetails { get; set; } = new();
        public void OnGet(string code)
        {
            var responseServiceData = MovieServices.get(code);
            if (responseServiceData != null)
            {
                MovieDetails = responseServiceData;
            }
        }

        public IActionResult OnPostDelete(string code)
        {
            if (code != null)
            {
                MovieServices.delete(code);
                return RedirectToPage("Index");
            }
            return RedirectToPage("Error");
        }
    }
}
