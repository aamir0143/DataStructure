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
            list.Add(30);
            list.Add(40);
            list.Add(70);
            int position = list.Search(40);
            list.DeleteNodeAtParticularPosition(position);
            Console.WriteLine("\nAfter deleting 40 then Size and final sequence is: ");
            list.Size();
            list.Display();
            Console.WriteLine("========================================================================================");
            Console.ReadLine();
        }
    }
}
