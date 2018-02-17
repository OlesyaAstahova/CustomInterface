using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    abstract class Shape
    {
        public Shape(string name = "NoName")
        { PetName = name; }
        public string PetName { get; set; }

        //единственный виртуальный метод
        public virtual void Draw()
        {
            Console.WriteLine("Inside Shape.Draw()");
        }
        
    }
    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }

    class Hexagon : Shape, IPointy
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("{0} the Hexagon", PetName);
        }
        // Реализация IPointy.
        public byte Points
        {
            get { return 3; }
        }
    }

    class Triangle : Shape, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Tringle", PetName);
        }
         // Реализация IPointy.
        public byte Points
        {
            get { return 3;  }
        }
    }
}
