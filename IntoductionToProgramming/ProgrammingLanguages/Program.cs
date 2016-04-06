//Perform a research (e.g. in Google or Wikipedia) and provide a short list with information about the most popular programming languages.
//How similar are they to C#? How do they differ from C#?
//Write in a text file called programming-languages.txt at least five languages along with 2-3 sentences about each of them.
//Use English.

using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("1.Java");
        Console.WriteLine("2.C/C++");
        Console.WriteLine("3.PHP");
        Console.WriteLine("4.JavaScript");
        Console.WriteLine("5.Python");
        Console.WriteLine("Choose Language: (1, 2, 3, 4 or 5)");

        string[] descriptions =
            {
                "Java is a programming language. It was first developed by James Gosling at Sun Microsystems, which is now a part of Oracle Corporation. It was released in 1995 as a part of Sun Microsystems' Java platform. The language has developed much of its syntax from C and C++. Java applications are usually compiled to bytecode (class file) that can run on any Java Virtual Machine (JVM). Java is currently one of the most popular programming languages being used. It has about 10 million users",
                "C++ (pronounced as cee plus plus, /ˈsiː plʌs plʌs/) is a general-purpose programming language. It has imperative, object-oriented and generic programming features, while also providing facilities for low-level memory manipulation.",
                "PHP is a server-side scripting language designed for web development but also used as a general-purpose programming language. Originally created by Rasmus Lerdorf in 1994,[3] the PHP reference implementation is now produced by The PHP Group.PHP originally stood for Personal Home Page,but it now stands for the recursive backronym PHP: Hypertext Preprocessor.",
                "JavaScript is a high-level, dynamic, untyped, and interpreted programming language.It has been standardized in the ECMAScript language specification.Alongside HTML and CSS, it is one of the three essential technologies of World Wide Web content production; the majority of websites employ it and it is supported by all modern Web browsers without plug-ins. JavaScript is prototype-based with first-class functions, making it a multi-paradigm language, supporting object-oriented,[8] imperative, and functional programming styles.It has an API for working with text, arrays, dates and regular expressions, but does not include any I/O, such as networking, storage, or graphics facilities, relying for these upon the host environment in which it is embedded.",
                "Python is a widely used high-level, general-purpose, interpreted, dynamic programming language.Its design philosophy emphasizes code readability, and its syntax allows programmers to express concepts in fewer lines of code than would be possible in languages such as C++ or Java.The language provides constructs intended to enable clear programs on both a small and large scale."
            };

        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine(descriptions[choice - 1]);
    }
}
