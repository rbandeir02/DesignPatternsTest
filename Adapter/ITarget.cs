using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.Adapter
{
    public interface ITarget
    {
        string ProcessCompanySalary(string[,] employeesArray);
    }
}
