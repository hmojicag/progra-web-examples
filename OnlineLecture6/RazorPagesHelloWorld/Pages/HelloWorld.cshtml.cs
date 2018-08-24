using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesHelloWorld.Pages
{
    public class HelloWorldModel : PageModel {

        public List<string> SongNames;

        public void OnGet() {
            SongNames = new List<string>();
            SongNames.Add("Birth of Venus Illegitima");
            SongNames.Add("The Invincible");
            SongNames.Add("O Fortuna");
            SongNames.Add("Raven of dispersion");
        }
    }
}
