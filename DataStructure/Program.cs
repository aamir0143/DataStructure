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
            list.Add(56);
            //list.Add(30);
            list.Add(70);
            list.Display();
            list.InsertAtParticularPosition(2, 30);      
            Console.WriteLine("========================================================================================");
            Console.ReadLine();
        }
    }
}
