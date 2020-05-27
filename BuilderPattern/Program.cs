using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // var words = new[] {"hello", "world"};
            // var builder = new HtmlBuilder("ul");
            //
            // foreach (var word in words)
            // {
            //     builder.AddChild("li", word);
            // }
            //
            // Console.WriteLine(builder.ToString());

            HtmlElement element = HtmlElement
                .Create("ul")
                .AddChild("li", "hello");

            Console.WriteLine(element);
        }
    }
}