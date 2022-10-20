using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise3
{
    public class Stack<T> : IStack<T>
    {
        private LinkedList<T> linkedList;

        public Stack()
        {
            linkedList = new LinkedList<T>();
        }

        public bool IsEmpty => linkedList.Count == 0;

        public int Length => linkedList.Count;

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new EmptyStackException();
            }

            return linkedList.Last.Value;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new EmptyStackException();
            }

            // in microsoft, last is the node, not the data
            // Get() this value with the code below
            var top = linkedList.Last.Value;

            linkedList.RemoveLast();

            return top;
        }

        public void Push(T item)
        {
            linkedList.AddLast(item);
        }
    }
}
