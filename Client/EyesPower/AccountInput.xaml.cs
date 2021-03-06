﻿using EyesPower.Properties;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EyesPower
{
    /// <summary>
    /// Логика взаимодействия для AccountInput.xaml
    /// </summary>
    public partial class AccountInput : Window
    {
        private Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private byte[] buffer = new byte[1024];

        public AccountInput()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btinput_Click(object sender, RoutedEventArgs e)//Вход
        {
            if (string.IsNullOrWhiteSpace(tbemail.Text))
            {
                MessageBox.Show("Без email нельзя!", Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (string.IsNullOrWhiteSpace(tbpass.Password))
            {
                MessageBox.Show("Без пароля нельзя!", Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (tbpass.Password.Length < 8)
            {
                MessageBox.Show("Пароль слишком короткий", Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    client.Connect("127.0.0.1", 904);
                    Task.Delay(30).Wait();
                    client.Send(Encoding.UTF8.GetBytes("EysePower 1.0"));
                    Task.Delay(30).Wait();
                    client.Send(Encoding.UTF8.GetBytes("Log"));
                    Task.Delay(30).Wait();
                    client.Send(Encoding.UTF8.GetBytes(tbemail.Text));
                    Task.Delay(30).Wait();
                    client.Send(Encoding.UTF8.GetBytes(tbpass.Password));
                    int i = client.Receive(buffer);
                    if (Encoding.UTF8.GetString(buffer, 0, i) == "Login Yes")
                    {
                        MessageBox.Show("Вход удался!", "EyesPower: Вход", MessageBoxButton.OK, MessageBoxImage.Information);
                        client.Close();
                        Main main = new Main();
                        main.Show();
                        Settings.Default.Login = tbemail.Text;
                        Settings.Default.Passworld = tbpass.Password;
                        Settings.Default.Account = true;
                        Settings.Default.StartProgram = true;
                        Settings.Default.Save();
                        Data.ExitMain = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Не найдено аккаунта!", "EyesPower: Вход", MessageBoxButton.OK, MessageBoxImage.Error);
                        client.Disconnect(true);
                        client.Close();
                        Data.ExitMain = false;
                    }
                }
                catch { }
            }
        }
    }
}
