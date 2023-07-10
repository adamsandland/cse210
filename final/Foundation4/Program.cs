using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();
        //all inputs are in km
        exercises.Add(new Running(2, 7.6));
        exercises.Add(new Swimming(26, 30.0));
        exercises.Add(new Bicycles(16, 10));

        foreach (var item in exercises)
        {
            Console.WriteLine($"{item.GetSummary()}\n");
        }
    }
}