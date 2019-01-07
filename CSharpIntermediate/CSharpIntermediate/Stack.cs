using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpIntermediate
{
    public class Stack
    {
        List<object> StackHolder;

        public Stack()
        {
            StackHolder = new List<object>();
        }

        public void Push(object obj)
        {
            try
            {
                if (obj == null)
                    throw new InvalidOperationException("Null object cannot be stored in the stack :)");
                StackHolder.Add(obj);
            }
            catch (Exception)
            {
                Console.WriteLine("exception thrown");
            }
            
        }

        public object Pop()
        {
            try
            {
                if (StackHolder.Count() == 0)
                    throw new InvalidOperationException("Stack is empty.");
                var temp = StackHolder[StackHolder.Count() - 1];
                StackHolder.RemoveAt(StackHolder.Count() - 1);
                return temp;
            }
            catch (Exception)
            {
                Console.WriteLine("Empty stack");
            }

            return -1;
        }

        public void Clear()
        {
            StackHolder.Clear();
        }

        public static void Demo()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(null);
            stack.Push(2);
            stack.Clear();
            stack.Pop();

            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
