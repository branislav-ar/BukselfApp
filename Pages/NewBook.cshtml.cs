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
    public class NewBookModel : PageModel
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        [BindProperty]
        public Knjiga Knjiga {get;set;}
        
        [BindProperty]
        public IFormFile Photo {get;set;}

        public List<Knjiga> Knjige {get;set;}
        public Korisnik Korisnik {get;set;}

        private BukSelfContext bukself;

        public NewBookModel (BukSelfContext context,IWebHostEnvironment webHostEnvironment)
        {
            bukself = context;
            this.webHostEnvironment = webHostEnvironment;
        }
        public async Task OnGet(string username)
        {
            Korisnik = await bukself.Korisnici.FindAsync(username);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            if(Photo != null)
            {
                if (Knjiga.BPhotoPath != null)
                {
                    string filePath = Path.Combine(webHostEnvironment.WebRootPath,
                        "images", Knjiga.BPhotoPath);
                    System.IO.File.Delete(filePath);
                }
                Knjiga.BPhotoPath = ProcessUploadedFile();
            }

            bukself.Knjige.Add(Knjiga);
            await bukself.SaveChangesAsync();

            return RedirectToPage("NewBook", new { username = "admin"});
        }

        private string ProcessUploadedFile()
        {
            string uniqueFileName = null;

            if (Photo != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/knjiga/");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
            }

            return "/images/knjiga/"+uniqueFileName;
        }
    }
}
