using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_World
{
    public class myTest
    {
        public int a;
        public myTest()
        {
            Console.WriteLine("Создан объект");
        }
        public int myDouble(int _arg)
        {
            return _arg * 2;
        }
    }
    internal class Program
    {
        static void myConvert(string _promt, out int? a)
        {
            a = null;
            Console.WriteLine(_promt);
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }           
        }
        static void Main(string[] args)
        {
            /*int a = 4;
            string b = "6a";
            int? a1 = null;
            while (a1 == null)
            {
                Program.myConvert("Введите число", out a1);
            }
            var aaa = new myTest();
            Console.WriteLine(aaa.myDouble(a));
            //myTest.myDouble(3); будет работать при статичном методе
            Console.WriteLine(a1);*/

            int[] arr = new int[3] {5,3,7};
           /* foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }*/
            var _list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                _list.Add(arr[i]);
                Console.WriteLine(_list[i]);
            }
            _list.Add(-7);
            int counter = 0;
            foreach (var item in _list)
            {
                Console.Write("Элемент {0} равен {1} \n", counter, item);
                //Console.Write($"Элемент {counter} равен {item}\n");
                counter++;
            }
            Console.ReadKey();
        }
    }
}
