using System.IO;
using System.Text.Json;
using System;
using System.Collections.Generic;


string plombaText = File.ReadAllText("plomba.txt");
string plombaText2 = File.ReadAllText("plomba2.txt");

Warrior plomba = JsonSerializer.Deserialize<Warrior>(plombaText);
Warrior plomba2 = JsonSerializer.Deserialize<Warrior>(plombaText2);



    int ans = 0;
    bool success = false;
    
    while (success != true)
    {
        Console.WriteLine("New Settings = 1");
        Console.WriteLine("Old Settings = 2");
        string answer = Console.ReadLine();

        success = int.TryParse(answer, out ans);
    }
    if (success == true)
    {
        if (ans == 1)
        {
            Console.WriteLine("\n| Current Settings |\n");
            Console.WriteLine(plombaText);
        }
        if (ans == 2)
        {
            Console.WriteLine("\n| Current Settings |\n");
            Console.WriteLine(plombaText2);
        }
        else if (ans > 2 || ans <= 0)
        {
            success = false;
            Console.WriteLine("1 or 2");
        }
        
    }


    // if (answer == "1")
    // {
    // Console.WriteLine("\n| Current Settings |\n");
    // Console.WriteLine(plombaText);
    // }

    // if (answer == "2")
    // {
    //     Console.WriteLine("\n| Current Settings |\n");
    //     Console.WriteLine(plombaText2);
    // }

Console.ReadLine();

// Console.WriteLine(plomba.Weapon);
// Console.WriteLine(plomba.Speed);
// Console.WriteLine(plomba.Stamina);



// Warrior plomba2 = new Warrior();

// plomba2.Weapon = "";
// plomba2.Stamina = 0;
// plomba2.Speed = 0;

// string plombaText2 = JsonSerializer.Serialize<Warrior>(plomba2);

// File.WriteAllText("plomba2.txt", plombaText2);

// Console.ReadLine();