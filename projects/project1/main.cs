using System;
using System.Collections.Generic;

class Program
{
    // Класс, представляющий дугу сети
    class Arc
    {
        public int StartVertex { get; set; }
        public int EndVertex { get; set; }

        public Arc(int startVertex, int endVertex)
        {
            StartVertex = startVertex;
            EndVertex = endVertex;
        }

        public override string ToString()
        {
            return $"({StartVertex} -> {EndVertex})";
        }
    }

    static void Main()
    {
        // Создаем список дуг
        List<Arc> arcs = new List<Arc>
        {
            new Arc(3, 4),
            new Arc(1, 2),
            new Arc(2, 3),
            new Arc(1, 3),
            new Arc(2, 4)
        };

        // Сортируем дуги по начальной вершине
        arcs.Sort((arc1, arc2) => arc1.StartVertex.CompareTo(arc2.StartVertex));

        // Выводим отсортированный список дуг
        foreach (var arc in arcs)
        {
            Console.WriteLine(arc);
        }
    }
}
