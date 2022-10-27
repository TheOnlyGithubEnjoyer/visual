using System.IO;
using System.Text.Json;
using System;
using System.Collections.Generic;
// string plombaText = File.ReadAllText("plomba.txt");
// string plombaText2 = File.ReadAllText("plomba2.txt");

// Warrior plomba = JsonSerializer.Deserialize<Warrior>(plombaText);
// Warrior plomba2 = JsonSerializer.Deserialize<Warrior>(plombaText2);


// Console.WriteLine("| Current Settings |");
// Console.WriteLine("New Settings = 1");
// Console.WriteLine("Old Settings = 2");

//     int answer;

//     answer = 1;

//     if (answer == 1)
//     {
//     Console.WriteLine(plombaText);
//     }


// Console.ReadLine();

// Console.WriteLine(plomba.Weapon);
// Console.WriteLine(plomba.Speed);
// Console.WriteLine(plomba.Stamina);



Warrior plomba2 = new Warrior();

plomba2.Weapon = "";
plomba2.Stamina = 0;
plomba2.Speed = 0;

string plombaText2 = JsonSerializer.Serialize<Warrior>(plomba2);

File.WriteAllText("plomba2.txt", plombaText2);

Console.ReadLine();