using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string c;
            Function f = new Function();
            Console.WriteLine("请输入第一个数:");
            string a1 = Console.ReadLine();
            Console.WriteLine("请输入运算符:");
            c = Console.ReadLine();
            Console.WriteLine("请输入第二个数:");
            string b1 = Console.ReadLine();
            Console.WriteLine("请输入第一个字符串:");
            string z = Console.ReadLine();
            Console.WriteLine("请输入第二个字符串:");
            string w = Console.ReadLine();
            a = int.Parse(a1);
            b = int.Parse(b1);
            if (c == "+")
            {
                Console.Write("结果：");
                f.add(a, b);
                f.add(z, w);
            }
            else if (c == "-")
            {
                Console.Write("结果：");
                f.reduce(a, b);
                f.reduce(z,w);
            }
            else if (c == "*")
            {
                Console.Write("结果：");
                f.chengfa(a, b);
            }
            else
            {
                if (b == 0)
                    Console.WriteLine("除数为0,！");
                else
                {
                    Console.Write("结果：");
                    f.chufa(a, b);
                }
            }
            Console.WriteLine("输入需要比较的两个数:");
            int x = Console.Read();
            int y = Console.Read();
            f.Equals(x, y);
        }
    }
}
