using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        int health = 100;
        int gold = 0;

        List<string> dungeon = new List<string>();

        dungeon.Add("Empty Room");
        dungeon.Add("Enemy");
        dungeon.Add("Treasure");
        dungeon.Add("Trap");
        dungeon.Add("Enemy");

        foreach (string oda in dungeon)
        {

            if (oda == "Enemy")
            {
                health -= 20;
                Console.WriteLine("An enemy appeared! You took damage.");
            }
            else if (oda == "Treasure")
            {
                gold += 50;
                Console.WriteLine("You found a treasure chest! Gold added.");
            }
            else if (oda == "Trap")
            {
                health -=10;
                Console.WriteLine("You stepped on a trap! Health decreased.");
            }
            else
            {
                Console.WriteLine("The room is clear. Moving on...");
            }
            
        }
        Console.WriteLine("Status -> HP: " + health + " | Gold: " + gold);

    }
}
