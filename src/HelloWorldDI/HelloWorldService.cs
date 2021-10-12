using System;

namespace HelloWorldDI
{
    public class HelloWorldService
    {
        public void Write(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
    }
}
