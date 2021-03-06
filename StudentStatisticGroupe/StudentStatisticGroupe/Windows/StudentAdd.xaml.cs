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
    /// Логика взаимодействия для StudentAdd.xaml
    /// </summary>
    public partial class StudentAdd : Window
    {
        public StudentAdd()
        {
            InitializeComponent();
            List<Group> groups;
            StudentStatisticsEDMContainer studentStatisticsEDMContainer = new StudentStatisticsEDMContainer();
            groups = studentStatisticsEDMContainer.GroupSet.ToList();
            Groupe.ItemsSource = groups.Select(x => new { x.Name });
        }

        private void CtnSet_Click(object sender, RoutedEventArgs e)
        {
            StudentStatisticsEDMContainer studentStatisticsEDMContainer = new StudentStatisticsEDMContainer();
            var student = new Student
            {
                Name = Name.Text,
                Address = Address.Text,
                Phone = Phone.Text,
                Groupe = Groupe.SelectedItem.ToString(),
                Sername = Serame.Text
            };
            studentStatisticsEDMContainer.StudentSet.Add(student);
            studentStatisticsEDMContainer.SaveChanges();

        }
    }
}
