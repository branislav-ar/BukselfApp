using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ProjekatSWE.Models;

namespace ProjekatSWE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BukSelfController : ControllerBase
    {
        public BukSelfContext Context { get; set;}

        public BukSelfController(BukSelfContext context)
        {
            Context = context;
        }

        [Route("Preuzmi")]
        [HttpGet]
        public async Task<List<Knjiga>> Preuzmi ()
        {
            return await Context.Knjige.ToListAsync();
        }
        [Route("Upis")]
        [HttpPost]
        public async Task Upis([FromBody] Knjiga knjiga)
        {
            Context.Knjige.Add(knjiga); //postoji lokalno, ali ne i u bazi
            await Context.SaveChangesAsync();

        }

    }
}