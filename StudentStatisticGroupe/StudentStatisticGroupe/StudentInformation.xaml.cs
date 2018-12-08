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

namespace StudentStatisticGroupe
{
    /// <summary>
    /// Логика взаимодействия для StudentInformation.xaml
    /// </summary>
    public partial class StudentInformation : Window
    {
        public StudentInformation()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            List<StudentStatistic> statistics;
            StudentStatisticsEDMContainer studentStatisticsEDMContainer = new StudentStatisticsEDMContainer();
            statistics = studentStatisticsEDMContainer.StudentStatisticSet.ToList();
            datagrid.ItemsSource = statistics.Select(x => new { x.Data, x.Type, x.NameStudent, x.NameTeacher, x.Point, x.Comment });
        }
    }
}
