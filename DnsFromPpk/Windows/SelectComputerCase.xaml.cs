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
    /// Логика взаимодействия для SelectComputerCase.xaml
    /// </summary>
    public partial class SelectComputerCase : Window
    {
        Cpu SelectedComponent = null;
        public SelectComputerCase()
        {
            InitializeComponent();
            DataContext = this;
            List<object> AllComponents = MainWindow.GetInstance().AllComponents;
            List<ComputerCase> ProducatRange = new();
            if (AllComponents != null) { 
                for (int i = 0; i < AllComponents.Count; i++)
                    if (AllComponents[i] is ComputerCase)
                        ProducatRange.Add((ComputerCase)AllComponents[i]); }
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