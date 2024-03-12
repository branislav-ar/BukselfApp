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
    public class PratiociModel : PageModel
    {
        private BukSelfContext bukself;
        [BindProperty]
        public Korisnik Korisnik { get; set;}
        public FavUser OmiljeniKorisnik {get;set;} 
        public List<FavUser> OmiljeniKorisnici {get;set;}
        public List<Korisnik> Korisnici {get;set;}
        public PratiociModel (BukSelfContext context)
        {
            bukself = context;
        }        
        public async Task OnGet(string username)
        {
            OmiljeniKorisnici = await bukself.OmiljeniKorisnici.Where(e => e.Uname1.Contains(username)).ToListAsync();
            Korisnici = await bukself.Korisnici.ToListAsync();
            Korisnik = await bukself.Korisnici.FindAsync(username);
        }
    }
}
