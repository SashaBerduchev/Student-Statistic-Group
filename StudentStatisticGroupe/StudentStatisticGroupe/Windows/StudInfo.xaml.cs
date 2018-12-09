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

            StudentStatisticsEDMContainer studentStatisticsEDMContainer = new StudentStatisticsEDMContainer();
            List<Type> types;
            types = studentStatisticsEDMContainer.TypeSet.ToList();
            Type.ItemsSource = types.Select(x => new { x.NameType});
            List<Student> students;
            students = studentStatisticsEDMContainer.StudentSet.ToList();
            NameStudent.ItemsSource = students.Select(x => new { x.Name });
            List<Teacher> teachers;
            teachers = studentStatisticsEDMContainer.TeacherSet.ToList();
            NameTeacher.ItemsSource = teachers.Select(x => new { x.Name });
            List<Point> points;
            points = studentStatisticsEDMContainer.PointSet.ToList();
            Points.ItemsSource = points.Select(x => new { x.Num });
           
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
