using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snacks
{
    class Program
    {
        static void Main()
        {
            int bannana = 1;
            int nikoline = 1;
            string caramel = "Caramel";
            string chocola = "Chocola";


            Console.WriteLine("antal banana", bannana, "antal nikoline", nikoline, caramel, chocola);
        }
    }

    class Kage 
    {
        enum KageTyper
        {
            Chokoladekage,
            Nutellakage,
            Æblekage,
            Drømme,
            Gullerrodskage,
            Sandkage,
            Dessertkage,
            Hindbærkage,
            Banankage,
            Jordbærkage
        }

        public int Kg { get; set; }
        public int MyProperty { get; set; }
    }
}
