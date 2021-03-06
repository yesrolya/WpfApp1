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

namespace WpfApp1.View
{
    /// <summary>
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public ClientWindow()
        {
            InitializeComponent();
        }
        
        private void ButtonAccept_Click(object sender, RoutedEventArgs e)
        {
            //создание нового клиента
            var client = new Client(NameBox.Text, DayBox.Text, MonthBox.Text, YearBox.Text, PhoneBox.Text);
            Postgre.ExecuteNonQuery(client.ToQueryAdd());
            MainWindow.UpdateTable();
            this.Close();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
