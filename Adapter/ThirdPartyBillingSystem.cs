using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.Adapter
{
    class ThirdPartyBillingSystem
    {
        //ThirdPartyBillingSystem accepts employees information as a List to process each employee salary
        public string ProcessSalary(List<Employee> listEmployee)
        {
            string s = "";
            foreach (Employee employee in listEmployee)
            {
                s = s + "Rs." + employee.Salary + " Salary Credited to " + employee.Name + " Account" + Environment.NewLine;
            }
            return s;
        }
    }
}
