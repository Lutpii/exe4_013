using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4_013
{
    class Stack
    {
        private string[] adi;
        private int top;
        private int max;
        public Stack()
        {
            adi = new string[30];
            top = -1;
            max = 30;
        }
        public void push()
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                top++;
                Console.Write("Pushed element is: ");
                adi[top] = Console.ReadLine();
            }
        }

        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.Write("Poped element is: " + adi[top]);
                top--;
                return top;
            }
        }

        public void display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + adi[i]);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
