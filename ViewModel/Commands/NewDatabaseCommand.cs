using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RegistrationApp.ViewModel.Commands
{
    public class NewDatabaseCommand : ICommand
    {
        public GroupsVM VM { get; set; }
        public event EventHandler CanExecuteChanged;

        public NewDatabaseCommand(GroupsVM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            VM.CreateDatabase();
        }
    }
}
