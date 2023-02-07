using Microsoft.AspNetCore.Mvc.RazorPages;
using WebDevelopmentNHLCafe.Models;
using WebDevelopmentNHLCafe.Repositories;

namespace WebDevelopmentNHLCafe.Pages.Categories;

public class Index : PageModel
{
    public IEnumerable<Category> Categories { get; set; } = null!;
    public IEnumerable<Category> CategoriesWithProduct { get; set; } = null!;
    
    public void OnGet()
    {
        Categories = new CategoryRepository().Get();
        CategoriesWithProduct = new CategoryRepository().GetCategoriesWithProducts();
    }

    
}