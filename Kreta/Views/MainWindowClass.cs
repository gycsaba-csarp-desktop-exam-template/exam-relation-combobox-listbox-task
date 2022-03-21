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

using Kreta.Views.Navigations;
using Kreta.Views.Page;
using Kreta.ViewModel;

namespace Kreta.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ClassViewModel classViewModel = new ClassViewModel();
        private void miClass_Click(object sender, RoutedEventArgs e)
        {
            ClassPage classPage = new ClassPage(classViewModel);
            Navigation.Navigate(classPage);
        }
    }
}
