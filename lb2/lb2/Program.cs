using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Circle
    {
        public int x;
        public int y;
        public double r;
        public double space
        {
            get
            {
                return Math.PI * r * r;
            }
            set
            {
                r = Math.Sqrt(value / Math.PI);
            }
        }

        public double length
        {
            get
            {
                return 2 * Math.PI * r;
            }
            set
            {
                r = value / (2 * Math.PI);
            }
        }

        public Circle(int x1, int y1, int r1)
        {
            x = x1;
            y = y1;
            r = r1;
        }

        public void Print()
        {
            Console.WriteLine("Окружность с центром в {0}, {1} и радиусом {2}", x, y, r);
        }

        public void belongs(int x1, int y1)
        {
            if (Math.Sqrt((x1 - x) * (x1 - x) + (y1 - y) * (y1 - y)) <= r)
            {
                Console.WriteLine("принадлежит");
            }
            else
            {
                Console.WriteLine("не принадлежит");
            }
        }

        public void crossing(Circle c1)
        {
            if (Math.Sqrt((c1.x - x) * (c1.x - x) + (c1.y - y) * (c1.y - y)) <= (c1.r + r))
            {
                Console.WriteLine("пересекаются");
            }
            else
            {
                Console.WriteLine("не пересекаюся");
            }
        }

        public void zoom(int n)
        {
            r = r * n;
        }

        public void move(int x1, int y1)
        {
            x = x + x1;
            y = y + y1;
        }

        public static double operator +(Circle c1, Circle c2)
        {
            return c1.space + c2.space;
        }
    }
    class Program
    {
        public static void Main()
        {
            Circle c = new Circle(4, 10, 10);
            c.belongs(7, 6);
            Circle c1 = new Circle(20, 10, 10);
            c.crossing(c1);
            Console.WriteLine(c + c1);
        }
    }
}