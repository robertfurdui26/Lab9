using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class ContInvestitii : ContEconomii
    {

        public int ZiuaTermenului { get; }
        public ContInvestitii(string name, decimal suma, decimal sold, string tip, int ziuaTermenului, decimal rataDobanda, string descriere) : base(name, suma, sold, tip, ziuaTermenului, descriere, rataDobanda)
        {
            this.ZiuaTermenului = ziuaTermenului;
            descriere += $",Ziua Termenului:{ziuaTermenului} ";
        }

        public void ExtrageBani(decimal suma)
        {
            int ziuaCurenta = DateTime.Now.Day;
            if (ziuaCurenta < ZiuaTermenului)
            {
                Console.WriteLine($"Nu puteti retrage banii pana la ziua termenului ({ZiuaTermenului}). ");

            }
            else
            {
                base.ExtragereNumerar(suma);
            }
        }
    }
}
