using A_RoutingExamples.Models;
using A_RoutingExamples.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A_RoutingExamples.Pages.ProductDetails
{
    public class IndexModel : PageModel
    {
        private readonly ProductService _productService;

        public IndexModel(ProductService productService)
        {
            _productService = productService;
        }

        public Product Selected { get; set; }

        public IActionResult OnGet(string name)
        {
            Selected = _productService.GetProduct(name);
            if (Selected is null)
                return NotFound();

            return Page();
        }
    }
}
