﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace EyesPower
{
    /// <summary>
    /// Логика взаимодействия для StartTraning.xaml
    /// </summary>
    public partial class StartTraning : Window
    {
        public StartTraning()
        {
            InitializeComponent();
            frame.Navigate(new Pages.WelcomTraning());
            Thread thread = new Thread(new ThreadStart(Update));
            thread.Start();
        }

        public void Update()
        {
            bool whiles = true;
            do
            {
                Dispatcher.Invoke(new Action(() =>
                {
                    Task.Delay(10).Wait();
                    if (Pages.Data.number == 2 && Pages.Data.NewPage == true)
                    {
                        Pages.Data.NewPage = false;
                        frame.Navigate(new Pages.TrainingCircle());
                    }

                    if (Pages.Data.number == 3 && Pages.Data.NewPage == true)
                    {
                        Pages.Data.NewPage = false;
                        frame.Navigate(new Pages.TrainingClosing());
                    }

                    if (Pages.Data.number == 4 && Pages.Data.NewPage == true)
                    {
                        Pages.Data.NewPage = false;
                        frame.Navigate(new Pages.TraningWindow());
                    }

                    if (Pages.Data.number == 5 && Pages.Data.NewPage == true)
                    {
                        Pages.Data.NewPage = false;
                        frame.Navigate(new Pages.PicturesTraning());
                    }

                    if (Pages.Data.exit == true)
                    {
                        //Settings.Default.TraningQuantity += 1;
                        //Settings.Default.Save();
                        //whiles = false;
                        this.Close();
                    }
                }));
            } while (whiles);
        }
    }
}
