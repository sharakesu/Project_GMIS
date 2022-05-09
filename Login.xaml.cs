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
using System.Windows.Shapes;

namespace GMIS
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string loginas = loginComboBox.Text ;

            if (txtUsername.Text == "Admin" &&  txtPasssword.Text == "12345" && loginas == "Master")
            {
                MasterForm master = new MasterForm();
                master.Show();
            }
             else if (txtUsername.Text == "User" && txtPasssword.Text == "12345" && loginas == "Bachelor")
            {
                BachelorForm bachelorForm = new BachelorForm();
                bachelorForm.Show();
            }
            else
            {
                MessageBox.Show("Üsername and password not vaild");
            }

        }
    }
}
