using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new PersonBuilder();
            var person = builder.Called("Alex")
                .WorkAsA("Developer")
                .Build();
            
            Console.WriteLine($"Name: {person.Name}, Position: {person.Position}");
        }
    }
}