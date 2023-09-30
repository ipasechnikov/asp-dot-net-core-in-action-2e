using A_RoutingExamples.Models;
using A_RoutingExamples.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A_RoutingExamples.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly ProductService _productService;

        public ProductsModel(ProductService productService)
        {
            _productService = productService;
        }

        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        public Product Selected { get; set; }

        public IActionResult OnGet()
        {
            Selected = _productService.GetProduct(Name);
            if (Selected is null)
                return NotFound();

            return Page();
        }
    }
}
