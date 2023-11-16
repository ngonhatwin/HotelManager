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

namespace HotelManagementSystem
{
    /// <summary>
    /// Interaction logic for Rooms.xaml
    /// </summary>
    public partial class Rooms : Window
    {
        public Rooms()
        {
            InitializeComponent();
        }
        private void RoomNumberTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Xóa Placeholder khi TextBox nhận focus
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Room Number")
            {
                textBox.Text = string.Empty;
            }
        }

        private void RoomNumberTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            // Khôi phục lại Placeholder nếu TextBox trống
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Room Number";
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
