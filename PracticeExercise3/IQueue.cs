using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise3
{

    public interface IQueue<T>
    {
        void Enqueue(T item);

        T Dequeue();

        T First { get; }
        
        T Last {get; }

        int Length{ get; }
        
        bool IsEmpty{ get; }
    }
}
