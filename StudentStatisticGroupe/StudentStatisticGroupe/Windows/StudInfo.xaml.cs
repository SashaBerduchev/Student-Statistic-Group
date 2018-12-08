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

namespace StudentStatisticGroupe.Windows
{
    /// <summary>
    /// Логика взаимодействия для StudInfo.xaml
    /// </summary>
    public partial class StudInfo : Window
    {
        public StudInfo()
        {
            InitializeComponent();
        }

        private void Set_Click(object sender, RoutedEventArgs e)
        {
            StudentStatisticsEDMContainer studentStatisticsEDMContainer = new StudentStatisticsEDMContainer();
            var studstat = new StudentStatistic
            {
                Data = date.Text,
                NameStudent = NameStudent.SelectedItem.ToString(),
                NameTeacher = NameTeacher.SelectedItem.ToString(),
                Point = Points.SelectedItem.ToString(),
                Type = Type.SelectedItem.ToString(),
                Comment = Comment.Text
            };
            studentStatisticsEDMContainer.StudentStatisticSet.Add(studstat);
            studentStatisticsEDMContainer.SaveChanges();

        }
    }
}
