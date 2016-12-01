using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Think.Cli
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static int doubleDigitValue(int digit)
        {

            int doubleDigit = digit * 2;
            int sum;

            if (doubleDigit >= 10)
                sum = 1 + doubleDigit % 10;
            else
                sum = doubleDigit;

            return sum;
        }

        static void ValidateNumber()
        {
            int digit;
            int checksum = 0;
            int oddLengthChecksum = 0;
            int evenLengthChecksum = 0;
            ConsoleKeyInfo cki;
            int position = 1;

            Console.Write("Enter a number ");
            do
            {
                cki = (Console.ReadKey());
                int.TryParse(cki.KeyChar.ToString(), out digit);
                if (position % 2 == 0)
                {
                    oddLengthChecksum += doubleDigitValue(digit);
                    evenLengthChecksum += digit;
                }
                else
                {
                    oddLengthChecksum += digit;
                    evenLengthChecksum += doubleDigitValue(digit);
                }
                position++;
            }
            while (cki.Key != ConsoleKey.Enter);

            if ((position - 1) % 2 == 0)
                checksum = oddLengthChecksum;
            else
                checksum = evenLengthChecksum;

            Console.WriteLine("\nChecksum is {0}", checksum);
            if (checksum % 10 == 0)
                Console.WriteLine("Checksum is divisible by 10.  Valid.");
            else
                Console.WriteLine("Checksum is not divisible by 10.  Invalid.");
        }
    }

}
