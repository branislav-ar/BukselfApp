using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjekatSWE.Models;

namespace ProjekatSWE.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Korisnik Korisnik {get;set;}
        private BukSelfContext bukself;
        public Korisnik Temp {get;set;}

        public LoginModel (BukSelfContext context)
        {
            bukself = context;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Temp = await bukself.Korisnici.FindAsync(Korisnik.Username);
            if (Temp.Pw == Korisnik.Pw){
                return RedirectToPage("./profil", new { username = Korisnik.Username });
            }
            else 
            {
                return RedirectToPage("./login");
            }
        }
    
    }
    
}