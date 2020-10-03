using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace practica21
{
    class Program
    {
        public object alfabeto { get; private set; }

        static void Main(string[] args)
        {

            // declare and initialize variables
            string input = "";
            string message = "";
            string theAlpha = "";
            string checksum = "";
            Console.WriteLine(" What is your message? ");
            input = Console.ReadLine().ToUpper();
            Program p = new Program();


            foreach (char item in input)
            {
                Console.WriteLine(p.DeLetraAOrdinal(item));
                checksum += p.DeLetraAOrdinal(item);
            }
            Console.WriteLine($"The checksum is{checksum}");

            Console.ReadKey();
        }

        int DeLetraAOrdinal(char letra)
        {
            return (char.ToUpper(letra) - 'A') + 1;
        }


        //string checksum = "";
        //private static char[] recorData;

        //calculates the checksum from the byte[]
    
        

    }
}
