using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using TableCollege.ViewModel;
namespace TableCollege.View
{

    public partial class TeacherFragment : Page
    {
        public TeacherFragment()
        {
            InitializeComponent();
            ListView.ItemsSource = user;
        }
        public ObservableCollection<User> User { get { return user; }  } 
        
          
        public ObservableCollection<User> user { get; set; } = new ObservableCollection<User>()
        {
            new User("agrejanokova", "bqwr13", "Агержанокова Марина Николаевна", "", "Куратор группы СИС-32","Преподаватель: Математики и алгоритмизации.\nНомер телефона: +7-912-244-21-51\nMail:agrejanokova@mail.ru", Directory.GetCurrentDirectory() + "\\Image\\teacher1.png"),
            new User("bikovskaya", "bqwr23", "Быковская Виктория Викторовна", "", "Куратор группы ОИБ-22","Преподаватель: Русского языка, литературы и родной литературы.\nНомер телефона:+7-909-423-11-22\nMail:bIkovskaya@mail.ru", Directory.GetCurrentDirectory() + "\\Image\\teacher2.png"),
            new User("lavrik","bqwr33","Лаврик Елена Викторовна","","Куратор группы ИС-11","Преподаватель: Обществознания и истории\nНомер телефона:+7-912-83-32\nMail: Lavrik@mail.ru", Directory.GetCurrentDirectory() + "\\Image\\teacher3.png"),
            new User("irina","bqwr43","Жачемуковна Ирина Нуховна","","Куратор группы ИС-23","Преподаватель: Английского языка\nНомер телефона: +7-918-322-43-11\nMail:irina49332@mail.ru", Directory.GetCurrentDirectory() + "\\Image\\teacher12.png"),
            new User("huade","bqwr53","Хуаде Тимур Альбертович","","Куратор группы ОИБ-32","Преподаватель: Физики, химии и информатики\nНомер телефона: +7-983-591-31-22\nMail:huade@mail.ru", Directory.GetCurrentDirectory() + "\\Image\\teacher7.png"),
            new User("petrosyan","bqwr63","Петросян Камбулат Алигархович","","Куратор группы СИС-41","Преподаватель: Астрономии.\n Номер телефона: +7-921-534-32-52\nMail:petrosyan@mail.ru", Directory.GetCurrentDirectory() + "\\Image\\teacher8.png"),
            new User("pirunova","bqwr73","Пирунова Кристина Олеговна","Зав.Отделением","Не куратор","Преподаватель: ЭВМ, \nНомер телефона: +7-909-587-84-32\nMail:Pirunova@gmail.com", Directory.GetCurrentDirectory() + "\\Image\\teacher5.png"),
            new User("drozdova","bqwr83","Дроздова Марина Витальевна","","Куратор группы ОИБ-33","Преподаватель: МДК 01.01. \nНомер телефона: +7-943-132-09-43\nMail:drozdova@combobox.ru", Directory.GetCurrentDirectory() + "\\Image\\teacher6.png"),
            new User("pashkevich","bqwr93","Пашкевич Роман Викторович","","Куратор группы ОИБ-31","Преподаватель: Архитектура ПО. \nНомер телефона: +7-918-432-63-21\nMail:pashkevich@mail.ru", Directory.GetCurrentDirectory() + "\\Image\\teacher10.png"),
            new User ("shahid","bqwr14","Шахид Абрам Нурмурбекович","","Куратор группы СИС-33","Преподаватель: МДК 04.01.\n Номер телефона: +7-943-213-33-22\nMail:AbramShahid@gmail.com",Directory.GetCurrentDirectory() + "\\Image\\teacher13.png")
        };

    }
}
