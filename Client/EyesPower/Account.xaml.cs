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
    /// Логика взаимодействия для Account.xaml
    /// </summary>
    public partial class Account : Window
    {
        public Account()
        {
            InitializeComponent();
            if (Settings.Default.Account == false)
                frame.Navigate(new Pages.NoAccount());
            else if (Settings.Default.Account == true)
                frame.Navigate(new Pages.YesAccount());
        }
    }
}