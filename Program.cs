using System;


namespace ConsoleApplication2
{
    public class Test
    {
        public string First { get; set; }

        public string Second { get; set; }
    }

        class Program
        {
            private static void Main()
            {
                var first = new Test{First = "1", Second = "2"};
                var second = new Test{First = "1", Second = "2"};
                Console.WriteLine(first.Equals(second));
                Console.ReadKey();
            }
        }
    }


