using System;

class Text
{
    static void Main()
    {
        int M = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        int result = 0;
       
          
        for (int i = 0; i < text.Length; i++)
        {
            char currentSymbol = text[i];
            if (currentSymbol == '@')
            {
                Console.WriteLine(result);
                break;
            }
            else if (Char.IsDigit(currentSymbol))
            {
                result *= currentSymbol - '0';
            }
            else if (Char.IsLetter(currentSymbol))
            {
                result += currentSymbol.ToString().ToUpper().ToCharArray()[0] - 'A';
            }
            else if (true)
            {
                result = result % M;
            }
        }
    }
}
