using RegistrationApp.Model;
using RegistrationApp.ViewModel.Commands;
using RegistrationApp.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RegistrationApp.ViewModel
{
    public class GroupsVM : INotifyPropertyChanged
    {
        public ObservableCollection<Database> Databases { get; set; }
        public ObservableCollection<Group> Groups { get; set; }
        private Database selectedDatabase;
        public Database SelectedDatabase
        {
            get { return selectedDatabase; }
            set
            {
                selectedDatabase = value;
                OnPropertyChanged("SelectedDatabase");
                GetGroups();
            }
        }

        private Group selectedGroup;

        public Group SelectedGroup
        {
            get { return selectedGroup; }
            set
            {
                selectedGroup = value;
                OnPropertyChanged("SelectedGroup");
                SelectedGroupChanged?.Invoke(this, new EventArgs());

            }
        }


        private Visibility isVisible;

        public Visibility IsVisible
        {
            get { return isVisible; }
            set
            {
                isVisible = value;
                OnPropertyChanged("IsVisible");
            }
        }
        public NewDatabaseCommand NewDatabaseCommand { get; set; }
        public NewGroupCommand NewGroupCommand { get; set; }
        public EditCommand EditCommand { get; set; }
        public EndEditingCommand EndEditingCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler SelectedGroupChanged;

        public GroupsVM()
        {
            NewDatabaseCommand = new NewDatabaseCommand(this);
            NewGroupCommand = new NewGroupCommand(this);
            EditCommand = new EditCommand(this);
            EndEditingCommand = new EndEditingCommand(this);

            Databases = new ObservableCollection<Database>();
            Groups = new ObservableCollection<Group>();

            isVisible = Visibility.Collapsed;

            GetDatabases();

        }

        public async void CreateDatabase()
        {
            Database newDatabase = new Database
            {
                Name = "Database",
                UserId = App.UserId,
                Date = DateTime.Today.ToString()
            };

            await DatabaseHelper.Insert(newDatabase);

            GetDatabases();
        }


        public async void CreateGroup(string databaseId)
        {
            Group newGroup = new Group
            {
                DatabaseId = databaseId,
                CreatedTime = DateTime.Now,
                UpdatedTime = DateTime.Now
            };

            await DatabaseHelper.Insert(newGroup);

            GetGroups();
        }

        public async void GetDatabases()
        {
            var databases = (await DatabaseHelper.Read<Database>()).Where(d => d.UserId == App.UserId).ToList();
            Databases.Clear();
            foreach (var database in databases)
            {
                Databases.Add(database);
            }
        }
        private async void GetGroups()
        {
            if (SelectedDatabase != null)
            {
                var groups = (await DatabaseHelper.Read<Group>()).Where(g => g.DatabaseId == SelectedDatabase.Id).ToList();
                Groups.Clear();
                foreach (var group in groups)
                {
                    Groups.Add(group);
                }
            }

        }


        private void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void StartEditing()
        {
            IsVisible = Visibility.Visible;
        }
        public void StopEditing(Database database)
        {
            IsVisible = Visibility.Collapsed;
            DatabaseHelper.Update(database);
            GetDatabases();
        }
    }
}
