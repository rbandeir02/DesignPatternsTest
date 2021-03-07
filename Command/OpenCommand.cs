using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.Command
{
    class OpenCommand : ICommand
    {
        private Document document;
        public OpenCommand(Document doc)
        {
            document = doc;
        }
        public string Execute()
        {
            return document.Open();
        }
    }
}
