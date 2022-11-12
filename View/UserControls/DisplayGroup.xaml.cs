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
    /// Interaction logic for DisplayGroup.xaml
    /// </summary>
    public partial class DisplayGroup : UserControl
    {
            public Group Group
            {
                get { return (Group)GetValue(GroupProperty); }
                set { SetValue(GroupProperty, value); }
            }

            // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
            public static readonly DependencyProperty GroupProperty =
                DependencyProperty.Register("Group", typeof(Group), typeof(DisplayGroup), new PropertyMetadata(null, Setvalues));

            private static void Setvalues(DependencyObject d, DependencyPropertyChangedEventArgs e)
            {
                DisplayGroup groupUserControl = d as DisplayGroup;

                if (groupUserControl != null)
                {
                    groupUserControl.DataContext = groupUserControl.Group;
                }
            }

            public DisplayGroup()
            {
                InitializeComponent();
            }
        }
    }
