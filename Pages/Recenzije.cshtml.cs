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
    public class RecenzijeModel : PageModel
    {
        private BukSelfContext bukself;

        [BindProperty]
        public Knjiga Knjiga { get; set;}
        
        [BindProperty]
        public Korisnik Korisnik { get; set;}

        [BindProperty]
        public Recenzija Recenzija { get; set;}

        public List<Recenzija> Recenzije {get;set;}
        public List<Knjiga> Knjige {get;set;}


        public RecenzijeModel (BukSelfContext context)
        {
            bukself = context;
        }

        public async Task OnGet(string username)
        {
            Recenzije = await bukself.Recenzije.ToListAsync();
            Knjige = await bukself.Knjige.ToListAsync();
            Korisnik = await bukself.Korisnici.FindAsync(username);
        }
    }
}
