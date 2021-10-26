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
            string Str ="ddd[f{ddaa(kkk)f(sffd)s}r]f";
            Stack<char> A = new Stack<char>();
           
            foreach (char i in Str)
            {
                if (i == '(')
                {
                    A.Push(')');
                }
                if (i == '[')
                {
                    A.Push(']');
                }
                if (i == '{')
                {
                    A.Push('}');
                }
                if (i == ')' && i == A.Peek())
                {
                    A.Pop();
                }
                if (i == ']' && i == A.Peek())
                {
                    A.Pop();
                }
                if (i == '}' && i == A.Peek())
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
