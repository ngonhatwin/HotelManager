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

namespace HotelManagementSystem
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

        private void Show_Room_Click(object sender, RoutedEventArgs e)
        {
            Rooms myroom = new Rooms();
            myroom.Show();
            this.Hide();
        }

        private void Show_Student_Click(object sender, RoutedEventArgs e)
        {
            Student mystudent = new Student();
            mystudent.Show();
            this.Hide();
        }

        private void Show_Emloyee_Click(object sender, RoutedEventArgs e)
        {
            Emloyee myemloyee = new Emloyee();
            myemloyee.Show();
            this.Hide();
        }

        private void Show_Fees_Click(object sender, RoutedEventArgs e)
        {
            Fees myfees = new Fees();
            myfees.Show();
            this.Hide();
        }

        private void Show_Salary_Click(object sender, RoutedEventArgs e)
        {
            Salary mysalary = new Salary();
            mysalary.Show();
            this.Hide();
        }
    }
}
