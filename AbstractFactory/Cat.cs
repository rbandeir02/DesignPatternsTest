using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.AbstractFactory
{
    class Cat : Animal
    {
        public string speak()
        {
            return "Meow Meow Meow";
        }
    }
}
