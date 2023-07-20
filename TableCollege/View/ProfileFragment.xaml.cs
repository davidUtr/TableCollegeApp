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
using TableCollege.Model;

namespace TableCollege.View
{

    public partial class ProfileFragment : Page
    {
        public ProfileFragment()
        {
            //Связываем данные от аккаунта
            InitializeComponent();
            avatar.Source = new BitmapImage(new Uri(CurrentUser.Image));
            nameText.Text = CurrentUser.Name;
            OpisText.Text = CurrentUser.Teacher;
            RankText.Text = CurrentUser.Description;
            
        }
    }
}
