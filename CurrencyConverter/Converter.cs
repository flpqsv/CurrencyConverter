using System;
using System.Collections.Generic;

namespace CurrencyConverter
{
    public class Converter
        {
            public void ChooseCurrency()
            {
                while (true)
                {
                    var currencyClass = new Currency();

                    Console.WriteLine("Hello! Please choose your currency: ");
                    var userCurrency = Console.ReadLine();

                    if (!currencyClass.ValidateCurrency(ref userCurrency))
                    {
                        return;
                    }

                    Console.WriteLine("Please choose the second currency: ");
                    var secondCurrency = Console.ReadLine();

                    if (!currencyClass.ValidateCurrency(ref secondCurrency))
                    {
                        return;
                    }

                    if (userCurrency.ToUpper() == secondCurrency.ToUpper())
                    {
                        Console.WriteLine("Please indicate different currencies.");
                    }

                    Console.WriteLine("Thank you. Please indicate the sum you'd like to convert: ");
                    var sum = Console.ReadLine();

                    if (!double.TryParse(sum, out double firstCurrency))
                    {
                        Console.WriteLine("Error: you can enter only numbers in this field.");
                        break;
                    }
                    else if (double.Parse(sum) <= 0)
                    {
                        Console.WriteLine($"Error: the sum cannot be under 0.");
                        break;
                    }

                    double result = Convert(ref userCurrency, ref firstCurrency, ref secondCurrency);
                    Console.WriteLine($"Your sum in {secondCurrency.ToUpper()} is {result}.");
                }
            }

            public static double Convert(ref string userCurrency, ref double firstCurrency, ref string secondCurrency)
            {
                double first = 0;
                foreach (KeyValuePair<string, double> x in MainActions.CurrencyRate)
                {
                    if (userCurrency.ToUpper() == x.Key)
                    {
                        first = x.Value;
                    }
                }

                double second = 0;
                foreach (KeyValuePair<string, double> x in MainActions.CurrencyRate)
                {
                    if (secondCurrency.ToUpper() == x.Key)
                    {
                        second = x.Value;
                    }
                }

                double result = firstCurrency / first * second;

                return result;
            }
        }
}
