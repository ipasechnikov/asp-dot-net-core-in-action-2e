using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using A_RoutingExamples.Models;
using A_RoutingExamples.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;

namespace A_RoutingExamples.Pages
{
    public class SearchModel : PageModel
    {
        private readonly ProductService _productService;
        private readonly LinkGenerator _linkGenerator;

        public SearchModel(ProductService productService, LinkGenerator linkGenerator)
        {
            _productService = productService;
            _linkGenerator = linkGenerator;
        }

        [BindProperty, Required]
        public string SearchTerm { get; set; }

        public List<Product> Results { get; set; }


        public void OnGet()
        {
            var url1 = Url.Page("ProductDetails/Index", new { name = "big-widget" });
            var url2 = _linkGenerator.GetPathByPage("/ProductDetails/Index", values: new { name = "big-widget" });
            var url3 = _linkGenerator.GetPathByPage(HttpContext, "/ProductDetails/Index", values: new { name = "big-widget" });
            var url4 = _linkGenerator.GetUriByPage(
                page: "/ProductDetails/Index",
                handler: null,
                values: new { name = "big-widget" },
                scheme: "https",
                host: new HostString("example.com")
            );
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Results = _productService.Search(SearchTerm, StringComparison.Ordinal);
            }
        }

        public void OnPostIgnoreCase()
        {
            if (ModelState.IsValid)
            {
				Results = _productService.Search(SearchTerm, StringComparison.OrdinalIgnoreCase);
			}
        }
    }
}
