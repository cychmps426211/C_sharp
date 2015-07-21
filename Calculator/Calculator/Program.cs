using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        private static int priority(char c)
        {
            return c == '+' || c == '-' ? 1 : c == '*' || c == '/' ? 2 : 0;
        }

        private static string toPostfix(string infix)
        {
            string expr = infix;
            Stack<char> stack = new Stack<char>();
            string postfix = "";

            foreach (char chr in expr.ToArray())
            {
                if (chr == '(')
                {
                    stack.Push(chr);
                }
                else if ("+-*/".IndexOf(chr) != -1)
                {
                    while(stack.Count != 0 && priority(stack.Peek()) >= priority(chr))
                    {
                        postfix = postfix + stack.Pop();
                    }
                    stack.Push(chr);
                }
                else if (chr == ')')
                {
                    while (stack.Peek() != '(')
                    {
                        postfix = postfix + stack.Pop();
                    }
                    stack.Pop();
                }
                else
                {
                    postfix = postfix + chr;
                }
            }

            while (stack.Count != 0) 
            {
                postfix = postfix + stack.Pop();
            }

            return postfix;
        }

        public static void Main(string[] args)
        {
            string pattern = "\\s+";
            string replacement = "";
            Regex rgx = new Regex(pattern);

            string input;
            input = Console.ReadLine();
            string infix = rgx.Replace(input, replacement);

            Console.WriteLine(toPostfix(infix));
        }
    }
}
