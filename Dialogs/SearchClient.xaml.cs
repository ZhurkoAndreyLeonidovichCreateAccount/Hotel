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
    /// Логика взаимодействия для SearchClient.xaml
    /// </summary>
    public partial class SearchClient : Window
    {
        ClientViewModel clientViewModel;
        public SearchClient(ClientViewModel clientViewModel)
        {
            InitializeComponent();
            this.clientViewModel = clientViewModel;

        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            clientViewModel.FullName = cBoxFIO.Text;
            this.DialogResult = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
