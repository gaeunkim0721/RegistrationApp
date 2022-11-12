using RegistrationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RegistrationApp.ViewModel.Commands
{
    public class EndEditingCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public GroupsVM ViewModel { get; set; }
        public EndEditingCommand(GroupsVM vm)
        {
            ViewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            Database database = parameter as Database;
            if (database != null)
                ViewModel.StopEditing(database);


        }
    }
}
