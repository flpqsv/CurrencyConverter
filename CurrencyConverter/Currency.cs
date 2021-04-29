using System;
using System.Linq;

namespace CurrencyConverter
{
    public class Currency
    {
        public bool ValidateCurrency(ref string currency)
        {
            while (!DoesCurrencyExist(currency))
            {
                Console.WriteLine("Do you want to try again? Yes/No");

                if (Console.ReadLine()?.ToLower() == "yes")
                {
                    Console.WriteLine("Please enter your currency again: ");
                    currency = Console.ReadLine();
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public bool DoesCurrencyExist(string currency)
        {
            var currencyConverter = new MainActions();

            var result = MainActions.CurrencyRate.Keys.Any(key => key.Equals(currency.ToUpper()));

            if (!result)
            {
                Console.WriteLine($"Unfortunately, we do not support currency '{currency}'.");
            }

            return result;
        }
    }
}