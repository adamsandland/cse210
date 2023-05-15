using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction noOne = new Fraction();
        Fraction noTwo = new Fraction(3);
        Fraction noThree = new Fraction(4,7);
        Console.WriteLine($"One:{noOne.GetAsString()}, {noOne.GetAsDouble()}\nTwo:{noTwo.GetAsString()}, {noTwo.GetAsDouble()}\nThree:{noThree.GetAsString()}, {noThree.GetAsDouble()}");
    }
}