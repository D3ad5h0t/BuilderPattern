using System;

namespace MultifacetedBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var personBuilder = new PersonBuilder();
            Person person = personBuilder
                .Lives
                    .At("123 London Road")
                    .In("London").WithPostcode("SW12BC")
                .Works
                    .At("Fabrikam")
                    .AsA("Engineer")
                    .Earning(127000);

            Console.WriteLine(person);
        }
    }
}