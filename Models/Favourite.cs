using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProjekatSWE.Models
{
    [Table("Favourite")]
    public class Favourite
    {
        [Key]
        [Column("IDFB")]
        public int IDFB {get;set;}

        [Column("Username")]
        public string Uname {get;set;}

        [Column("IDK")]
        public int IDK {get;set;}
    }
}