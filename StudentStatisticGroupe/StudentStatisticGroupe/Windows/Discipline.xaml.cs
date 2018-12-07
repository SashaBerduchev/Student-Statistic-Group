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
    /// Логика взаимодействия для Discipline.xaml
    /// </summary>
    public partial class Discipline : Window
    {
        public Discipline()
        {
            InitializeComponent();
        }

        private void AddPrepod_Click(object sender, RoutedEventArgs e)
        {
            DisciplineAdd disciplineAdd = new DisciplineAdd();
            disciplineAdd.Show();
        }

        private void LoadPrepod_Click(object sender, RoutedEventArgs e)
        {
            List<DisciplineSet> disciplines;
            StudentStatisticsEDMContainer studentStatisticsEDMContainer = new StudentStatisticsEDMContainer();
            disciplines = studentStatisticsEDMContainer.DisciplineSetSet.ToList();
            DataGrid.ItemsSource = disciplines.Select(x => new { x.Name, x.Kafedra });
            
        }
    }
}
