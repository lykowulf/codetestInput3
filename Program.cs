using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace codetestInput3
{
    class Program
    {
        static void Main(string[] args)
        {
            //user input (Prices)
            Console.WriteLine("How much is the imported perfume?");
            string importedPerfumeInit = Console.ReadLine();
            decimal importedPerfume = IsNumOnly(importedPerfumeInit) ? decimal.Parse(importedPerfumeInit) : 0; //if statement true statement false statement. 

            Console.WriteLine("How much is the perfume?");
            string perfumeInit = Console.ReadLine();
            decimal perfumePrice = IsNumOnly(perfumeInit) ? decimal.Parse(perfumeInit) : 0;

            Console.WriteLine("How much for the pills?");
            string pillsInit = Console.ReadLine();
            decimal pillsPrice = IsNumOnly(pillsInit) ? decimal.Parse(pillsInit) : 0;

            Console.WriteLine("How much is the first box of imported chocolates?");
            string importedChocolatesInit = Console.ReadLine();
            decimal importedChocolatePrice = IsNumOnly(importedChocolatesInit) ? decimal.Parse(importedChocolatesInit) : 0;

            Console.WriteLine("How much is the second box of imported chocolates?");
            string importedChocolatesInit2 = Console.ReadLine();
            decimal importedChocolatePrice2 = IsNumOnly(importedChocolatesInit2) ? decimal.Parse(importedChocolatesInit2) : 0;

            //imported and sales taxs entered by user
            Console.WriteLine("Enter in 0.10% for sales tax.");
            string basicSalesTaxInit = Console.ReadLine();
            decimal salesTaxAmount = IsNumOnly(basicSalesTaxInit) ? decimal.Parse(basicSalesTaxInit) : 0;

            Console.WriteLine("Enter in 0.05% for import tax.");
            string importTaxInit = Console.ReadLine();
            decimal importTaxAmount = IsNumOnly(importTaxInit) ? decimal.Parse(importTaxInit) : 0;
            decimal salesTaxTotal = 7.30m;





            
            //Calculations
            decimal chocAddedTogether = importedChocolatePrice + importedChocolatePrice2;
            decimal importedPerfumeTotal = Math.Round(importedPerfume * importTaxAmount + salesTaxAmount, 2) + importedPerfume;
            decimal perfumeTotal = Math.Round(perfumePrice * salesTaxAmount, 2) + perfumePrice;
            decimal importedChocolatesTotal = Math.Round(chocAddedTogether * importTaxAmount + salesTaxAmount, 2) + chocAddedTogether;
            decimal overAllTotal = (importedPerfume + perfumePrice + pillsPrice + chocAddedTogether + salesTaxTotal);






            //output
            Console.ReadLine();
            Console.WriteLine("Imported bottle of perfume:" + " " + importedPerfumeTotal);
            Console.WriteLine("Bottle of perfume:" + " " + perfumeTotal);
            Console.WriteLine("Packet of headache pills:" + " " + pillsPrice);
            Console.WriteLine("Imported box of chocolates:" + " " + importedChocolatesTotal + " " + "(2 @ 11.85)");
            Console.WriteLine("Sales Taxes:" + " " + salesTaxTotal);
            Console.WriteLine("Total:" + " " + overAllTotal);
            Console.ReadLine();


           
        }

        static bool IsNumOnly(string userInput)
        {
            //checks to see if there is any spaces entered in by the user.
            if (string.IsNullOrEmpty(userInput))
            {
                return false;
            }

            //checks to see if numbers entered by user matches if so returns results if not returns false. 
            Regex r = new Regex(@"^-{0,1}\d+\.{0,1}\d*$"); 
            Match m = r.Match(userInput);
            if (m.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
