using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsInCsharp
{
    internal class UserException
    {
        public static void Main()

        {
            Push_pop pp = new Push_pop();

            pp.Push(10);
            pp.Push(27);
            pp.Push(11);
            pp.Push(97);
            pp.Push(99);
            //pp.Push(19);
            //pp.Push(20);
            pp.print();
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());

            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());




        }
    }


    public class Push_pop
    {



        int[] arr = new int[5];

        int top = 0;



        public void Push(int data)

        {

            try
            {
                if (top == 5)
                {
                    throw new StackException(" User defined Stack Exception : over flow Exception");
                    return ;
                }


                else
                {
                    arr[top] = data;
                    top++;
                }

            }
            catch (Exception e)
            {

            }
        }

        public void print()
        {

            for (int i = top - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public int Pop()
        {
            if (top <= 0)
            {
                throw new StackException("user Defined Stack Exception : Under flow");
                return 0;
            }
            else
            {
                int temp = arr[top - 1];
                top--;

                return temp;
            }
        }
    }

    class StackException : Exception
    {
        public StackException(String message) : base(message)
        {
            Console.WriteLine(message);
        }

    }
}
