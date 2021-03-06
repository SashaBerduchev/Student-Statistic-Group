﻿using System;
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
    /// Логика взаимодействия для PrepodAdd.xaml
    /// </summary>
    public partial class PrepodAdd : Window
    {
        public PrepodAdd()
        {
            InitializeComponent();
            List<DisciplineSet> disciplines;
            StudentStatisticsEDMContainer studentStatisticsEDMContainer = new StudentStatisticsEDMContainer();
            disciplines = studentStatisticsEDMContainer.DisciplineSetSet.ToList();
            discipline.ItemsSource = disciplines.Select(x => new { x.Name, x.Kafedra });
        }

        private void SetPrepod_Click(object sender, RoutedEventArgs e)
        {
            StudentStatisticsEDMContainer studentStatisticsEDMContainer = new StudentStatisticsEDMContainer();
            var prepod = new Teacher
            {
                Address = adress.Text,
                Discipline = discipline.SelectedItem.ToString(),
                Name = name.Text,
                Phone = phone.Text,
                Sername = sename.Text
            };
            studentStatisticsEDMContainer.TeacherSet.Add(prepod);
            studentStatisticsEDMContainer.SaveChanges();

        }
    }
}
