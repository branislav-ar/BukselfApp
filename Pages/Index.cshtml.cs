using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjekatSWE.Models;

namespace ProjekatSWE.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Korisnik Korisnik { get; set;}

        private BukSelfContext bukself;

        public IndexModel (BukSelfContext context)
        {
            bukself = context;
        } 

        public async Task OnGet(string username)
        {
            Korisnik = await bukself.Korisnici.FindAsync(username);
        }
        
    }
}
