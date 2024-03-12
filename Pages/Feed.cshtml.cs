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
    public class FeedModel : PageModel
    {
        private BukSelfContext bukself;
        
        [BindProperty]
        public Korisnik Korisnik { get; set;}
        [BindProperty]
        public Knjiga Knjiga { get; set;}
        public List<Korisnik> Korisnici {get;set;}
        public List<Recenzija> Recenzije {get;set;}
        public List<Recenzija> Recenzije2 {get;set;}
        public List<Knjiga> Knjige {get;set;}
        
        public List<FavUser> OmiljeniKorisnici {get;set;}
        
        public FeedModel (BukSelfContext context)
        {
            bukself = context;
        }
        public async Task OnGet(string username)
        {
            Knjige = await bukself.Knjige.ToListAsync();
            Korisnici = await bukself.Korisnici.ToListAsync();
            Korisnik = await bukself.Korisnici.FindAsync(username);
            Recenzije2 = new List<Recenzija>();
            OmiljeniKorisnici = await bukself.OmiljeniKorisnici.Where(e => e.Uname1.Contains(username)).ToListAsync(); // samo ljudi koje prati osoba   
            Recenzije = await bukself.Recenzije.ToListAsync();
            foreach(var v in Recenzije)
            {
                int temp = 0;
                foreach(var t in OmiljeniKorisnici)
                {
                    if (v.Uname == t.Uname2)
                    {
                        temp = 1;
                    }
                    
                }
            if (temp==1)
                {
                    Recenzije2.Add(v);
                }
            }

            Recenzije2 = Recenzije2.OrderBy(o=>o.Datum).ToList();
            Recenzije2.Reverse();
            await bukself.SaveChangesAsync();
        }
    }
}
