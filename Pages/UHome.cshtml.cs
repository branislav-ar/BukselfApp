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
    public class UHomeModel : PageModel
    {
        public List<Knjiga> Knjige {get;set;}
        private BukSelfContext bukself;
        public List<Recenzija> Recenzije {get;set;}
        [BindProperty]
        public string searchIme {get; set;}
        [BindProperty]
        public string searchPisac {get; set;}

        public UHomeModel (BukSelfContext context)
        {
            bukself = context;
        }
        
        public async Task OnGet(string searchIme, string searchPisac)
        {
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