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
using System.Text.RegularExpressions;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TableCollege
{
   
    public partial class MainWindow : Window
    {
        //Скрытие Стакпанела , для анимации
        public MainWindow()
        {
            InitializeComponent();
            stackPanel1.Visibility = Visibility.Hidden;
        }
        //Показать/скрыть пароль
        private void PasswordBox_PasswordChanged_1(object sender, RoutedEventArgs e)
        {
            pwdTextBox.Text = PasswordBox.Password;
        }

     
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            pwdTextBox.Visibility = Visibility.Visible;
            PasswordBox.Visibility = Visibility.Hidden;
            Chek.Content = "Скрыть пароль";
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            pwdTextBox.Visibility = Visibility.Hidden;
            PasswordBox.Visibility = Visibility.Visible;
            PasswordBox.Password = pwdTextBox.Text;
            Chek.Content = "Показать пароль";
        }
        
        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Если у вас возникли вопросы или вы забыли логин или пароль, вы можете обратиться к нам на нашем официальном сайте - http://эор.мггтк.рф/");
        }

        private void registration_button_Click(object sender, RoutedEventArgs e)
        {
            if (regFio_Text.Text.Length !=0 && regMail_Text.Text.Length != 0 && regPasport_Text.Text.Length != 0 && regPassword_Text.Text.Length != 0)
            {
                Support.Visibility = Visibility.Visible;
                
            }
            else MessageBox.Show("Все поля обязательно должны быть заполнены!");
        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void ExitImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Support.Visibility = Visibility.Collapsed;
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ваша заявка на регистрацию успешно отправлена! Ожидайте ответа на почте!");
            Support.Visibility = Visibility.Collapsed;
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

        private void Main_MouseDown(object sender, MouseButtonEventArgs e)
        { try
            {
                this.DragMove();
            }
            catch { }
        }
    }
        
    }
 

