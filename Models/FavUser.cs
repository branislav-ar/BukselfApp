using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProjekatSWE.Models
{
    [Table("FavUser")]
    public class FavUser
    {
        [Key]
        [Column("IDFU")]
        public int IDFU {get;set;}

        [Column("Username1")]
        public string Uname1 {get;set;}

        [Column("Username2")]
        public string Uname2 {get;set;}
    }
}