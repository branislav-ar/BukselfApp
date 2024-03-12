using Microsoft.EntityFrameworkCore;

namespace ProjekatSWE.Models
{
    
    public class BukSelfContext: DbContext
    {
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Knjiga> Knjige { get; set; }
        public DbSet<Recenzija> Recenzije {get;set;}
        public DbSet<Favourite> OmiljeneKnjige {get;set;}
        public DbSet<FavUser> OmiljeniKorisnici {get;set;}
        public DbSet<Pisac> Pisci {get;set;}
        public BukSelfContext(DbContextOptions options) : base(options)
        {
        }
    }
}