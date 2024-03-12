using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjekatSWE.Models;

namespace ProjekatSWE.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public Korisnik Korisnik { get; set; }
        
        private BukSelfContext bukself;

        public RegisterModel(BukSelfContext context)
        {
            bukself = context;
        }
        public void OnGet()
        {
        }
        
        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            bukself.Korisnici.Add(Korisnik);
            await bukself.SaveChangesAsync();
            string username = Korisnik.Username;

            return RedirectToPage("Login");
        }
    }
}
