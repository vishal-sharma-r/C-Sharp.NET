using System;
namespace Code.Classes1
{
    class Person
    {
        public string? firstName;
        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {firstName}.");
        }
    }
}
