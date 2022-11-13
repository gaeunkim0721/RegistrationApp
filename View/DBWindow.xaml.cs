using RegistrationApp.Model;
using RegistrationApp.ViewModel;
using RegistrationApp.ViewModel.Helpers;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using Azure.Storage.Blobs;
using System.Threading.Tasks;

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

        private async void ViewModel_SelectedNoteChanged(object? sender, EventArgs e)
        {
            contentRichTextBox.Document.Blocks.Clear();
            if (viewModel.SelectedGroup != null)
            {
                if (!string.IsNullOrEmpty(viewModel.SelectedGroup.Filelocation))
                {
                    string downloadPath = $"{viewModel.SelectedGroup.Id}.rtf";
                    await new BlobClient(new Uri(viewModel.SelectedGroup.Filelocation)).DownloadToAsync(downloadPath);
                    using (FileStream fileStream = new FileStream(downloadPath, FileMode.Open))
                    {
                        var contents = new TextRange(contentRichTextBox.Document.ContentStart, contentRichTextBox.Document.ContentEnd);
                        contents.Load(fileStream, DataFormats.Rtf);
                    }
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
            //TODO : Send text
        }

        private void contentRichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int amountOfCharacters = (new TextRange(contentRichTextBox.Document.ContentStart, contentRichTextBox.Document.ContentEnd)).Text.Length;

            statusTextBlock.Text = $"Document length: {amountOfCharacters} characters";
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = $"{viewModel.SelectedGroup.GroupId}.rtf";
            string rtffile = System.IO.Path.Combine(Environment.CurrentDirectory, fileName);





            using (FileStream fileStream = new FileStream(rtffile, FileMode.Create))
            {
                var contents = new TextRange(contentRichTextBox.Document.ContentStart, contentRichTextBox.Document.ContentEnd);
                contents.Save(fileStream, DataFormats.Rtf);


            }
            viewModel.SelectedGroup.Filelocation = await UpdateFile(rtffile, fileName);
            await DatabaseHelper.Update(viewModel.SelectedGroup);
        }
        private async Task<string> UpdateFile(string rtffilePath, string fileName)
        {
            string connectionString = "DefaultEndpointsProtocol=https;AccountName=clouddbfornotifications;AccountKey=f0rvtNvaWmsQnxpB8g5g3LD5yz5x6Jt4azxGjv3fnZgT/fYv2Wrw1pUa/pgb6EWFVNvJ1VUrWSJo+ASthA/c+Q==;EndpointSuffix=core.windows.net";
            string containerName = "groups";

            var container = new BlobContainerClient(connectionString, containerName);
            //container.CreateIfNotExistsAsync();

            var blob = container.GetBlobClient(fileName);
            await blob.UploadAsync(rtffilePath, overwrite:true);

            return $"https://clouddbfornotifications.blob.core.windows.net/groups/{fileName}";
        }

    }
}