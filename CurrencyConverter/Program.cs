using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace CurrencyConverter
{
    public class MainActions
    {   
        public static readonly Dictionary<string, double> CurrencyRate = new Dictionary<string, double> 
            {{"USD", 1}, {"GBP", 0.71}, {"EUR", 0.84}, {"UAH", 27.85}, {"RUB", 76.34}};
        
        public static void Main(string[] args)
        {
            var converter = new Converter();

            while (true)
            {
                converter.ChooseCurrency();
            }
        }
    }
}