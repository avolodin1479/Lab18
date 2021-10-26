using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Str = { "d{{{ddfdf((((sffd)sf" };
            Stack<string> A = new Stack<string>();
           
            foreach (string i in Str)
            {
                if (i == "(")
                {
                    A.Push(")");
                }
                if (i == "[")
                {
                    A.Push("]");
                }
                if (i == "{")
                {
                    A.Push("}");
                }
                if (i == ")" && i == A.Peek())
                {
                    A.Pop();
                }
                if (i == "]" && i == A.Peek())
                {
                    A.Pop();
                }
                if (i == "}" && i == A.Peek())
                {
                    A.Pop();
                }
            }
            if (A.Count == 0)
            {
                Console.WriteLine("Корректно");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            Console.ReadKey();
        }
    }
}
