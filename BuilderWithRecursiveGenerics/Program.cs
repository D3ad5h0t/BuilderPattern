using System;

namespace BuilderWithRecursiveGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.New
                .Called("Alex")
                .WorksAs("Engineer")
                .Build();
        }
    }
}