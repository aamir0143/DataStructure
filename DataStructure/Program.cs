// See https://aka.ms/new-console-template for more information
using System;

namespace DataStructure 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Data Structure Programs==========");

            Console.WriteLine("SEARCH OPERATIONS !");
            LinkedList list = new LinkedList();
            list.Appending(56); 
            list.Appending(30);
            list.Appending(70);
            Console.WriteLine("Display Nodes are");
            list.Display();
            Console.WriteLine("========================================================================================");
            Console.ReadLine();
        }
    }
}
