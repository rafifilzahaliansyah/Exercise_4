using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class stack
    {
        public int[] a = new int[52];
        public int i = 0;

        public void push(int e)
        {
            int f = count();
            if(f==a.Length)
            {
                Console.WriteLine("stack is full");
            }
            else
            {
                a[i] = e;
                i = i + 1;
            }
        }
        public void pop()
        {

        }
        public int top()
        {
            int e;
            e = a[i - 1];
            a[i - 1] = 0;
            return e;
        }
        
        public int count()
        {
            return i;
        }
        public bool Empty()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
