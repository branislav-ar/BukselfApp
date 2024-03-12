using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProjekatSWE.Models
{
    [Table("Pisac")]
    public class Pisac
    {
        [Key]
        [Column("PID")]
        public int PID { get; set; }

        [Column("PIme")]
        public string PIme { get; set; }

        [Column("PPrezime")]
        public string PPrezime { get; set;}

        [Column("PDatum")]
        public string PDatum {get;set;}

        [Column("BrK")]
        public int BrK {get;set;}

        [Column("POpis")]
        public string POpis {get;set;} 

        [Column("PPhotoPath")]
        public string PPhotoPath {get;set;} 
    }
}