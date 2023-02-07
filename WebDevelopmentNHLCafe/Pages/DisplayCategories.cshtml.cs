using System.Collections;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebDevelopmentNHLCafe.Models;
using WebDevelopmentNHLCafe.Repositories;

namespace WebDevelopmentNHLCafe.Pages;

public class DisplayCategories : PageModel
{
    public IEnumerable<Category> Categories { get; set; } = null!;
    
    public void OnGet()
    {
        Categories = new CategoryRepository().GetCategoriesWithProducts();
    }

    
}