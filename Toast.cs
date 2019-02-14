using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snacks
{
    class Toast
    {
        string Toasttype { get; set; }
        double Karakter { get; set; }
        int Stemmer { get; set; }

        public Toast(string type, int stemmer, double karakter)
        {
            Toasttype = type;
            Karakter = karakter;
            Stemmer = stemmer;
        }

        public static void Toastmaskine()
        {
            Console.WriteLine("Vil du putte brød i Toaster");
            Console.WriteLine("y/n");
            string input = Console.ReadLine();

            if (input == "y" || input == "Y")
            {

            }
            else if (input == "n" || input == "N")
            {

            }
        }
        
    }
}
