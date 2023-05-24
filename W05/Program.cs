// See https://aka.ms/new-console-template for more information

Player adam = new Player("Adam","Byleth");

Console.WriteLine(adam.StringifyData());
adam.UpdateAverageScores(534, 3, 2);
Console.WriteLine(adam.StringifyData());
