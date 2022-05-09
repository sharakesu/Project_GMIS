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
    /// Interaction logic for BachelorForm.xaml
    /// </summary>
    public partial class BachelorForm : Window
    {
        public BachelorForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AllStudnets allStudnets = new AllStudnets();
            allStudnets.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
