using System;
namespace reverseNumber
{


class Program
    {
        static void Main(string[] args)
        {
            int num, actualnumber, revnum = 0, digit, sumDigits = 0;
            Console.Write("Enter number:");
            num = int.Parse(Console.ReadLine());
            actualnumber = num;
            while (num > 0)
            {
                digit = num % 10;
                revnum = revnum * 10 + digit;
                sumDigits = sumDigits + digit;
                num = num / 10;
            }
            Console.WriteLine("Reverse of " + actualnumber + "=" + revnum);
            Console.WriteLine("Sum of its digits:" + sumDigits);

            Console.ReadLine();
        }
    }
}
