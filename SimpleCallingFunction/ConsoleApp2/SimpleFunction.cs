using System;
public class functionthursday
{
    public static void welcome(string name, string surname)
    {
        Console.WriteLine("Hello " + name + surname);
    }
    public static void Enjoy()
    {
        Console.WriteLine("Enjoy working with C# and build your passing command");
    }
    public static void Main(string[] args)
    {
        string string1, string2;
        Console.WriteLine("Please Enter a name: ");
        string1 = Console.ReadLine();
        string2 = Console.ReadLine();
        welcome(string1, string2);
        Enjoy();
    }
}