using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using MySql.Data.MySqlClient;
namespace GMIS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public StudentGroupDBLoad studentGroupDBLoad;
        public ClassDBLoad classDBLoad;

        public MainWindow()
        {
            InitializeComponent();

            studentGroupDBLoad = (StudentGroupDBLoad)Application.Current.FindResource("group_controller");

            classDBLoad = (ClassDBLoad)Application.Current.FindResource("class_controller");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            groupListbox.Items.Clear();
            for (int i = 0; i < studentGroupDBLoad.GetData().Count; i++)
            {
                groupListbox.Items.Add(studentGroupDBLoad.GetData()[i]);
            }

            classComboBox.Items.Clear();
            for (int i = 0; i < classDBLoad.GetComboData().Count; i++)
            {
                classComboBox.Items.Add(classDBLoad.GetComboData()[i]);
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //groupListbox.Items.Clear();
            //for (int i = 0; i < studentGroupDBLoad.GetData().Count; i++)
            //{
            //    groupListbox.Items.Add(studentGroupDBLoad.GetData()[i]);
            //}
        }

        private void grpListView_Loaded(object sender, RoutedEventArgs e)
        {


            //grpListView.Items.Clear();
            //for (int i = 0; i < studentGroupDBLoad.GetData().Count; i++)
            //{
            //    grpListView.Items.Add(studentGroupDBLoad.GetData()[i]);
            //}
        }

        public void LoadClassID()
        {
            

           
        }

        private void classComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ObservableCollection<StudentGroupModel> studentGroups = studentGroupDBLoad.GetData();
            groupListbox.Items.Clear();
            String groupID = String.Concat(searchBox.Text.Where(c => !Char.IsWhiteSpace(c)));
            if(searchBox.Text != "")
            {
                if (studentGroups.Count() != 0)
                {
                    for (int i = 0; i < studentGroups.Count; i++)
                    {
                        if (studentGroups[i].group_id == Convert.ToInt64(groupID))
                        {
                            groupListbox.Items.Add(studentGroups[i]);
                        }
                    }
                }
            }
            else
            {
                groupListbox.Items.Clear();
                for (int i = 0; i < studentGroupDBLoad.GetData().Count; i++)
                {
                    groupListbox.Items.Add(studentGroupDBLoad.GetData()[i]);
                }
            }

        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {


           
        }

        
    }
}
