using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.Proxy
{
    class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder folder;
        private Employee employee;
        public SharedFolderProxy(Employee emp)
        {
            employee = emp;
        }
        public string PerformRWOperations()
        {
            string s = "";
            if (employee.Role.ToUpper() == "CEO" || employee.Role.ToUpper() == "MANAGER")
            {
                folder = new SharedFolder();
                s = s + "Shared Folder Proxy makes call to the RealFolder 'PerformRWOperations method'" + Environment.NewLine;
                s = s + folder.PerformRWOperations() + Environment.NewLine;
            }
            else
            {
                s = s + "Shared Folder proxy says 'You don't have permission to access this folder'" + Environment.NewLine;
            }

            return s;
        }
    }
}
