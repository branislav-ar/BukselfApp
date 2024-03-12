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
    public class BookModel : PageModel
    {
        private BukSelfContext bukself;

        [BindProperty]
        public Knjiga Knjiga { get; set;}
        
        [BindProperty]
        public Korisnik Korisnik { get; set;}

        [BindProperty]
        public Recenzija Recenzija { get; set;}

        public List<Recenzija> Recenzije {get;set;}
        public List<Korisnik> Korisnici {get;set;}
        public List<Favourite> OmiljeneKnjige {get;set;}

        [BindProperty]
        public Favourite OmiljenaKnjiga {get;set;} 
      
        public BookModel (BukSelfContext context)
        {
            bukself = context;
        }
        
        public async Task OnGet(int id, string username)
        {
            Knjiga = await bukself.Knjige.FindAsync(id);
            Korisnik = await bukself.Korisnici.FindAsync(username);
            Recenzije = await bukself.Recenzije.ToListAsync();
            Korisnici = await bukself.Korisnici.ToListAsync();
        }

        public FileResult OnGetImage(string path)
        {
            var bytes = System.IO.File.ReadAllBytes(path);
            return File(bytes, "images/png");
        }

        public async Task<IActionResult> OnPostAsync(int id, string username)
        {
            if(!ModelState.IsValid)
            {
                Knjiga = await bukself.Knjige.FindAsync(id);
                return RedirectToPage("./book", new { id = Knjiga.ID,username = Korisnik.Username});
            }
            Knjiga = await bukself.Knjige.FindAsync(id);
            Korisnik = await bukself.Korisnici.FindAsync(username);  
            Recenzija.IDK=id;
            Recenzija.Uname=username;
            if(Recenzija.Ocena==1)
            {
                Knjiga.Br1++;
            }
            if(Recenzija.Ocena==2)
            {
                Knjiga.Br2++;
            }
            if(Recenzija.Ocena==3)
            {
                Knjiga.Br3++;
            }
            if(Recenzija.Ocena==4)
            {
                Knjiga.Br4++;
            }
            if(Recenzija.Ocena==5)
            {
                Knjiga.Br5++;
            }
            Knjiga.BrR++;
            Korisnik.BrR++;

            bukself.Recenzije.Add(Recenzija);
            bukself.Knjige.Update(Knjiga);
            bukself.Korisnici.Update(Korisnik);

            await bukself.SaveChangesAsync();
            return RedirectToPage("./book", new { id = Knjiga.ID,username = Korisnik.Username});
        }
    
        public IActionResult OnPostDodajUOmiljeno(int id, string username)
        {
            Knjiga =  bukself.Knjige.Find(id);
            Korisnik =  bukself.Korisnici.Find(username);
            OmiljenaKnjiga.Uname = username;
            OmiljenaKnjiga.IDK = id;
            bukself.OmiljeneKnjige.Add(OmiljenaKnjiga);
            bukself.SaveChanges();

            return RedirectToPage("./book", new { id = Knjiga.ID,username = Korisnik.Username});
        } 
    }
}
