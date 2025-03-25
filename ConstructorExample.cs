using System;
class ConstructorExample
{
    public ConstructorExample()
    {
        Console.WriteLine("Hii, This is explicit Constructor.....");
    }
    static void Main()
    {
        ConstructorExample obj = new ConstructorExample();
        Console.WriteLine("Main method...");
    }
}
