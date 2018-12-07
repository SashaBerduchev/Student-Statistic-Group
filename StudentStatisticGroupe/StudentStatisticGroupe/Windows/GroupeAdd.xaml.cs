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
    /// Логика взаимодействия для GroupeAdd.xaml
    /// </summary>
    public partial class GroupeAdd : Window
    {
        public GroupeAdd()
        {
            InitializeComponent();
        }

        private void BtnSet_Click(object sender, RoutedEventArgs e)
        {
            StudentStatisticsEDMContainer studentStatisticsEDMContainer = new StudentStatisticsEDMContainer();
            var groupe = new Group
            {
                Name = Name.Text
            };
            studentStatisticsEDMContainer.GroupSet.Add(groupe);
            studentStatisticsEDMContainer.SaveChanges();
        }
    }
}
