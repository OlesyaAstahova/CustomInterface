using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Interfaces *****\n");

            // Создать массив элементов Shape.
            Shape[] myShapes = {
                                   new Hexagon(), new Circle(),
                                   new Triangle(), new Circle("JoJo")
                               };
            for (int i = 0; i < myShapes.Length; i++)
            {
                // Вспомните, что базовый класс Shape определяет абстрактный
                // член Draw(), поэтому все фигуры знают, как себя рисовать.
                myShapes[i].Draw();

                // У всех фигур есть вершины?
                if (myShapes[i] is IPointy)
                {
                    Console.WriteLine("-> Points: {0}", ((IPointy)myShapes[i]).Points);
                }
                else
                {
                    Console.WriteLine("-> {0}\'s not pointy!", myShapes[i].PetName);
                    Console.WriteLine();
                }
                if (myShapes[i] is IDraw3D)
                {
                    DrawIn3D((IDraw3D)myShapes[i]);
                }

            }

          
            Console.ReadLine();
        }

        static void DrawIn3D (IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type\n");
            itf3d.Draw3D();
        }
    }
}
