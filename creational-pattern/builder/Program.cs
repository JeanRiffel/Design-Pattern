using System;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {

            // ordinary non-fluent builder
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");
            Console.WriteLine(builder.ToString());

            //fluent builder
            builder.Clear();
            builder.AddChildFluent("li", "hello").AddChildFluent("li", "world");            
            Console.WriteLine(builder);



        }
    }
}
