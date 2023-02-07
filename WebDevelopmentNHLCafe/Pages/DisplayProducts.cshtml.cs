using Microsoft.AspNetCore.Mvc.RazorPages;
using WebDevelopmentNHLCafe.Models;
using WebDevelopmentNHLCafe.Repositories;

namespace WebDevelopmentNHLCafe.Pages;

public class DisplayProducts : PageModel
{
    public IEnumerable<Product> ProductWithCategory { get; set; } = null!;
    
    public void OnGet()
    {
        ProductWithCategory = new ProductRepository().GetProductWithCategory();
    }
}