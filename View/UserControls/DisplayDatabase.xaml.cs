using RegistrationApp.Model;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RegistrationApp.View.UserControls
{
    /// <summary>
    /// Interaction logic for DisplayDatabase.xaml
    /// </summary>
    public partial class DisplayDatabase : UserControl
    {


        public Database Database
        {
            get { return (Database)GetValue(DatabaseProperty); }
            set { SetValue(DatabaseProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DatabaseProperty =
            DependencyProperty.Register("Database", typeof(Database), typeof(DisplayDatabase), new PropertyMetadata(null, Setvalues));

        private static void Setvalues(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DisplayDatabase databaseUserControl = d as DisplayDatabase;

            if(databaseUserControl != null)
            {
                databaseUserControl.DataContext = databaseUserControl.Database;
            }
        }

        public DisplayDatabase()
        {
            InitializeComponent();
        }
    }
}
