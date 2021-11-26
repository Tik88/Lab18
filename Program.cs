using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку содержащую скобки (), [], {}:");
            string b = Console.ReadLine();
            Stack<char> stack = new Stack<char>();            
            char Bracket = '?';
            foreach (char a in b)
            {
                if (stack.Count != 0)
                {
                    switch (stack.Peek())
                    {
                        case '(':
                            Bracket = ')';
                            break;
                        case '{':
                            Bracket = '}';
                            break;
                        case '[':
                            Bracket = ']';
                            break;
                        default:
                            break;
                    }
                }
                if ("({[".Contains(a))
                {
                    stack.Push(a);
                    continue;
                }
                if (")}]".Contains(a) && Bracket == a)
                {
                    stack.Pop();
                    continue;
                }
                if (")}]".Contains(a) && Bracket != a)
                {
                    break;
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("Правильное расположение скобок");
            }
            else
            {
                Console.WriteLine("Неправильное расположение скобок");
            }
            Console.ReadKey();
        }
    }    
}
