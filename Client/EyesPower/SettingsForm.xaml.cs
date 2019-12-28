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
using EyesPower.Properties;

namespace EyesPower
{
    /// <summary>
    /// Логика взаимодействия для SettingsForm.xaml
    /// </summary>
    public partial class SettingsForm : Window
    {
        public SettingsForm()
        {
            InitializeComponent();

            //Вставка параметров

            checkautoload.IsChecked = Settings.Default.Autoload;
            checkhelp.IsChecked = Settings.Default.YesHelp;
            checkprogram.IsChecked = Settings.Default.Program;
            checkupdate.IsChecked = Settings.Default.Update;
            checktraining.IsChecked = Settings.Default.Training;
        }

        private void btsave_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.Autoload = checkautoload.IsChecked.Value;
            Settings.Default.YesHelp = checkhelp.IsChecked.Value;
            Settings.Default.Program = checkprogram.IsChecked.Value;
            Settings.Default.Update = checkupdate.IsChecked.Value;
            Settings.Default.Training = checktraining.IsChecked.Value;
            Settings.Default.Save();
            MessageBox.Show("Настройки сохранине!", Title, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}