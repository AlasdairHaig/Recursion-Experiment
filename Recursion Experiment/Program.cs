using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recursion_Experiment
{
    class Program
    {


        static void Main(string[] args)
        {

            downcounter(10);
            downcounter2(10);
            upcounter(0, 10);
            upcounter2(10);
            Console.ReadLine();
        }

        //Geht von 10 bis 0
        static public int downcounter(int n)
        {
            Console.WriteLine(n);

            if (n > 0)
            {
                return n + downcounter(n - 1);      //Addition ist benutzt
            }
            else
            {
                return n;            
            }

        }

        //Geht von 10 bis 0
        static public int downcounter2(int n)
        {

            Console.WriteLine(n);
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * downcounter2(n - 1);     //Multiplikation ist benutzt
            }
       }

        //Geht von 0 bis 10
        static public int upcounter(int n, int end)     //Benutzt 2 parameters
        {

            Console.WriteLine(n);
            if (end == n)
            {
                return 1;
            }
            else
            {
                return n + upcounter(n + 1, end);
            }
        }

        //Geht von 0 bis 10 oder 10 bis 0
        static public void upcounter2(int n)
        {

            //Console.WriteLine(n);       //Wenn man die Quellcode hier steckt, geht es von 10 bis 0
            if (n > 0)
            {
                upcounter2(n - 1);
            }
            Console.WriteLine(n);     //Wenn man die Quellcode hier steckt, geht es von 0 bis 10
        }

    }
}
