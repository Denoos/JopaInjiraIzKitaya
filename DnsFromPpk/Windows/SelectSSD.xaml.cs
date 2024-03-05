﻿using DnsFromPpk.Components;
using System;
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

namespace DnsFromPpk
{
    /// <summary>
    /// Логика взаимодействия для SelectSSD.xaml
    /// </summary>
    public partial class SelectSSD : Window
    {
        Ssd SelectedComponent = null;
        public SelectSSD()
        {
            InitializeComponent();
            DataContext = this;
            List<object> AllComponents = MainWindow.GetInstance().AllComponents;
            List<Ssd> ProducatRange = new();
            if (AllComponents != null)
            {
                for (int i = 0; i < AllComponents.Count; i++)
                    if (AllComponents[i] is Ssd)
                        ProducatRange.Add((Ssd)AllComponents[i]);
            }
            else MessageBox.Show("AllComponents is null");
        }

        private void Select(object sender, RoutedEventArgs e)
        {

            if (SelectedComponent != null)
            {
                Close();
                MainWindow fs = MainWindow.GetInstance();
                fs.Show();
                MainWindow.GetInstance().AllSelectedComponents.Add(SelectedComponent);
            }
            else MessageBox.Show("Выберите что-нибудь.");
        }
    }
}
