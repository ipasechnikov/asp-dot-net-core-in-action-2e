using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace D_SimpleCurrencyConverterBindings.Pages
{
    public class ConvertModel : PageModel
    {
        public string Values { get; set; }

        public void OnGet(
            string currencyIn,
            string currencyOut,
            int qty
        )
        {
            Values = $@"CurrencyIn: {currencyIn}
CurrencyOut: {currencyOut}
Qty: {qty}";
        }
    }
}
