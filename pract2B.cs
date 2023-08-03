using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract2BB
{
    internal class Program
    {
        //public int r, e, d,v;
        public Program()
        {
            //r = 0;
           ///e = 0;
           // d = 0;
            //v = 0;
        }
        public int convertdtor(int d)
        {
           int v = d * 78;
           return v;
        }
        public int convertrtod(int r)
        {
            int v = r / 78;
            return v;
        }
        public int convertetor(int e)
        {
            int v = e * 80;
            return v;
        }
        public int convertrtoe(int r)
        {
            int v = r / 80;
            return v;
        }

        static void Main(string[] args)
        {
            Program n = new Program();

            while (true)
            {
                
           
            Console.WriteLine("choose Option");
            Console.WriteLine("1.D 2 R");
            Console.WriteLine("2.R 2 D");
            Console.WriteLine("3.E 2 R");
            Console.WriteLine("4.R 2 E");

            int cho = int.Parse(Console.ReadLine());
            Console.WriteLine(cho);

                Console.WriteLine("Enter Amount : ");

                int val = int.Parse(Console.ReadLine());
                
                if (cho == 1)
                {
                    Console.WriteLine("U choosed Dollar 2 Rupeee");
                    Console.WriteLine(n.convertdtor(val));
                }
                else if (cho == 2)
                {
                    Console.WriteLine("U choosed Dollar 2 Rupeee");
                    Console.WriteLine(n.convertrtod(val));
                }
                else if (cho == 3)
                {
                    Console.WriteLine("U choosed E2R");
                    Console.WriteLine(n.convertetor(val));
                }
                else if (cho == 4)
                {
                    Console.WriteLine("U choosed Rupee to Euro");
                    Console.WriteLine(n.convertrtoe(val));
                }
                else
                {
                    Console.WriteLine("Invalid Option");

                }

                Console.WriteLine("_ _ _ _ _ _ _ _ _ _ __ _ _ _ _ __ _ _ _ _");

            }

            int cho2 = int.Parse(Console.ReadLine());


        }
    }
}
