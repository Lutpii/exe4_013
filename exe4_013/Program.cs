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
            adi = new string[32];
            top = -1;
            max = 32;
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
                Console.Write("\nPushed element is: ");
                adi[top] = Console.ReadLine();
            }
        }

        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("\nStack Underflow");
                return -1;
            }
            else
            {
                Console.Write("\nPoped element is: " + adi[top]);
                top--;
                return top;
            }
        }

        public void display()
        {
            if (top == -1)
            {
                Console.WriteLine("\nStack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("\nItem[" + (i + 1) + "]: " + adi[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Stack S = new Stack();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n**Stack Menu**\n");
                Console.WriteLine("1. Push ");
                Console.WriteLine("2. Pop ");
                Console.WriteLine("3. Display ");
                Console.WriteLine("4. Exit ");
                Console.Write("\nEnter your choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        S.push();
                        break;
                    case '2':
                        S.pop();
                        break;
                    case '3':
                        S.display();
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