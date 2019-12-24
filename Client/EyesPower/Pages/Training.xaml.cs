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
using System.Windows.Navigation;
using System.Windows.Shapes;
using EyesPower.Properties;

namespace EyesPower.Pages
{
    /// <summary>
    /// Логика взаимодействия для Training.xaml
    /// </summary>
    public partial class Training : Page
    {
        public Training()
        {
            InitializeComponent();
        }

        private void btnext_Click(object sender, RoutedEventArgs e)
        {
            if (btyes.IsChecked.Value == true)
            {
                Data.Training = true;
            }
            else if (btno.IsChecked.Value == true)
            {
                Data.Training = false;
            }

            //MessageBox.Show($"{Data.Program}, {Data.Training}, {Data.yesHelp}, {Data.Update}");
            MessageBox.Show("Вы успешно закончили настройку!", "EysePower: Настройка", MessageBoxButton.OK, MessageBoxImage.Information);
            Settings.Default.Customization = true;
            Settings.Default.Save();
        }

        private void btback_Click(object sender, RoutedEventArgs e)
        {
            Data.Training = false;
            Data.numberanswer = 4;
            Data.BackPage = true;
        }

        private void btno_Checked(object sender, RoutedEventArgs e)
        {
            btnext.IsEnabled = true;
        }

        private void btyes_Checked(object sender, RoutedEventArgs e)
        {
            btnext.IsEnabled = true;
        }
    }
}
