using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    // The Visitor Interface declares the Visit Method that corresponds to the Element class. 
    // The Visit Method will accept the IElement object as a parameter i.e. the concrete class 
    // which implements the IElement Interface. In this case the Kid object
    public interface IVisitor
    {
        void Visit(IElement element);
    }
}
