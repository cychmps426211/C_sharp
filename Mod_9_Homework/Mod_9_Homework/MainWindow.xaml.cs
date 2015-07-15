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

namespace Mod_9_Homework
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

        public List<Student> students = new List<Student>();
        public static int index = 0;

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            students.Add(new Student(txtFirstName.Text, txtLastName.Text, txtCity.Text));
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (index >= students.Count)
            {
                index = 0;
            }

            txtFirstName.Text = students[index].FirstName;
            txtLastName.Text = students[index].LastName;
            txtCity.Text = students[index].City;

            index++;
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            index = index - 2;
            if (index == -1)
            {
                index = 0;
                txtFirstName.Text = students[index].FirstName;
                txtLastName.Text = students[index].LastName;
                txtCity.Text = students[index].City;
            }
            else if (index == -2)
            {
                index = students.Count - 1;
                txtFirstName.Text = students[index].FirstName;
                txtLastName.Text = students[index].LastName;
                txtCity.Text = students[index].City;
                index++;
            }
            else
            {
                txtFirstName.Text = students[index].FirstName;
                txtLastName.Text = students[index].LastName;
                txtCity.Text = students[index].City;
                if (index != 0) 
                {
                    index++;
                }
            }
        }
    }
}
