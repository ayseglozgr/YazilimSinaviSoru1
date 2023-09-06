using System;
using System.Collections.Generic;
using System.Linq;

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
                //new Point(2, -5),
                //new Point(2, 7),
                //new Point(5, 7),
                //new Point(5, 8),
                //new Point(3, 9)

            };
            List<Point> otherPointsY = new(); 
            List<Point> otherPointsX = new();

            for (int i = 0; i < noktalar.Length; i++)
            {
                for (int j = i + 1; j < noktalar.Length; j++)
                {
                    //y eksenine paralel olan doğrular üzerinde olan noktaları (eğer aynı doğru üzerinde birden fazla nokta varsa bir tanesini) ekliyoruz.
                    //Dolayısıyla bize çıktı olarak y ekenine paralel kaç tane doğru olduğu sonucunu verecektir.
                    if ((noktalar[i].x == noktalar[j].x) && !otherPointsY.Any(a => a.x == noktalar[j].x))
                    {
                        otherPointsY.Add(new Point(noktalar[i].x, noktalar[i].y));
                    }
                }
            }
            
            for (int i = 0; i < noktalar.Length; i++)
            {
                for (int j = i + 1; j < noktalar.Length; j++)
                {
                    //x eksenine paralel olan doğrular üzerinde olan noktaları (eğer aynı doğru üzerinde birden fazla nokta varsa bir tanesini) ekliyoruz.
                    //Dolayısıyla bize çıktı olarak x ekenine paralel kaç tane doğru olduğu sonucunu verecektir.
                    if ((noktalar[i].y == noktalar[j].y) && !otherPointsX.Any(a => a.y == noktalar[j].y))
                    {
                        otherPointsX.Add(new Point(noktalar[i].x, noktalar[j].y));
                    }
                }
            }

            Console.WriteLine("Elimizdeki noktalar :");

            for (int i = 0; i < noktalar.Length; i++)
            {
                Console.WriteLine("(" + noktalar[i].x + "," +noktalar[i].y + ")");
            }
            // Sonuçları yazdıralım
            Console.WriteLine("Y eksenine paralel doğru sayısı: {0}", otherPointsY.Count);
            Console.WriteLine("X eksenine paralel doğru sayısı: {0}", otherPointsX.Count);
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

            