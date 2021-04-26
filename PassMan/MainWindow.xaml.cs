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

namespace PassMan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void newPass_Click(object sender, RoutedEventArgs e)
        {
            //dockpanel for all items
            DockPanel dock = new DockPanel();
            //add site text box
            TextBox siteBx = new TextBox();
            siteBx.MinWidth = 50;
            dock.Children.Add(siteBx);
            
            //add pass text box
            TextBox passBx = new TextBox();
            passBx.MinWidth = 50;
            dock.Children.Add(passBx);

            //add remove button
            //Button remBtn = new Button();
            //dock.Children.Add(remBtn);
            //remBtn.Content = "Remove";
            //remBtn.Click += new RoutedEventHandler(remBtn_Click);
            

            passLsBx.Items.Insert(0, dock);
        }

        private void genPass_Click(object sender, RoutedEventArgs e)
        {

        }

        private void remBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                passLsBx.Items.RemoveAt

                (passLsBx.Items.IndexOf(passLsBx.SelectedItem));
            }
            catch
            {
                MessageBox.Show("You must select an item to remove!");
            }
            

        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Data cannot be saved at this time.\nSorry for any inconvenience.");
        }

        private void loadBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Data cannot be loaded at this time.\nSorry for any inconvenience.");
        }
    }
}
