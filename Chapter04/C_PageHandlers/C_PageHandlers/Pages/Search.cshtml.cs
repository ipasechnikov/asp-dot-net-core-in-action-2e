using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using C_PageHandlers.Models;
using C_PageHandlers.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace C_PageHandlers.Pages
{
    public class SearchModel : PageModel
    {
        private readonly SearchService _searchService;

        public SearchModel(SearchService searchService)
        {
            _searchService = searchService;
        }

        [BindProperty]
        public BindingModel Input { get; set; }

        public List<Product> Results { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Results = _searchService.SearchProducts(Input.SearchTerm);
                return Page();
            }
            return RedirectToPage();
        }

        public class BindingModel
        {
            [Required]
            public string SearchTerm { get; set; }
        }
    }
}
