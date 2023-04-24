using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int input_number = 0;
        do{
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            input_number = int.Parse(input);
            numbers.Add(input_number);
        }while(input_number !=0);

        int sum = 0;
        int largest = 0;
        foreach (int number in numbers){
            sum+=number;
            if(number>largest){
                largest = number;
            }
        }
        float average = sum/numbers.Count;


        int[] sorted = numbers.ToArray();
        Array.Sort(sorted);
        Console.WriteLine($"Sum: {sum}\nAverage: {average}\nLargest Number: {largest}");

        Console.WriteLine($"{sorted}");
    }
}