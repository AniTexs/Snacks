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
        }
    }
}
