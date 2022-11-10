using RegistrationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RegistrationApp.ViewModel.Commands
{
    public class NewGroupCommand : ICommand
    {
        public GroupsVM VM { get; set; }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public NewGroupCommand(GroupsVM vm)
        {
            VM = vm;
        }
        public bool CanExecute(object parameter)
        {
            Database selectedDatabase = parameter as Database;
            if(selectedDatabase != null)
                return true;

            return false;
        }

        public void Execute(object parameter)
        {
            Database selectedDatabase = parameter as Database;
            VM.CreateGroup(selectedDatabase.Id);
            
        }
    }
}
