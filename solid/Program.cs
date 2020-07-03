using System;
using System.Collections.Generic;

namespace solid
{
    class Program
    {
       
        public class Rectangle {
            public int Width {get; set;}
            public int Height {get; set;}

            public Rectangle(int Width, int Height){
                this.Width  = Width;
                this.Height = Height;
            }

            public override string ToString() {
                return $"{nameof(Width)} : {Width} : {nameof(Height)} : {Height} ";
            }

        }

        static void Main(string[] args)
        {
         


            /*
            Console.WriteLine("Type a option \n [1]: SRP, [2] OCP  [3] LSP...");
            int option = Int32.Parse(Console.ReadLine());

            switch(option)
            {
                case 1 : Console.WriteLine("Not available");
                    break;
                case 2 : 
                    var apple = new Product("Apple", Color.Green, Size.Medium);
                    var tree  = new Product("Tree", Color.Green, Size.Small);
                    var house = new Product("House", Color.Blue, Size.Large);

                    Product [] products = {apple, tree, house};

                    var bf = new BetterFilter();
                    Console.WriteLine("New");
                    foreach(var p in bf.Filter(products, new ColorSpecification(Color.Green))){
                            Console.WriteLine($" { p.name } ");
                    }

                




                    break;

            }
                */




        }
    }
}
