using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //recuperacion_listas();
            //recuperacion_diccionario();
            recuperacion_tablaHash();
            Console.ReadLine();
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
                Console.WriteLine($"Par clave valor: {item.ToString()}");
            }
        }
    }
}
