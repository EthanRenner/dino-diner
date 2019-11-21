// Menu.cshtml.cs
// Author: Ethan Renner
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu Menu { get; } = new Menu();

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public double minimumPrice { get; set; }

        [BindProperty]
        public double maximumPrice { get; set; }

        [BindProperty]
        public List<string> excludeIngredient { get; set; } = new List<string>();
        public void OnGet()
        {

        }

    }
}