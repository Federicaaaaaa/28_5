using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _28_5
{
    internal class Carrello
    {
        public Cliente cliente { get; set; }
        public List<Prodotto> Prodotti { get; set; }

        public void AddProdotto(Prodotto p)
        {
            int s = 0;
            foreach (Prodotto prodotto in Prodotti)
            {
                if(p == prodotto)
                {
                    s = 1;
                    break;
                }
            }
            if (s == 0)
            {
                this.Prodotti.Add(p);
            }
            else
            {
                p.Quantità++;
            }
        }

        public void RemoveProdotto(Prodotto p)
        {
            this.Prodotti.Remove(p);
        }

        public double Totale()
        {
            double tot = 0;
            foreach(Prodotto p in Prodotti)
            {
                p.Prezzo = p.Prezzo * p.Sconto / 100;
                tot += p.Prezzo;
            }
            return tot;
        }
    }
}
