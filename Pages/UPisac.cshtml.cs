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
    public class UPisacModel : PageModel
    {
        private BukSelfContext bukself;

        [BindProperty]
        public Knjiga Knjiga { get; set;}
        
        [BindProperty]
        public Korisnik Korisnik { get; set;}
        
        [BindProperty]
        public Pisac Pisac { get; set;}

        public List<Korisnik> Korisnici {get;set;}
        
        public List<Pisac> Pisci {get; set;}
      
        public UPisacModel (BukSelfContext context)
        {
            bukself = context;
        }
        public async Task OnGet(int id)
        {   
            Knjiga = await bukself.Knjige.FindAsync(id);
            string pisac = Knjiga.Pisac;
            string[] textSplit = pisac.Split(" ");
            string ime = textSplit[0];
            string prezime = textSplit[1];
            //Pisac = await bukself.Pisci.FindAsync(ime, prezime);
            Pisac = bukself.Pisci.Where(p => p.PIme == ime).Where(d => d.PPrezime == prezime).FirstOrDefault(); 
            Pisci = await bukself.Pisci.ToListAsync();
        }

        public FileResult OnGetImage(string path)
        {
            var bytes = System.IO.File.ReadAllBytes(path);
            return File(bytes, "images/png");
        }

    }
}
