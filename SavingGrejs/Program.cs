using System.IO;
using System.Text.Json;
using System;

string plombaText = File.ReadAllText("plomba.txt");

Warrior plomba = JsonSerializer.Deserialize<Warrior>(plombaText);

Console.WriteLine("| Current Settings |");
Console.WriteLine(plombaText);

Console.ReadLine();



Console.WriteLine(plomba.Weapon);
Console.WriteLine(plomba.Speed);
Console.WriteLine(plomba.Stamina);

// Warrior plomba = new Warrior();

// plomba.Weapon = "";
// plomba.Stamina = 0;
// plomba.Speed = 0;

// string plombaText = JsonSerializer.Serialize<Warrior>(plomba);

// File.WriteAllText("plomba.txt", plombaText);

Console.ReadLine();