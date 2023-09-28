using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day1Factory
{
    class Program
    {
        
        static void Main(string[] arg)
        {
            int type = 1;
            if (type == 1)
            {
                SomeClass someClass = new SomeClass();
                someClass.SomeMethod();

            }
            else if (type == 2)
            {
                SomeClass1 someClass = new SomeClass1();
            }else
            {
                SomeClass2 someClass = new SomeClass2();
            }
            
        }
        class SomeClass
        {
            public void SomeMethod()
            {

            }
        }

        class SomeClass1
        {
            public void SomeMethod()
            {

            }
        }

        class SomeClass2
        {
            public void SomeMethod()
            {

            }
        }
    }
}
