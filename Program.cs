using System;
namespace Test
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("birinci ədədi daxil edin");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci ədədi daxil edin");
            int number2 = Convert.ToInt32(Console.ReadLine());
            İnitial: Console.WriteLine("əməliyyatın növünü daxil edin");
            string typeOfOperation = Console.ReadLine();
            int cəm = Convert.ToInt32(number1 + number2);
            int fərq = Convert.ToInt32(number1 - number2);
            int hasil = Convert.ToInt32(number1 * number2);
            int nisbət = Convert.ToInt32(number1 / number2);
            switch (typeOfOperation)
            {
                case "*":
                    Console.WriteLine(hasil);
                    break;
                case "/":
                    Console.WriteLine(nisbət);
                    break;
                case "+":
                    Console.WriteLine(cəm);
                    break;
                case "-":
                    Console.WriteLine(fərq);
                    break;
                default:
                    Console.WriteLine("try again");
                    goto İnitial;
                    break;   
            }
        }
    }
}
