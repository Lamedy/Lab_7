using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class point
    {
        private int x;
        private int y;
        public point()
        {
            x = 0;
            y = 0;
        }
        public point(int a, int b)
        {
            x = a;
            y = b;
        }
        // Свойство для переменной x
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        // Свойство для переменной y
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public static point operator + (point po1, point po2)
	    {
            point temp = new point();
            temp.x = po1.x + po2.x;
            temp.y = po1.y + po2.y;
            return temp;
        }
        
        public static point operator ++(point po)
        {
            po.x++;
            po.y++;
            return po;
        }

    }

    class points
    {
        public point[] mas = new point[3];
        public void print()
        {
            for (int i = 0; i < 3; i++)
            {
                System.Console.Write(mas[i].X + " ");
            }
            System.Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                System.Console.Write(mas[i].Y + " ");
            }
            System.Console.WriteLine();
        }
    }

    class ClassPoint 
    {
        public int x, y;

        public ClassPoint(int a, int b) { x = a; y = b; }

        public void printClass() { System.Console.WriteLine("ClassPoint:\tX = " + x + "\tY = " + y); }   
    }

    struct StructPoint
    {
        public int x, y;
        public StructPoint(int a, int b) { x = a; y = b; }

        public void printStruct() { System.Console.WriteLine("StructPoint:\tX = " + x + "\tY = " + y); }
    }

    internal class Program
    {
        static void growClass(ClassPoint a, int n)
        {
            a.x += n; a.y += n;
            System.Console.WriteLine("ClassPoint:\tX = " + a.x + "\tY = " + a.y);
        }

        static void growStruct(StructPoint a, int n)
        {
            a.x += n; a.y += n;
            System.Console.WriteLine("StructPoint:\tX = " + a.x + "\tY = " + a.y);
        }

        static void fun1(ref int k) { k += 5; }
        static void fun2(out int k) { k = 5; }
        static void Main(string[] args)
        {
            // Создание переменной one
            points one = new points();
            for(int i = 0; i < 3; i++) { one.mas[i] = new point(); }
            // Заполнение переменной one с помощью свойства класса point
            for (int i = 0; i < 3; i++)
            {
                one.mas[i].X = i;
                one.mas[i].Y = i + i;
            }
            // Вывод массива 
            one.print();
            System.Console.WriteLine();

            // Отличие class и struct
            ClassPoint point1 = new ClassPoint(1, 2);
            StructPoint point2 = new StructPoint(2, 3);
            
            point1.printClass();    // Вывод значений
            growClass(point1, 10);  // Увеличение значений класса
            point1.printClass();    // Вывод значений

            System.Console.WriteLine();

            point2.printStruct();   // Вывод значений
            growStruct(point2, 100);// Увеличение копий значений, т.е изменяются копии, а не сами данные структуры. growClass и growStruct написанны одинаково
            point2.printStruct();   // Вывод значений

            // Отличие ref от out заключается в том, что при использование out мы обязаны присвоить новое знаение переменной, а при ref - нет
            int z = 12;
            System.Console.WriteLine("\nz = " + z);
            fun1(ref z);
            System.Console.WriteLine("z (ref) = " + z);
            fun2(out z);
            System.Console.WriteLine("z (out) = " + z);
            // Перегрузка оператора '+'
            point a = new point(1, 2);
            point b = new point(2, 3);
            point c = a + b;
            System.Console.WriteLine("\n(+)\na: X = " + a.X + "\tY = " + a.Y + "\nb: X = " + b.X + "\tY = " + b.Y + "\nc: X = " + c.X + "\tY = " + c.Y + "\t( a + b )");
            // Перегрузка оператора "++"
            System.Console.WriteLine("\n(++)\na: X = " + a.X + "\tY = " + a.Y);
            a++;
            System.Console.WriteLine("a: X = " + a.X + "\tY = " + a.Y);
        }
    }
}