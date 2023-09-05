using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            ContCurent cont1 = new ContEconomii("Robert",20,1000,"Cont Economii",20-08-2023,"Descriere",0.03M);
            ContCurent cont2 = new ContInvestitii("Andrei", 50, 1000, "Cont Investitii", 20-08-2023,0.03M,"Alta Descriere");

            Console.WriteLine(cont1.Descriere);
            Console.WriteLine(cont2.Descriere);

            cont1.ExtragereNumerar(200);
            cont2.ExtragereNumerar(200);

            cont1.DepundeBani(3000);
            cont2.DepundeBani(4000);


        }
    }
}