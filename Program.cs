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
<<<<<<< HEAD
            int bannana = 1;
            int nikoline = 1;
            string caramel = "Caramel";
            string chocola = "Chocola";


            Console.WriteLine("antal banana", bannana, "antal nikoline", nikoline, caramel, chocola);
=======
            Donut nyDonut = new Donut("Kakao Donut", 12, 100);
        }
    }
    class Donut
    {
        public string DonutType { get; set; }
        public int DonutPrice { get; set; }
        public int DonutAmount { get; set; }

        public Donut(string DonutType, int DonutPrice, int DonutAmount)
        {
            this.DonutType = DonutType;
            this.DonutPrice = DonutPrice;
            this.DonutAmount = DonutAmount;
>>>>>>> 435e21de9d6c98c79fe5f98dce8759c6ebd84d56
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
