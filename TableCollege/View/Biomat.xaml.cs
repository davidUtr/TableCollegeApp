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
using TableCollege.Model;

namespace TableCollege.View
{
    /// <summary>
    /// Логика взаимодействия для Biomat.xaml
    /// </summary>
    public partial class Biomat : Window

    {
        public Biomat()
        {
            InitializeComponent();
            // Главное окно
            MainFrame.Content = new TableFragment();

            
        }
        // Переключение между окнами по нажатию кнопки
        private void Table_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TableFragment());
        }

        private void Teacher_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TeacherFragment());
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            
            MainFrame.Navigate(new ProfileFragment());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
           
        }
        private void minimize_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            gray.Visibility = Visibility.Visible;
            white.Visibility = Visibility.Hidden;
        }



        private void white_MouseLeave(object sender, MouseEventArgs e)
        {
            gray.Visibility = Visibility.Hidden;
            white.Visibility = Visibility.Visible;
        }
    }
}
