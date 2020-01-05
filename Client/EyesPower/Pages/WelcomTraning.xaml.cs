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

namespace EyesPower.Pages
{
    /// <summary>
    /// Логика взаимодействия для WelcomTraning.xaml
    /// </summary>
    public partial class WelcomTraning : Page
    {
        public WelcomTraning()
        {
            InitializeComponent();
        }
        private void btyes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Следите за шариком!", "EysePower: Тренировка", MessageBoxButton.OK, MessageBoxImage.Warning);
            Data.number = 2;
            Data.NewPage = true;
        }

        private void btno_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы уверены?", "EysePower: Тренировка", MessageBoxButton.OK, MessageBoxImage.Question);
        }
    }
}
