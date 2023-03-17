using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace PWęgrzyniak_Zadanie1.Models
{
    internal class Produkt
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }

        public ICollection<ProduktZmiana>? ProduktZmianas { get; set; }
    }
}
