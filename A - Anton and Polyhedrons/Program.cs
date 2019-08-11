using System;
using System.Collections.Generic;

namespace AntonandPolyhedrons
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> polyhedrons = new List<string>();
            for (int i = 0; i < n; i++)
            {
                polyhedrons.Add(Console.ReadLine());
            }
            int faces = 0;
            foreach (var item in polyhedrons)
            {
                switch (item)
                {
                    case "Tetrahedron":
                        faces += 4;
                        break;
                    case "Cube":
                        faces += 6;
                        break;
                    case "Octahedron":
                        faces += 8;
                        break;
                    case "Dodecahedron":
                        faces += 12;
                        break;
                    case "Icosahedron":
                        faces += 20;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(faces);
            Console.ReadLine();
        }
    }
}
