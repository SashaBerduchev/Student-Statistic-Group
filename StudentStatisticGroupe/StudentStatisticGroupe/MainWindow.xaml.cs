using StudentStatisticGroupe.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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

namespace StudentStatisticGroupe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        IContract contract;
        public MainWindow()
        {
            InitializeComponent();

      

            List<Group> groups;
            StudentStatisticsEDMContainer studentStatisticsEDMContainer = new StudentStatisticsEDMContainer();
            groups = studentStatisticsEDMContainer.GroupSet.ToList();
            GroupeCombo.ItemsSource = groups.Select(x => new { x.Name });

        }

        private void BtnPrepod_Click(object sender, RoutedEventArgs e)
        {
            Prepods prepods = new Prepods();
            prepods.Show();
        }

        private void BtnDiscipines_Click(object sender, RoutedEventArgs e)
        {
            Discipline discipline = new Discipline();
            discipline.Show();
        }

        private void BtnStudent_Click(object sender, RoutedEventArgs e)
        {
            Students students = new Students();
            students.Show();
        }

        private void BtnGroups_Click(object sender, RoutedEventArgs e)
        {
            Groups groups = new Groups();
            groups.Show();
        }

        private void BtnStudentInfo_Click(object sender, RoutedEventArgs e)
        {
            StudInfo studInfo = new StudInfo();
            studInfo.Show();
        }

        private void BtnStudenSetData_Click(object sender, RoutedEventArgs e)
        {
            List<StudentStatistic> statistics;
            StudentStatisticsEDMContainer studentStatisticsEDMContainer = new StudentStatisticsEDMContainer();
            statistics = studentStatisticsEDMContainer.StudentStatisticSet.ToList();
            datagrid.ItemsSource = statistics.Select(x => new { x.Data, x.Type, x.NameStudent, x.NameTeacher, x.Point, x.Comment });
        }

        private void BtnType_Click(object sender, RoutedEventArgs e)
        {
            Types types = new Types();
            types.Show();
        }

        private void BtnMarks_Click(object sender, RoutedEventArgs e)
        {
            PointsAdd pointsAdd = new PointsAdd();
            pointsAdd.Show();
        }
    }
}
