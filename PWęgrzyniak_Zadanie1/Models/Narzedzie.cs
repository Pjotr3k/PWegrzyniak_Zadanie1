using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PWęgrzyniak_Zadanie1.Models
{
    internal class Narzedzie
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }

        public ICollection<NarzedzieUzycie>? NarzedzieUzycies { get; set; }
    }
}
