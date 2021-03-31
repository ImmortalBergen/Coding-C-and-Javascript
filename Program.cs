using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.IO.Ports;
using System.Collections;

namespace Main
{
    class Program
    {
        public static int reader()
        {
            string text = File.ReadAllText(@"C:\Users\Maxenbergen\Desktop\Websocket coding\Commands.txt");
            int number = Int32.Parse(text);
            return number;
        }
        
        static void comperator(int number, string[] test)
        {
            if (number == 1)
            {
                Console.WriteLine("Das Licht wird eingeschalten");



            }
            if (number == 0)
            {
                Console.WriteLine("Das Licht wird ausgeschalten");

            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
            System.IO.File.WriteAllLines(@"C:\Users\Maxenbergen\Desktop\Websocket coding\Commands.txt", test);
            Thread.Sleep(100);


        }

        static void Main(string[] args)
        {
            string[] test = { "3" };
            int number = Program.reader();
            while (true)
            {
                Program.comperator(number, test);
            }

        }
    }
}
