using System;
using System.Collections.Generic;
using System.Linq;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckBalanced("(}())[]"));
        }
        public static bool CheckBalanced(String check)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < check.Length; i++)
            {
                char character = check[i];
                if (character == '[' || character == '{' || character == '(')
                    stack.Push(character);
                else if (character == ']' || character == '}' || character == ')')
                {
                    if (!stack.Any())
                        return false;
                    switch (character)
                    {
                        case ']':
                            if (stack.Pop() != '[')
                                return false;
                            break;
                        case '}':
                            if (stack.Pop() != '{')
                                return false;
                            break;
                        case ')':
                            if (stack.Pop() != '(')
                                return false;
                            break;
                        default:
                            break;
                    }
                }
            }
            // проверка, что стек пуст, значит строка сбалансирована
            if (!stack.Any())
            {
                return true;
            }
            return false;
        }
    }
}
