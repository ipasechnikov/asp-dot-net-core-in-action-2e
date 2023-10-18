using System.ComponentModel.DataAnnotations;

using H_RazorPageFormLayout.Models;
using H_RazorPageFormLayout.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace H_RazorPageFormLayout.Pages
{
    public class EditProductModel : PageModel
    {
        private readonly ProductService _productService;

        public EditProductModel(ProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IActionResult OnGet(int id)
        {
            ProductDetails product = _productService.GetProduct(id);
            if (product is null)
            {
                return NotFound();
            }

            Input = new InputModel
            {
                Name = product.ProductName,
                Price = product.SellPrice,
            };

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            ProductDetails product = _productService.GetProduct(id);
            if (product is null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _productService.UpdateProduct(id, Input.Name, Input.Price);

            return RedirectToPage("Index");
        }

        public class InputModel
        {
            [Required]
            public string Name { get; set; }

            [Range(0, int.MaxValue)]
            public decimal Price { get; set; }
        }
    }
}
