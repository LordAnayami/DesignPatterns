using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    // Iterator Interface
    // This is going to be an interface defining the operations for accessing and traversing elements in a sequence.
    interface IAbstractIterator
    {
        Elempoyee First();
        Elempoyee Next();
        bool IsCompleted { get; }
    }
}
