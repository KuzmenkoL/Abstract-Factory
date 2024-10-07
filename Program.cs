using System;
using System.Collections.Generic;

namespace fab;

internal class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("1)Волк 2)Дильфин");
            string x = Console.ReadLine();

            if (x == "1")
            {
                AbstractFactory forestFactory = new ForestAnimalFactory();
                Client client = new Client(forestFactory);
                client.Print();

            }
            if (x == "2")
            {

                AbstractFactory seaFactory = new SeaAnimalFactory();
                Client client = new Client(seaFactory);
                client.Print();
            }
        }
    }
}   