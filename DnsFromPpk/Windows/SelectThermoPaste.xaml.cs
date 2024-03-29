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
    /// Логика взаимодействия для SelectThermoPaste.xaml
    /// </summary>
    public partial class SelectThermoPaste : Window
    {
        public ThermoPaste SelectedComponent { get; set; }
        public List<ThermoPaste> AllSelectedComponents { get; set; } = new();
        public SelectThermoPaste()
        {
            InitializeComponent();
            DataContext = this;
            List<object> AllComponents = MainWindow.GetInstance().AllComponents;
            if (AllComponents != null)
            {
                for (int i = 0; i < AllComponents.Count; i++)
                    if (AllComponents[i] is ThermoPaste)
                        AllSelectedComponents.Add((ThermoPaste)AllComponents[i]);
            }
            else MessageBox.Show("AllComponents is null");
        }

        private void Select(object sender, RoutedEventArgs e)
        {

            if (SelectedComponent != null)
            {
                MainWindow.GetInstance().AllSelectedComponents.Add(SelectedComponent);
            }
            else MessageBox.Show("Выберите что-нибудь.");
        }
    }
}
