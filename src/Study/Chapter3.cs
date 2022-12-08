namespace Examples.Chapter3;

using static System.Console;
using System.IO;

class Chapter3
{
    public static void Main()
    {
        int e = 11;
        int f = 3;
        WriteLine($"e is {e}, f is {f}");
        WriteLine($"e + f = {e + f}");
        WriteLine($"e - f = {e - f}");
        WriteLine($"e * f = {e * f}");
        WriteLine($"e / f = {e / f}");
        WriteLine($"e % f = {e % f}");

        double g = 11.0;
        WriteLine($"g is {g:N1}, f is {f}");
        WriteLine($"g / f = {g / f}");
    }

    public static void BitwiseAndShiftOperators()
    {
        int a = 10; // 0000 1010
        int b = 6;  // 0000 0110
        int aAndb = 0000_1010;
        WriteLine($"a = {a}");
        WriteLine($"b = {b}");
        WriteLine($"aAndb = {aAndb}");
        WriteLine($"a & b = {a & b}"); // 2-bit column only
        WriteLine($"a | b = {a | b}"); // 8, 4, and 2-bit columns
        WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns


        // string path = "/Users/markjprice/Code/Chapter03";
        string path = @"C:\Code\Chapter03";
        Stream s = File.Open(
          Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);
        string message = string.Empty;

        message =
        s switch
        {
            FileStream writeableFile when s.CanWrite
              => "The stream is a file that I can write to.",
            FileStream readOnlyFile
              => "The stream is a read-only file.",
            MemoryStream ms
              => "The stream is a memory address.",
            null
              => "The stream is null.",
            _
              => "The stream is some other type."
        };
        WriteLine(message);
    }


    public static void ExceptionHandler()
    {
        WriteLine("Before parsing");
        Write("What is your age? ");
        string input = Console.ReadLine();
        try
        {
            int age = int.Parse(input);
            WriteLine($"You are {age} years old.");
        }
        catch (Exception ex)
        {
            WriteLine($"{ex.GetType()} says {ex.Message}");
        }
        WriteLine("After parsing");
    }
}

