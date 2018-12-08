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
    /// Логика взаимодействия для Types.xaml
    /// </summary>
    public partial class Types : Window
    {
        public Types()
        {
            InitializeComponent();
        }

        private void BtnSet_Click(object sender, RoutedEventArgs e)
        {
            StudentStatisticsEDMContainer studentStatisticsEDMContainer = new StudentStatisticsEDMContainer(); ;
            var type = new Type
            {
                NameType = NameType.Text
            };
            studentStatisticsEDMContainer.TypeSet.Add(type);
            studentStatisticsEDMContainer.SaveChanges();

        }
    }
}
