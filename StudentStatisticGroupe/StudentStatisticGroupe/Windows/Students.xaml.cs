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
    /// Логика взаимодействия для Students.xaml
    /// </summary>
    public partial class Students : Window
    {
        public Students()
        {
            InitializeComponent();
        }

        private void StudentsAdd_Click(object sender, RoutedEventArgs e)
        {
            StudentAdd studentAdd = new StudentAdd();
            studentAdd.Show();
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            StudentStatisticsEDMContainer studentStatisticsEDMContainer = new StudentStatisticsEDMContainer();
            List<Student> students;
            students = studentStatisticsEDMContainer.StudentSet.ToList();
            datagrid.ItemsSource = students.Select(x => new { x.Name, x.Sername, x.Phone, x.Groupe, x.Address });
        }
    }
}
