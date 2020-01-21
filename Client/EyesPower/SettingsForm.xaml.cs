﻿using EyesPower.Properties;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

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
            checkstats.IsChecked = Settings.Default.QuantityYes;
        }

        private void btsave_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.Autoload = checkautoload.IsChecked.Value;
            Settings.Default.YesHelp = checkhelp.IsChecked.Value;
            Settings.Default.Program = checkprogram.IsChecked.Value;
            Settings.Default.Update = checkupdate.IsChecked.Value;
            Settings.Default.Training = checktraining.IsChecked.Value;
            Settings.Default.QuantityYes = checkstats.IsChecked.Value;
            Settings.Default.Save();
            MessageBox.Show("Настройки сохранине!", Title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void Crack()//Есть какой-то баг!
        {
            Dispatcher.Invoke(new Action(() =>
            {
                Task.Delay(100).Wait();
                if (checkstats.IsChecked == false)
                {
                    MessageBoxResult lol = MessageBox.Show("Внимание! При отключение будет удалена вся ваша статистика!", Title,
                        MessageBoxButton.YesNo, MessageBoxImage.Warning);

                    if (lol == MessageBoxResult.Yes)
                    {
                        Settings.Default.StartProgramQuantity = 0;
                        Settings.Default.TraningQuantity = 0;
                        Settings.Default.WaringQuantity = 0;
                        Settings.Default.Save();
                        MessageBox.Show("1");
                        checkstats.IsChecked = false;
                    }
                    else
                    {
                        MessageBox.Show("2");
                        checkstats.IsChecked = true;
                    }
                }
                Thread.Sleep(0);
            }));
        }

        private void checkstats_Checked(object sender, RoutedEventArgs e)
        {
            Thread th = new Thread(new ThreadStart(Crack));
            th.Start();
        }
    }
}
