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
    public class UserModel : PageModel
    {
        [BindProperty]
        public Korisnik Korisnik {get;set;}
        [BindProperty]
        public Korisnik Vlasnik {get;set;}
        [BindProperty]
        public FavUser OmiljeniKorisnik {get;set;} 
        private BukSelfContext bukself;

         public List<FavUser> OmiljeniKorisnici {get;set;}

        public UserModel (BukSelfContext context)
        {
            bukself = context;
        }
        public async Task OnGet(string username,string user)
        {
            Korisnik = await bukself.Korisnici.FindAsync(username);
            Vlasnik = await bukself.Korisnici.FindAsync(user);
            OmiljeniKorisnici = await bukself.OmiljeniKorisnici.ToListAsync();
        }

        public IActionResult OnPostFollow(string vlasnik, string username,int temp)
        {
            if (temp== 1)
            {
            OmiljeniKorisnik.Uname1 = username;
            OmiljeniKorisnik.Uname2 = vlasnik;
            bukself.OmiljeniKorisnici.Add(OmiljeniKorisnik);
            bukself.SaveChanges();
            return RedirectToPage("./user", new { username = username,user = vlasnik});
            }
            else{
                var tempp = bukself.OmiljeniKorisnici.Where(p => p.Uname1 == username).Where(p => p.Uname2 == vlasnik).FirstOrDefault();
                bukself.OmiljeniKorisnici.Remove(tempp);
                bukself.SaveChanges();
            return RedirectToPage("./user", new { username = username,user = vlasnik});
            }
        } 


    }
}
