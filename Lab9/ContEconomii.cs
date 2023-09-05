using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class ContEconomii : ContCurent
    {
        public decimal RataDobanda { get; set; }
        public ContEconomii(string name, decimal suma, decimal sold, string tip, int ziuaTermenului, string descriere,decimal rataDobanda) : base(name, suma, sold, tip,  descriere)
        {
            RataDobanda = rataDobanda;
            descriere += $",Rata Dobanda :{RataDobanda:P}";
        }

        

        public void ActualizeazaDobanda(decimal sold )
        {
            decimal ValoareSold = sold*(1+ RataDobanda);
            sold += ValoareSold;
            Console.WriteLine($"Dobanda de {ValoareSold} RON a fost adaugata. Sold curent: {sold} RON");

        }

        
    }
}
