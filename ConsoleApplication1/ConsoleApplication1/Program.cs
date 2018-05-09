using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Fib(10);
            //recuperacion_listas();
            //recuperacion_diccionario();
            //recuperacion_tablaHash();
            manejo_ficheros();
            Console.ReadLine();
        }

        public static void Fib(int fin)
        {
            int[] arrayFib = new int[fin];


            for (int i = 0; i < fin; i++)
            {
                if (i < 2)
                {
                    arrayFib[i] = i + 1;
                }
                else
                {
                    arrayFib[i] = arrayFib[i - 1] + arrayFib[i - 2];
                }

            }

            foreach (var item in arrayFib)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void recuperacion_listas()
        {
            var l = new List<int>();

            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);

            foreach (var item in l)
            {
                Console.Write(item);
            }
        }

        public static void recuperacion_diccionario()
        {
            var dic = new Dictionary<string,string>();

            dic.Add("A", "a");
            dic.Add("B", "b");
            dic.Add("C", "c");
            dic.Add("D", "d");
            dic.Add("E", "e");
            dic.Add("F", "f");

            foreach (var item in dic)
            {
                Console.WriteLine($"Par clave valor: {item}");
                Console.WriteLine($"Clave: {item.Key}");
                Console.WriteLine($"Valor: {item.Value}");
            }
        }

        public static void recuperacion_tablaHash()
        {
            var thash = new Hashtable();

            thash.Add("A", "a");
            thash.Add(1, "b");
            thash.Add("C", "c");
            thash.Add(2, "d");
            thash.Add("E", "e");
            thash.Add(3, "f");

            foreach (var item in thash)
            {
                Console.WriteLine($"Par clave valor: {item}");
            }
        }

        public static void manejo_ficheros()
        {
            //var fichero2 = File.CreateText("fichero2.txt");
            using (var file2 = new System.IO.StreamWriter("fichero2.txt", true))
            {
                file2.WriteLine("line");
            }
            using (var file2 = new System.IO.StreamReader("fichero2.txt"))
            {
                file2.ReadLine();
            }
        }
    }
}
