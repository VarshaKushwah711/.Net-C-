using System;

class Program
{
    static void Main()
    {
        string sentence = "   C# is fun!   ";
        string trimmed = sentence.Trim();
        Console.WriteLine("Trimmed: '" + trimmed + "'");

        string[] words = trimmed.Split(' ');
        Console.WriteLine("Words in sentence:");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}
