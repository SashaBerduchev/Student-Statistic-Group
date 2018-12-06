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
    /// Логика взаимодействия для Prepods.xaml
    /// </summary>
    public partial class Prepods : Window
    {
        public Prepods()
        {
            InitializeComponent();
        }

        private void AddPrepod_Click(object sender, RoutedEventArgs e)
        {
            PrepodAdd prepodAdd = new PrepodAdd();
            prepodAdd.Show();
        }
    }
}
