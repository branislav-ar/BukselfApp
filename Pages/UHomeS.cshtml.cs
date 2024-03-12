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
    public class UHomeSModel : PageModel
    {
        public List<Knjiga> Knjige {get;set;}
        private BukSelfContext bukself;
        public Korisnik Korisnik { get; set;}
        public Knjiga Knjiga { get; set;}
        public string zanrr;

        [BindProperty]
        public string searchIme {get; set;}
        [BindProperty]
        public string searchPisac {get; set;}

        public UHomeSModel (BukSelfContext context)
        {
            bukself = context;
        }

        public async Task OnGet(string zanr)
        { 
            zanrr = zanr;
            Knjige = await bukself.Knjige.ToListAsync();  
        }

        public async Task OnPost(string searchIme, string searchPisac, string zanr)
        {
            zanrr = zanr;
            if(string.IsNullOrEmpty(searchIme))
            {
                if(string.IsNullOrEmpty(searchPisac))
                {
                    Knjige = await bukself.Knjige.ToListAsync();
                }
                else
                {
                    Knjige = await bukself.Knjige.Where(e => e.Pisac.Contains(searchPisac)).ToListAsync();
                }
            }
            else
            {
                if(string.IsNullOrEmpty(searchPisac))
                {
                    Knjige = await bukself.Knjige.Where(e => e.Ime.Contains(searchIme)).ToListAsync();
                }
                else
                {
                    Knjige = await bukself.Knjige.Where(e => e.Ime.Contains(searchIme)).ToListAsync();
                    Knjige = await bukself.Knjige.Where(e => e.Pisac.Contains(searchPisac)).ToListAsync();
                }
                
            }
        }
    }
}
