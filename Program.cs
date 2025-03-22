using System;
using System.Collections.Generic;

class Program
{
    static void MetodoLinkedList()
    {
        LinkedList<int> numeros = new LinkedList<int>();

        numeros.AddLast(10);
        numeros.AddLast(20);
        numeros.AddLast(30);
        numeros.AddFirst(5);
        numeros.AddAfter(numeros.Find(20), 25);

        Console.WriteLine("LinkedList:");
        foreach (var num in numeros)
        {
            Console.WriteLine(num);
        }
    }

    static void MetodoHashSet()
    {
        HashSet<string> nombres = new HashSet<string>();

        nombres.Add("Ana");
        nombres.Add("Luis");
        nombres.Add("Carlos");
        nombres.Add("Marta");
        nombres.Add("Pedro");

        Console.WriteLine("\nHashSet:");
        foreach (var nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }

    static void Main()
    {
        MetodoLinkedList();
        MetodoHashSet();
    }
}