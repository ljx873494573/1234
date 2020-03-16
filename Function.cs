using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test2_5
{
    class Function
    {
        public void add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void add(string a,string b)
        {
            Console.WriteLine(a + b);
        }
        public void reduce(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void reduce(string a, string b)
        {
            int c=a.IndexOf(b);
            int d = b.Length;
            string e=a.Remove(c, d);
            Console.WriteLine(e);
        }
        public void chengfa(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void chufa(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public void Equals(int a, int b)
        {
            if (a == b)
                Console.WriteLine("a和b相等！");
            else
                Console.WriteLine("a和b不相等！");
        }
    }
}
