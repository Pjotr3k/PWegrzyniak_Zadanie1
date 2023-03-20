using PWęgrzyniak_Zadanie1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWęgrzyniak_Zadanie1.Data
{
    internal class Seed
    {
        private readonly AppDbContext _context;

        public Seed(AppDbContext cxt)
        {
            this._context = cxt;
        }

        public void ExecuteSeed()
        {
            if(_context != null)
            {
                var produkts = new List<Produkt>()
                {
                    new Produkt()
                    {
                        Nazwa = "Stół"
                    },

                    new Produkt()
                    {
                        Nazwa = "Półka"
                    },

                    new Produkt()
                    {
                        Nazwa = "Łóżko"
                    },

                    new Produkt()
                    {
                        Nazwa = "Szafa"
                    },

                    new Produkt()
                    {
                        Nazwa = "Ława"
                    },

                    new Produkt()
                    {
                        Nazwa = "Krzesło"
                    }
                };

                var narzedzias = new List<Narzedzie>()
                {
                    new Narzedzie()
                    {
                        Nazwa = "Hebel"
                    },

                    new Narzedzie()
                    {
                        Nazwa = "Młotek"
                    },

                    new Narzedzie()
                    {
                        Nazwa = "Grawer"
                    },

                    new Narzedzie()
                    {
                        Nazwa = "Szmatka"
                    },

                    new Narzedzie()
                    {
                        Nazwa = "Szlifierka"
                    }
                };

                _context.AddRange(produkts);
                _context.AddRange(narzedzias);

                _context.SaveChanges();

                produkts = _context.Produkts.ToList();
                narzedzias = _context.Narzedzias.ToList();

                var ProduktZmianas = new List<ProduktZmiana>()
                {
                    new ProduktZmiana()
                    {
                        ProduktId = produkts[7].Id,
                        DataWprowadzenie = new DateTime (2012, 3, 31),
                        OpisZmiana = "Blabla"
                    },

                    new ProduktZmiana()
                    {
                        ProduktId = produkts[7].Id,
                        DataWprowadzenie = new DateTime (2041, 5, 22),
                        OpisZmiana = "Blabla"
                    },

                    new ProduktZmiana()
                    {
                        ProduktId = produkts[5].Id,
                        DataWprowadzenie = new DateTime (2011, 11, 16),
                        OpisZmiana = "Blabla"
                    },

                    new ProduktZmiana()
                    {
                        ProduktId = produkts[5].Id,
                        DataWprowadzenie = new DateTime (2022, 4, 25),
                        OpisZmiana = "Blabla"
                    },

                    new ProduktZmiana()
                    {
                        ProduktId = produkts[0].Id,
                        DataWprowadzenie = new DateTime (2000, 9, 7),
                        OpisZmiana = "Blabla"
                    },

                    new ProduktZmiana()
                    {
                        ProduktId = produkts[7].Id,
                        DataWprowadzenie = new DateTime (2012, 7, 5),
                        OpisZmiana = "Blabla"
                    },

                    new ProduktZmiana()
                    {
                        ProduktId = produkts[5].Id,
                        DataWprowadzenie = new DateTime (2013, 12, 25),
                        OpisZmiana = "Blabla"
                    },

                    new ProduktZmiana()
                    {
                        ProduktId = produkts[5].Id,
                        DataWprowadzenie = new DateTime (2001, 3, 30),
                        OpisZmiana = "Blabla"
                    },

                    new ProduktZmiana()
                    {
                        ProduktId = produkts[0].Id,
                        DataWprowadzenie = new DateTime (2009, 6, 5),
                        OpisZmiana = "Blabla"
                    },

                    new ProduktZmiana()
                    {
                        ProduktId = produkts[3].Id ,
                        DataWprowadzenie = new DateTime (2012, 8, 3),
                        OpisZmiana = "Blabla"
                    }
                };
            }
        }

    }
}
