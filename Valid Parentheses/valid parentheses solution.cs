using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validParen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "true";

            int round = 0;
            int square = 0;
            int curly = 0;

            Console.Write("Input:");
            string s = Console.ReadLine();

            foreach(char c in s)
            {
                if(message == "false")
                {
                    Console.WriteLine($"Output: {message}");
                    Console.ReadKey();
                    break;
                }
                switch (c)
                {
                    case ')':
                        if (round == 0)
                        {
                            message = "false";
                            break;
                        }
                        round --;
                        break;
                    case ']':
                        if (square == 0)
                        {
                            message = "false";
                            break;
                        }
                        square--;
                        break;
                    case '}':
                        if (curly == 0)
                        {
                            message = "false";
                            break;
                        }
                        curly--;
                        break;
                    case '(':
                        round ++;
                        break;
                    case '[':
                        square++;
                        break;
                    case '{':
                        curly++;
                        break;
                    default:
                        break;
                }
            }

            if (round != 0 || square != 0 || curly != 0)
            {
                message = "false";
            }

            Console.WriteLine($"Output: {message}");
            Console.ReadKey();
        }
    }
}
