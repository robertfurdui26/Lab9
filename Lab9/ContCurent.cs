using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class ContCurent
    {
        public Guid Id { get; } = Guid.NewGuid();
        private string Nume { get; set; }

        private decimal Suma = 0;

        public  decimal Sold { get; protected set; }

        private string Tip {  get; set; }



        public string Descriere { get; protected set; }



        public ContCurent(string name,decimal suma, decimal sold,string tip,string descriere)
        {
            this.Nume = name;
            this.Suma = suma;
            this.Sold = sold;
            this.Tip = tip;
            this.Descriere = $"Cont{tip} (Id):{Id}, Titular:{name} ,Sold curent:{sold:C} ";

        }

        public void ExtragereNumerar(decimal suma)
        {
            decimal maxValue = 5000;

            if(suma > Sold + maxValue)
            {
                Console.WriteLine($"Suma retrasa depaseste soldul de {Sold}! si plafonul de {maxValue}");
            }else if(suma < Sold + maxValue)
            {
                Sold -= suma;
                Console.WriteLine($"Suma de {suma} RON a fost retrasa. Sold curent: {Sold} RON");

            }


        }

        public void DepundeBani(decimal newSold)
        {
            decimal result = newSold + Sold;
            Console.WriteLine($"Sold crescut: {result}");
        }
    }
}
