using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace PWęgrzyniak_Zadanie1.Models
{
    internal class NarzedzieUzycie
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Narzedzie")]
        public int NarzedzieId { get; set; }
        public Narzedzie Narzedzie { get; set; }
        [ForeignKey("ProduktZmiana")]
        public int ZmianaId { get; set; }
        public ProduktZmiana? Zmiana { get; set; }
    }
}
