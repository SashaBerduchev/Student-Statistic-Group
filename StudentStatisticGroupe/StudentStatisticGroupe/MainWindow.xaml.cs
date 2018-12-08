using StudentStatisticGroupe.Windows;
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

namespace StudentStatisticGroupe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
    }
}
