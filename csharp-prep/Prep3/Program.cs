using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is your magic number? ");
        //string input = Console.ReadLine();
        //int magic_number = int.Parse(input);
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1,100);

        bool check_for_valid = true;
        do{
            
            Console.WriteLine("What is your guess? ");
            string input2 = Console.ReadLine();
            int guess = int.Parse(input2);
            if(guess<magic_number){
                Console.WriteLine("Higher");
            } else if(guess>magic_number){
                Console.WriteLine("Lower");
            } else{
                Console.WriteLine("You Guessed It!");
                check_for_valid = false;
            }
        } while(check_for_valid);
    }
}