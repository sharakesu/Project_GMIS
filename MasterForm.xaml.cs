﻿using System;
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
    /// Interaction logic for MasterForm.xaml
    /// </summary>
    public partial class MasterForm : Window
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AllStudnets all = new AllStudnets();
            all.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
