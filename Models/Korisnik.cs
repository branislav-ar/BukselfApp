using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProjekatSWE.Models
{
    [Table("Korisnik")]
    public class Korisnik
    {
        [Key]
        [Column("Username")]
        public string Username { get; set;}
        
        [Column("Ime")]
        public string Ime { get; set; }

        [Column("Prezime")]
        public string Prezime { get; set;}

        [Column("Pw")]
        public string Pw { get; set;}
        
        [Column("Email")]
        public string Email{ get;set;}

        [Column("Adresa")]
        public string Adresa {get;set;}

        [Column("Drzava")]
        public string Drzava {get;set;}

        [Column("Datum")]
        public string Datum {get;set;}

        [Column("Pol")]
        public string Pol {get;set;}

        [Column("BrR")]
        public int BrR {get;set;}

        [Column("POpis")]
        public string POpis {get;set;}

        [Column("KPhotoPath")]
        public string KPhotoPath {get;set;} 
    }
}