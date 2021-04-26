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
            siteBx.MinWidth = 60;
            siteBx.Text = "Site";
            siteBx.GotFocus += new RoutedEventHandler(textBox_GotFocus);
            dock.Children.Add(siteBx);

            //add user text box
            TextBox userBx = new TextBox();
            userBx.MinWidth = 60;
            userBx.Text = "Username";
            userBx.GotFocus += new RoutedEventHandler(textBox_GotFocus);
            dock.Children.Add(userBx);

            //add pass text box
            TextBox passBx = new TextBox();
            passBx.MinWidth = 60;
            passBx.Text = "Password";
            passBx.GotFocus += new RoutedEventHandler(textBox_GotFocus);
            dock.Children.Add(passBx);

            //add remove button
            //Button remBtn = new Button();
            //dock.Children.Add(remBtn);
            //remBtn.Content = "Remove";
            //remBtn.Click += new RoutedEventHandler(remBtn_Click);
            

            passLsBx.Items.Insert(0, dock);
        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Dispatcher.BeginInvoke(new Action(() => textBox.SelectAll()));
        }

        private void genPass_Click(object sender, RoutedEventArgs e)
        {
            string cap = "";
            for (int i = 'A'; i < 'Z' + 1; i++)
            {
                cap += (char)i;
            }
            string low = "";
            for (int i = 97; i < 123; i++)
            {
                low += (char)i;
            }

            string num = "0123456789";
            string spe = "!@#$%^&*";


            //get available characters
            string available = "";

            if (capCB.IsChecked == true)
            {
                available += cap;
            }

            if (lowCB.IsChecked == true)
            {
                available += low;
            }

            if (numCB.IsChecked == true)
            {
                available += num;
            }

            if (speCB.IsChecked == true)
            {
                available += spe;
            }

            passPreview.Content = available;

        }

        private string getAvailChars(string cap, string low, string num, string spe)
        {
            

            return available;
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

        private void clearAll_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                passLsBx.Items.Clear();
            }
            catch
            {
                MessageBox.Show("There is nothing to remove!");
            }
        }
    }
}
