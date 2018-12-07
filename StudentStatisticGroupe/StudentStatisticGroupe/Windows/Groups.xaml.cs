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
    /// Логика взаимодействия для Groups.xaml
    /// </summary>
    public partial class Groups : Window
    {
        public Groups()
        {
            InitializeComponent();
        }

       
        private void AddGroupe_Click(object sender, RoutedEventArgs e)
        {
            GroupeAdd groupeAdd = new GroupeAdd();
            groupeAdd.Show();
        }

        private void LoadPrepod_Click(object sender, RoutedEventArgs e)
        {
            List<Group> groups;
            StudentStatisticsEDMContainer studentStatisticsEDMContainer = new StudentStatisticsEDMContainer();
            groups = studentStatisticsEDMContainer.GroupSet.ToList();
            DataGrid.ItemsSource = groups.Select(x => new { x.Name });
        }
    }
}
