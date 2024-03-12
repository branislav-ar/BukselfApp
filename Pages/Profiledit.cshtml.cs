using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjekatSWE.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ProjekatSWE.Pages
{
    public class ProfileditModel : PageModel
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        
        [BindProperty]
        public Korisnik Korisnik { get; set;}

        [BindProperty]
        public IFormFile Photo {get;set;}

        private BukSelfContext bukself;
        public Recenzija Recenzija {get;set;}
        public List<Recenzija> Recenzije {get;set;}
        
        public ProfileditModel(BukSelfContext context, IWebHostEnvironment webHostEnvironment)
        {
            bukself = context;
            this.webHostEnvironment = webHostEnvironment;
        }
        
        public async Task OnGet(string username)
        {
            Korisnik = await bukself.Korisnici.FindAsync(username);
        }
        public async Task<IActionResult> OnPostAsync(string username)
        {
            if(!ModelState.IsValid)
            {
                Korisnik = await bukself.Korisnici.FindAsync(username);
                return Page();
            }
            if(Photo != null)
            {
                if (Korisnik.KPhotoPath != null)
                {
                    string filePath = Path.Combine(webHostEnvironment.WebRootPath,
                        "images", Korisnik.KPhotoPath);
                    System.IO.File.Delete(filePath);
                }
                Korisnik.KPhotoPath = ProcessUploadedFile();
            }
            Korisnik.Username = username;
            bukself.Korisnici.Update(Korisnik);
            await bukself.SaveChangesAsync();

            return RedirectToPage("./profil", new { username = Korisnik.Username });
        }

        private string ProcessUploadedFile()
        {
            string uniqueFileName = null;

            if (Photo != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/korisnik");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
            }

            return "/images/korisnik/"+uniqueFileName;
        }
    }
}
