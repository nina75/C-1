//Write a program that reads your birthday(in the format MM.DD.YYYY) from the console and 
//prints on the console how old you are you now and how old will you be after 10 years.

using System;

class PrintAge
{
    static void Main()
    {
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;

        int age = now.Year - birthday.Year;
        if (birthday > now.AddYears(-age))
        {
            age--;
        }
        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}
