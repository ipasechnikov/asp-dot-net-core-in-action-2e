using B_ExampleBinding_EditProduct.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace B_ExampleBinding_EditProduct.Pages
{
    [IgnoreAntiforgeryToken]
    public class EditProductModel : PageModel
    {
        public ProductModel Product { get; set; }

        public void OnGet()
        {
        }

        public void OnPost(ProductModel product)
        {
            Product = product;
        }

        public void OnPostEditTwoProducts(ProductModel product1, ProductModel product2)
        {
            Product = product1;
        }
    }
}
