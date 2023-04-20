using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your current score? ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);

        string finalGrade = "0";
        if(gradeInt>=90)
        {
            finalGrade = "A";
        }
        else if(gradeInt>=80)
        {
            finalGrade = "B";
        }
        else if(gradeInt >=70)
        {
            finalGrade = "C";
        }
        else if(gradeInt >=60)
        {
            finalGrade="D";
        }
        else{
            finalGrade="F";
        }
        Console.WriteLine($"Your grade in the class is {finalGrade}");
    }
}