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
    /// Логика взаимодействия для DisciplineAdd.xaml
    /// </summary>
    public partial class DisciplineAdd : Window
    {
        public DisciplineAdd()
        {
            InitializeComponent();
        }

        private void SetPrepod_Click(object sender, RoutedEventArgs e)
        {
            StudentStatisticsEDMContainer studentStatisticsEDMContainer = new StudentStatisticsEDMContainer();
            var descipline = new DisciplineSet
            {
                Name = name.Text,
                Kafedra = kafedra.Text
            };
            studentStatisticsEDMContainer.DisciplineSetSet.Add(descipline);
            studentStatisticsEDMContainer.SaveChanges();

        }
    }
}
