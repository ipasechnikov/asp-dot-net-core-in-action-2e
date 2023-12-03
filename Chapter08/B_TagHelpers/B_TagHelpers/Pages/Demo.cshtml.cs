using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace B_TagHelpers.Pages
{
    public class DemoModel : PageModel
    {
        public int Int { get; set; }
        public bool Boolean { get; set; }
        public DateTime? DateTime { get; set; }

        public void OnGet()
        {
        }
    }
}
