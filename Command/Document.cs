using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.Command
{
    class Document
    {
        public string Open()
        {
            return "Document Opened" + Environment.NewLine;
        }
        public string Save()
        {
            return "Document Saved" + Environment.NewLine;
        }
        public string Close()
        {
            return "Document Closed" + Environment.NewLine;
        }
    }
}
