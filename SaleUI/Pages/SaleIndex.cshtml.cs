using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SaleUI.Models;

namespace SaleUI.Pages
{
    public class SaleIndexModel : PageModel
    {
        public void OnGet()
        {

        }

        public ActionResult OnPost(SaleEntry saleEntry)
        {
            return Page();
        }

        [BindProperty]
        public SaleEntry SaleEntry { get; set; }
    }
}