using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjekatSWE.Models
{
    [Table("Recenzija")]
    public class Recenzija
    {
        [Key]
        [Column("IDR")]
        public int IDR {get;set;}

        [Column("Uname")]
        public string Uname {get;set;}

        [Column("IDK")]
        public int IDK {get;set;}

        [Column("Komentar")]
        public string Komentar {get;set;}

        [Column("Ocena")]
        public int Ocena {get;set;}
        
        [Column("Datum")]
        public string Datum {get;set;}
    }
}