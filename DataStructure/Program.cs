﻿// See https://aka.ms/new-console-template for more information
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
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);

            list.AddReverse(70);
            list.AddReverse(30);
            list.AddReverse(56);
            Console.WriteLine("Display Nodes are");
            list.Display();
            Console.WriteLine("========================================================================================");
            Console.ReadLine();
        }
    }
}
