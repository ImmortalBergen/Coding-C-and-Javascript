using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.IO.Ports;
using System.Collections;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"C:\Users\Maxenbergen\Desktop\ts\programm\code\i\cracker.py";
            string[] test = {"3"};
            while (true)
            {
                Console.WriteLine("Starting or reapiting");
                string text = System.IO.File.ReadAllText(@"C:\Users\Maxenbergen\Desktop\Websocket coding\Commands.txt");
                int number = Int32.Parse(text);
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
                Thread.Sleep(10000);
            }
        }
    }
}
