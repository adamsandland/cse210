using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(name, number);

    }
    static void DisplayWelcome () {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName(){
        Console.WriteLine("Please Enter your Name:");
        return Console.ReadLine();
    }
    static int PromptUserNumber(){
        Console.WriteLine("Please Enter your Favorite Number: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int num){
        return num*num;
    }
    static void DisplayResult(string name, int number){
        Console.WriteLine($"{name}, the square of your number is {SquareNumber(number)}");
    }
        
}