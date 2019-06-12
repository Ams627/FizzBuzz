using System;
using System.Linq;

// c# code golf fizz buzz
class Program
{
    static void Main()
    {
        Enumerable.Range(1, 100).ToList().ForEach(x => Console.WriteLine(new[] { $"{x}", "fizz", "buzz", "fizz buzz" }[1 & 1 << x % 3 | 2 & 2 << x % 5]));
    }
}
