using System;
using System.Collections.Generic;
using System.IO;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!1");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World156!");
            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");


            Console.WriteLine("Hello World!");


            List<Test> test = new List<Test>
            {
                //test is good
            };
        }

        public void ReadFile()
        {
            File.ReadAllLines("");
        }
    }


    public interface ITest
    {
        int Id { get; set; }
        string Name { get; set; }
        long Date { get; set; }
        void Test1();
    }

    public class Test : ITest
    {
        private int _id;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name { get; set; }
        public long Date { get; set; }

        public void Test1()
        {
            int x = 10, y = 10;
            NewMethod(y);

            x = 5;
        }

        private static void NewMethod(long y)
        {
            if (y < 4)
            {
                throw new Exception("error");
            }
        }

//        private static void NewMethod1(int x, long y)
//        {
//            if (x < 4)
//            {
//                throw new Exception("error");
//            }
//        }

        public static int Parse(string port)
        {
            if (port != null && !port.StartsWith("COM"))
            {
                throw new Exception("Error");
            }



            return 1;
        }

        public int Subtract(int a, int b)
        {
            return 0;
        }
        
    }

    class xxx
    {
        public xxx()
        {
            
        }

        public int I { get; private set; }

        public xxx(int i)
        {
            try
            {
                I = i;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            
        }
    }

    interface IInterface
    {
        
    }
}
