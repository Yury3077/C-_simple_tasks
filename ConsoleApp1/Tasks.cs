using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Task18;

namespace ConsoleApp1
{
    public class Task1
    {
        public static void Res()
        {
            int a = 2;
            Object o = a;
            a = 4;
            Console.WriteLine(a);
            Console.WriteLine(o);
        }
    }

    public class Task2
    {
        public static void Res()
        {
            int a = 2;
            Object o = a;
            a = 4;
            Console.WriteLine(a);
            Console.WriteLine(o);
        }
    }

    public class Task3
    {
        public static void Res()
        {
            var list = new List<string> { "Foo", "Bar", "Baz" };
            var start = "F";
            var query = list.Where(c => c.StartsWith(start));
            start = "B";
            query = query.Where(c => c.StartsWith(start));
            Console.WriteLine(query.Count());
        }
    }

    public class Task4
    {
        public int Inc(int x)
        {
            return x + 1;
        }
        public static void Res()
        {
            Task4 M = new Task4();
            var numbers = Enumerable.Range(0, 10); //[0-9]

            var query =
            (from number in numbers
            let number2 = M.Inc(number)
            where number2 % 2 != 0
            select number2).Take(4);
            foreach (var number in query)
                Console.WriteLine("Number: " + number);
        }
    }

    public class Task5
    {
        public static void Res()
        {
            var list = new List<string> { "Foo", "Bar", "Baz" };
            var start = "Q";
            var query = list.Where(c => c.StartsWith(start));
            Console.WriteLine(query.First());
        }
    }

    public class Task6
    {
        delegate void Printer();
        public static void Res()
        {
            List<Printer> printers = new List<Printer>();
        }
    }

    public class Task7
    {
        public static void Res()
        {
            var a = 2;
            var b = 5;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }

    public class Task8
    {
        public class A { public static int x = B.y + 1; }
        public class B { public static int y = A.x + 1; }
        public static void Res()
        {
            Console.WriteLine("A.x = " + A.x);
            Console.WriteLine("B.y = " + B.y);
        }
    }

    public class Task9
    {
        public class B { public static int y; }

        public static void Res()
        {
            B.y = 1;
        }
    }

    public class Task10
    {
        public static void Res () {
            var numbеrs = new List<int> { 1, 2, 3, 4 };
            Console.WriteLine(numbеrs.Where(x => x > 4).First());
        }
    }

    public class Task11
    {
        delegate void Printer();

        public static void Res ()
        {
            List<Printer> printers = new List<Printer>();
            for (int i = 0; i < 10; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });
            }
            foreach (var printer in printers)
            {
                printer();
            }

        }
    }

    public class Task12
    {
        static String str1;
        static DateTime date1;
        public static void Res()
        {
            Console.WriteLine(str1 == null ? "str1 is null" : str1);
            Console.WriteLine(date1 == null ? "date1 is null" : date1.ToString());
        }
    }

    public class Task13
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Task13(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public static void Res()
        {
            var ivan = new Task13("Ivan", 23);
            var petr = ivan;
            petr.Name = "Petr";
            Console.WriteLine(ivan.Name);
        }
    }

    public class Task14
    {
        public static void Res()
        {
            /*var a = null;
            a = 10;
            Console.WriteLine(a);*/
        }
    }

    public class Task15 {
        public static void Res()
        {
            var list = new List<string> { "Foo", "Bar", "Baz" };
            var start = "F";
            var query = list.Where(c => c.StartsWith(start));
            start = "B";
            query = query.Where(c => c.StartsWith(start));
            Console.WriteLine(query.Count());
        }
    }

    public class Task16
    {
        public static void Res()
        {
            var list = new List<string> { "Foo", "Bar", "Baz" };
            var start = "C";
            Console.WriteLine(list.First(c => c.StartsWith(start)));
        }
    }
    public class Task17
    {
        public static void Res()
        {
            var list = new List<string> { "Foo", "Bar", "Baz" };
            var start = "B";
            Console.WriteLine(list.SingleOrDefault(c => c.StartsWith(start)));
        }
    }

    public class Task18
    {
        public class TrainStation
        {
            delegate int Train(); 
            public int Wagon1()
            {
                Console.WriteLine("wagon1 is running");
                return 1;
            }

            public int Wagon2()
            {
                Console.WriteLine("wagon2 is running");
                return 2;
            }
            public void CreateTrain()
            {
                Train train = Wagon1;
                train += Wagon2;
                train += () =>
                {
                    Console.WriteLine("wagon3 is running");
                    return 3;
                };

                train();
            }
        }
    }

    internal class Tasks
    {
        static void Main(string[] args)
        {
            ConsoleApp1.Task1.Res();
        }
    }
}
