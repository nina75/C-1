//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
using System;

class PrintNumbersSequence
{
    static void Main()
    {
        int multiplier = 1;
        for (int i = 2; i < 12; i++)
        {
            Console.WriteLine(i * multiplier);
            multiplier *= -1;
        }
    }
}
