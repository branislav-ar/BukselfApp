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
    public class UserFavBookModel : PageModel
    {
        private BukSelfContext bukself;

        [BindProperty] 
        public Knjiga Knjiga { get; set;}
        
        [BindProperty]
        public Korisnik Korisnik { get; set;}
        [BindProperty]
        public Korisnik Vlasnik { get; set;}
        [BindProperty]
        public  Favourite Omiljenjaknjiga { get; set;}
        public List<Knjiga> Knjige {get;set;}
        public List<Favourite> OmiljeneKnjige {get;set;}
        public UserFavBookModel (BukSelfContext context)
        {
            bukself = context;
        }
        public async Task OnGet(string username,string user)
        {
            Korisnik = await bukself.Korisnici.FindAsync(username);
            Vlasnik = await bukself.Korisnici.FindAsync(user);
            Knjige = await bukself.Knjige.ToListAsync();
            OmiljeneKnjige = await bukself.OmiljeneKnjige.Where(e => e.Uname.Contains(user)).ToListAsync();
        }      
    }
}
