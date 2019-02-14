using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snacks
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Icecream
    {
        public string Type { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }

        public Icecream(string Type, int Price, int Amount)
        {
            this.Type = Type;
            this.Price = Price;
            this.Amount = Amount;
        }
    }
}
