using Lab10.BusinessLayer.Models;
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

namespace Lab10.Dialogs
{
    /// <summary>
    /// Логика взаимодействия для EditClient.xaml
    /// </summary>
    public partial class EditClient : Window
    {
        ClientViewModel clientViewModel;
        public EditClient(ClientViewModel clientViewModel)
        {
            InitializeComponent();
            this.clientViewModel = clientViewModel;
            grid.DataContext = clientViewModel;
        }

        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"{clientViewModel.FullName} {clientViewModel.DateOfBirth} {clientViewModel.FileName} {clientViewModel.Age}");
            this.DialogResult = true;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
