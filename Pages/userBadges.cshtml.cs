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
    public class UserBadgesModel : PageModel
    {
        private BukSelfContext bukself;
        
        [BindProperty]
        public Korisnik Korisnik { get; set;}
        [BindProperty]
        public Korisnik Vlasnik { get; set;}

        public UserBadgesModel (BukSelfContext context)
        {
            bukself = context;
        }
        public async Task OnGet(string username,string user)
        {
            Korisnik = await bukself.Korisnici.FindAsync(username);
            Vlasnik = await bukself.Korisnici.FindAsync(user);
        }
    }
}