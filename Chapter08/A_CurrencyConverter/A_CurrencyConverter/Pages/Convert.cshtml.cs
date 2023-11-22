using System.ComponentModel.DataAnnotations;
using A_CurrencyConverter.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace A_CurrencyConverter.Pages
{
    public class ConvertModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

        public SelectListItem[] CurrencyCodes { get; } =
        {
            new SelectListItem { Text = "GBP", Value = "GBP" },
            new SelectListItem { Text = "USD", Value = "USD" },
            new SelectListItem { Text = "CAD", Value = "CAD" },
            new SelectListItem { Text = "EUR", Value = "EUR" },
        };

        public void OnGet()
        {
            Input = new InputModel();
        }

        public IActionResult OnPost()
        {
            if (Input.CurrencyFrom == Input.CurrencyTo)
            {
                ModelState.AddModelError(string.Empty, "Cannot convert currency to itself");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Store the valid values somewhere (e.g. database), 
            // do the conversion etc

            return RedirectToPage("Success");
        }

        public class InputModel
        {
            [Required]
            [StringLength(3, MinimumLength = 3)]
            [CurrencyCode("GBP", "USD", "CAD", "EUR")]
            [Display(Name = "Currency From")]
            public string CurrencyFrom { get; set; }

            [Required]
            [StringLength(3, MinimumLength = 3)]
            [CurrencyCode("GBP", "USD", "CAD", "EUR")]
            [Display(Name = "Currency To")]
            public string CurrencyTo { get; set; }

            [Required]
            [Range(1, 1000)]
            public int Quality { get; set; }
        }
    }
}
