using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProjekatSWE.Models
{
    [Table("Knjiga")]
    public class Knjiga
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Ime")]
        public string Ime { get; set;}
        
        [Column("Pisac")]
        public string Pisac { get; set; }
        
        [Column("Godina")]
        public string Godina { get; set;}

        [Column("Zanr")]
        public string Zanr {get;set;}

        [Column("KnjigaOpis")]
        public string KnjigaOpis {get;set;}

        [Column("BrR")]
        public int BrR { get; set; }

        [Column("Br1")]
        public int Br1 { get; set; }

        [Column("Br2")]
        public int Br2 { get; set; }

        [Column("Br3")]
        public int Br3 { get; set; }

        [Column("Br4")]
        public int Br4 { get; set; }

        [Column("Br5")]
        public int Br5 { get; set; }

        [Column("Prosek")]
        public float Prosek { get; set; }

        [Column("BPhotoPath")]
        public string BPhotoPath {get;set;}
    }
}