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
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
