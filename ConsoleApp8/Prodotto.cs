using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Prodotto
    {
        public int Codice { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }

        public Prodotto(int codice, string descrizione, double prezzo, Prodotto prodotti)
        {
            Codice = codice;
            Descrizione = descrizione;
            Prezzo = prezzo;
        }
    }
    
}
