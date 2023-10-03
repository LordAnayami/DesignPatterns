﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    public class Program
    {
        static void Main()
        {
            // Build a collection
            ConcreteCollection collection = new ConcreteCollection();

            collection.AddEmployee(new Elempoyee("Anurag", 100));
            collection.AddEmployee(new Elempoyee("Pranaya", 101));
            collection.AddEmployee(new Elempoyee("Santosh", 102));
            collection.AddEmployee(new Elempoyee("Priyanka", 103));
            collection.AddEmployee(new Elempoyee("Abinash", 104));
            collection.AddEmployee(new Elempoyee("Preety", 105));

            // Create iterator
            Iterator iterator = collection.CreateIterator();

            //looping iterator      
            Console.WriteLine("Iterating over collection:");

            for (Elempoyee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
            }
            Console.Read();
        }
    }
}
