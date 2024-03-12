using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjekatSWE.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjekatSWE.Pages
{
    public class FavBookModel : PageModel
    {
        private BukSelfContext bukself;

        [BindProperty] 
        public Knjiga Knjiga { get; set;}
        
        [BindProperty]
        public Korisnik Korisnik { get; set;}
        [BindProperty]
        public  Favourite Omiljenjaknjiga { get; set;}
        public List<Knjiga> Knjige {get;set;}
        public List<Favourite> OmiljeneKnjige {get;set;}
        public FavBookModel (BukSelfContext context)
        {
            bukself = context;
        }
        public async Task OnGet(string username)
        {
            Korisnik = await bukself.Korisnici.FindAsync(username);
            Knjige = await bukself.Knjige.ToListAsync();
            OmiljeneKnjige = await bukself.OmiljeneKnjige.Where(e => e.Uname.Contains(username)).ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync(string uname, int idk)
        {
            Korisnik = await bukself.Korisnici.FindAsync(uname);
            OmiljeneKnjige = await bukself.OmiljeneKnjige.Where(e => e.Uname.Contains(uname)).ToListAsync();
            var temp = bukself.OmiljeneKnjige.Where(p => p.IDK == idk).FirstOrDefault();
            bukself.OmiljeneKnjige.Remove(temp);
            await bukself.SaveChangesAsync();
            return RedirectToPage("FavBook", new { username = Korisnik.Username});
        }        
    }
}
