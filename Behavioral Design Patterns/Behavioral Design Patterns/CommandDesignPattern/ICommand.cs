using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    // Command Interface
    // It declares a method for executing a command
    public interface ICommand
    {
        void Execute();
    }
}
