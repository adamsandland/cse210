using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        MathAssignment newAssignment = new MathAssignment("AJ Sandland", "Math", "7B", "12-18");
        Console.WriteLine(newAssignment.GetSummary());
        Console.WriteLine(newAssignment.GetHomeworkList());

        WritingAssignment nextAssignment = new WritingAssignment("AJ Sandland", "World History", "Judaism in the Middle East");
        Console.WriteLine(nextAssignment.GetSummary());
        Console.WriteLine(nextAssignment.GetWritingInformation());
    }
}