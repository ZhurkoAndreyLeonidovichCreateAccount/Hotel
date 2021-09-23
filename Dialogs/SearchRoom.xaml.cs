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
    /// Логика взаимодействия для SearchRoom.xaml
    /// </summary>
    public partial class SearchRoom : Window
    {
        RoomViewModel roomViewModel;


        public SearchRoom(RoomViewModel roomViewModel)
        {
            InitializeComponent();
            int[] mas = new int[] { 1, 2, 3};
            char[] mas1 = new char[] { 'A', 'B', 'C' };
            cBoxAmount.DataContext = mas;
            cBoxClass.DataContext = mas1;
            this.roomViewModel = roomViewModel;
           
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            roomViewModel.AmountOfPeople = (int)cBoxAmount.SelectedItem;
            roomViewModel.RoomClass = cBoxClass.SelectedItem.ToString();
            this.DialogResult = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
