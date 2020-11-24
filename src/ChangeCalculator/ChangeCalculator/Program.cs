using System;

namespace ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                DisplayUsage();

                return;
            }

            var amountDueArg = args[0];
            var amountGivenArg = args[1];

            decimal amountDue;
            decimal amountGiven;

            if ( decimal.TryParse(amountDueArg, out amountDue) 
                 && decimal.TryParse(amountGivenArg, out amountGiven))
            {
                if (amountGiven > amountDue)
                {
                    var calculator = Calculator.Calculator.Create();
                    var change = calculator.Calculate(amountDue, amountGiven);

                    Console.WriteLine(@"Your change is:");
                    foreach (var money in change)
                    {
                        Console.WriteLine(money.ToString());
                    }

                }
                else
                {
                    Console.WriteLine(@"Amount given is less than the amount due");
                    DisplayUsage();
                }
            }
            else
            {
                Console.WriteLine(@"Amounts are not numeric.");
                DisplayUsage();
            }
        }

        private static void DisplayUsage()
        {
            Console.WriteLine(@"Usage: 'ChangeCalculator <amount due> <amount given>' ");
            Console.WriteLine(@"Both amounts in GBP.");
            Console.WriteLine(@"e.g. ChangeCalculator 5.50 20.00");
        }
    }
}
