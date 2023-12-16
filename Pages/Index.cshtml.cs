using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clase3.Models;
using Clase3.Services;
using Microsoft.AspNetCore.Http.HttpResults;
namespace Clase3.Pages;

public class IndexModel : PageModel
{
    public List<Movie> MovieList { get; set; } = default!;
    [BindProperty]
    public Movie NewMovie { get; set; }

    public IndexModel()
    {

    }

    public void OnGet()
    {
        MovieList = MovieServices.GetAll();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return RedirectToAction("/Error");
        }
        MovieServices.Add(NewMovie);
        return RedirectToAction("get");

    }
}
