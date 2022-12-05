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
            int f = display();
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
            bool f = Empty();
            if(f==true)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                int e = top();
                i = i - 1;
                Console.WriteLine(e);
            }
        }
        public int top()
        {
            int e;
            e = a[i - 1];
            a[i - 1] = 0;
            return e;
        }
        
        public int display()
        {
            return i;
        }
        public bool Empty()
        {
            if (display()==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            stack s = new stack();
            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***");
                Console.WriteLine("1. Push ");
                Console.WriteLine("2. Pop ");
                Console.WriteLine("3. Display ");
                Console.WriteLine("4. Exit ");
            }
        }
    }
}
