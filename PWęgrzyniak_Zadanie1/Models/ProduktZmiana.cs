using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace PWęgrzyniak_Zadanie1.Models
{
    internal class ProduktZmiana
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Produkt")]
        public int ProduktId { get; set; }
        public Produkt Produkt { get; set; }
        public DateTime DataWprowadzenie { get; set; }
        public string? OpisZmiana { get; set; }

        public ICollection<NarzedzieUzycie>? NarzedzieUzycies { get; set; }
    }
}
