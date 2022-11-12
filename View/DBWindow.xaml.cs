using RegistrationApp.Model;
using RegistrationApp.ViewModel;
using RegistrationApp.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Security.Cryptography;

namespace RegistrationApp.View
{
    /// <summary>
    /// Interaction logic for DBWindow.xaml
    /// </summary>
    public partial class DBWindow : Window
    {
        GroupsVM viewModel;
        public DBWindow()
        {
          
            InitializeComponent();

            viewModel = Resources["vm"] as GroupsVM;
            viewModel.SelectedGroupChanged += ViewModel_SelectedNoteChanged;
            
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            if (string.IsNullOrEmpty(App.UserId))
            {
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();

                viewModel.GetDatabases();
            }
        }

        private void ViewModel_SelectedNoteChanged(object? sender, EventArgs e)
        {
            contentRichTextBox.Document.Blocks.Clear();
            if (viewModel.SelectedGroup != null)
            {
                if (!string.IsNullOrEmpty(viewModel.SelectedGroup.Filelocation))
                {
                    FileStream fileStream = new FileStream(viewModel.SelectedGroup.Filelocation, FileMode.Open);
                    var contents = new TextRange(contentRichTextBox.Document.ContentStart, contentRichTextBox.Document.ContentEnd);
                    contents.Load(fileStream, DataFormats.Rtf);

                }
                
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            LineNotify linenotify = new LineNotify();
        }

        private void contentRichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int amountOfCharacters = (new TextRange(contentRichTextBox.Document.ContentStart, contentRichTextBox.Document.ContentEnd)).Text.Length;

            statusTextBlock.Text = $"Document length: {amountOfCharacters} characters";
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string rtffile = System.IO.Path.Combine(Environment.CurrentDirectory, $"{viewModel.SelectedGroup.GroupId}.rtf");

            viewModel.SelectedGroup.Filelocation = rtffile;

            DatabaseHelper.Update(viewModel.SelectedGroup);

            FileStream fileStream = new FileStream(rtffile, FileMode.Create);
            var contents = new TextRange(contentRichTextBox.Document.ContentStart, contentRichTextBox.Document.ContentEnd);
            contents.Save(fileStream, DataFormats.Rtf);




        }
    }
}