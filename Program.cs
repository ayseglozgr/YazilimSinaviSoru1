using System;
using System.Collections.Generic;

namespace YazilimSinaviSoru1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Noktaları tanımlayalım
            Point[] noktalar = new Point[]
            {
                new Point(1, 2),
                new Point(3, 7),
                new Point(0, 6),
                new Point(1, 1),
                new Point(-5, 2),
                new Point(1, 5),
                new Point(3, -5)
            };
           List<Point> otherPointsY = new List<Point>();
           List<Point> otherPointsX = new List<Point>();

            // Y eksenine paralel doğruların geçtiği noktaları buluyoruz. aynı zamanda bu noktaları bir listede tutuyoruz.
          
            int yAxisParallelism = 0;
            for (int i = 0; i < noktalar.Length; i++)
            {
                for (int j = i+1; j < noktalar.Length; j++)
                {
                    if (noktalar[i].x == noktalar[j].x)
                    {
                        yAxisParallelism++;
                        otherPointsY.Add(new Point(noktalar[i].x, noktalar[j].y));
                    }
                }
            }
            // Bu döngüde aynı doğru üzerinde 2 den fazla nokta varsa fazla olanları listeden çıkarıyoruz. 
            for (int i = 0; i < otherPointsY.Count; i++)
            {
                for (int j = i + 1; j < otherPointsY.Count; j++)
                {
                    if (otherPointsY[i].x == otherPointsY[j].x)
                    {
                        otherPointsY.RemoveAt(j);
                        yAxisParallelism--;
                    }
                }
            }
            // X eksenine paralel doğruların geçtiği noktaları buluyoruz. aynı zamanda bu noktaları bir listede tutuyoruz.

            int xAxisParallelism = 0;
            for (int i = 0; i < noktalar.Length; i++)
            {
                for (int j = i + 1; j < noktalar.Length; j++)
                {
                    if (noktalar[i].y == noktalar[j].y)
                    {
                        xAxisParallelism++;
                        otherPointsX.Add(new Point(noktalar[i].x, noktalar[j].y));
                    }
                }
            }
            // Bu döngüde aynı doğru üzerinde 2 den fazla nokta varsa fazla olanları listeden çıkarıyoruz. 
            for (int i = 0; i < otherPointsX.Count; i++)
            {
                for (int j = i + 1; j < otherPointsX.Count; j++)
                {
                    if (otherPointsX[i].y == otherPointsX[j].y)
                    {
                        otherPointsX.RemoveAt(j);
                        xAxisParallelism--;
                    }
                }

            }

            // Sonuçları yazdıralım
            Console.WriteLine("Y eksenine paralel doğru sayısı: {0}", yAxisParallelism);
            Console.WriteLine("X eksenine paralel doğru sayısı: {0}", xAxisParallelism);
        }
    }
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}