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
using System.IO;
namespace TableCollege.View
{
   
    public partial class TableFragment : Page
    {
        public TableFragment()
        {
            InitializeComponent();
            //Файлы с данными, которые мы будем использовать в ComboBox
            List<string> Group = new List<string>();
        Group = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Txt_Files\\group.txt").ToList();
            
            GroupBox.ItemsSource = Group;
            Group = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Txt_Files\\week.txt").ToList();
            WeekBox.ItemsSource = Group;
            Group = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Txt_Files\\days.txt").ToList();
            DaysBox.ItemsSource = Group;

        }
        //Добавление данных и расписания
        private void GroupBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          if (GroupBox.SelectedIndex !=-1 && WeekBox.SelectedIndex !=-1 && DaysBox.SelectedIndex !=-1)
            {
                List<string>Tables = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Txt_Files\\table.txt").ToList();
                string group = GroupBox.SelectedValue.ToString();
                string week = WeekBox.SelectedValue.ToString();
                string days = DaysBox.SelectedValue.ToString();
                string table = Tables.Where(x => x.Contains(group) && x.Contains(week) && x.Contains(days)).FirstOrDefault();
                table =  table.Replace("$", "\n");
                TableBlock.Text = table;
            }
         
          
        }

       
    }
}
