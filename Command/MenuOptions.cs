using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.Command
{
    public class MenuOptions
    {
        private ICommand openCommand;
        private ICommand saveCommand;
        private ICommand closeCommand;
        public MenuOptions(ICommand open, ICommand save, ICommand close)
        {
            this.openCommand = open;
            this.saveCommand = save;
            this.closeCommand = close;
        }
        public string clickOpen()
        {
            return openCommand.Execute();
        }
        public string clickSave()
        {
            return saveCommand.Execute();
        }
        public string clickClose()
        {
            return closeCommand.Execute();
        }
    }
}
