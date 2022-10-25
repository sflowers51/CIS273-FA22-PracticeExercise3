using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise3
{
    //double ended Queue
    public interface IDeque<T>
    {
        void AddFront(T item);
        void AddBack(T item);

        T RemoveFront();
        T RemoveBack();

        bool IsEmpty { get; }

        int Length { get; }

        T Front { get; }
        T Back { get; }
    }
}
