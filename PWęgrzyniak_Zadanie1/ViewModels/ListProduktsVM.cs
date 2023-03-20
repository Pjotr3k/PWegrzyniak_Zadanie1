using Microsoft.EntityFrameworkCore;
using PWęgrzyniak_Zadanie1.Data;
using PWęgrzyniak_Zadanie1.Models;
using System.Collections.Generic;
using System.Linq;


namespace PWęgrzyniakZadanie1.ViewModels
{
    class ListProduktsVM
    {
        private readonly AppDbContext _context;

        private List<Produkt> Produkts { get; set; }
        public List<ProduktInListVM> Pils { get; set; }

        public ListProduktsVM()
        {
            _context = new AppDbContext();
            Produkts = _context.Produkts
                .Include(p => p.ProduktZmianas).ToList();
            Pils = PopulatePils(Produkts);
            
        }
        
        private List<ProduktInListVM> PopulatePils(List<Produkt> prods) 
        {
            List<ProduktInListVM> pils = new List<ProduktInListVM>();

            foreach (var p in prods)
            {
                
                ProduktInListVM pil = new ProduktInListVM();

                pil.Id = p.Id;
                pil.Nazwa = p.Nazwa;

                if (p.ProduktZmianas != null)
                {
                    pil.IleZmian = p.ProduktZmianas.Count();
                    if (pil.IleZmian > 0)
                    {
                        pil.OstatniaZmiana = p.ProduktZmianas.Max(t => t.DataWprowadzenie);
                    }
                }
                else
                {
                    pil.IleZmian = 0;
                    pil.OstatniaZmiana = null;
                }
                
                pils.Add(pil);
            }

            return pils;
        }

    }
}
