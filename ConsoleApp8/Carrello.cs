using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Carrello {
        private Dictionary<Prodotto, int> prodotti;

        public Carrello() {
            prodotti= new Dictionary<Prodotto, int>();
    }
        public void AggiungiProdotto(Prodotto prodotto, int quantita)
        {
            if (prodotti.ContainsKey(prodotto))
            {
                int existingQuantity = prodotti[prodotto];
                prodotti[prodotto] = existingQuantity + quantita;
            }
            else
            {
                prodotti.Add(prodotto, quantita);
            }
        }
        public void RimuoviProdotto(Prodotto prodotto)
        {
            prodotti.Remove(prodotto);
        }
        public void AggiornaQuantita(Prodotto prodotto, int Quantita)
        {
            if (prodotti.ContainsKey(prodotto))
            {
                prodotti[prodotto] = Quantita;
            }
        }
        

    }
}
