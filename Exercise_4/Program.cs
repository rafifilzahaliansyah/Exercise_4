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
        public int Rafi = 0;

        public void push(int e)
        {
            int f = display();
            if(f==a.Length)
            {
                Console.WriteLine("stack is full");
            }
            else
            {
                a[Rafi] = e;
                Rafi = Rafi + 1;
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
                Rafi = Rafi - 1;
                Console.WriteLine(e);
            }
        }
        public int top()
        {
            int e;
            e = a[Rafi - 1];
            a[Rafi - 1] = 0;
            return e;
        }
        
        public int display()
        {
            return Rafi;
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
                Console.Write("\nEnter Your Choice : ");
                string input = Console.ReadLine();
                char ch = Convert.ToChar(input == "" ? "0" : input);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a Number : ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':
                        if(s.Empty())
                        {
                            Console.WriteLine("\nStack Empty");
                            break;
                        }
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }
}
