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
    /// Логика взаимодействия для EditApplication.xaml
    /// </summary>
    public partial class EditRoom : Window
    {
        RoomViewModel roomViewModel;
        public EditRoom(RoomViewModel roomViewModel)
        {
            InitializeComponent();
           
            if (!MainWindow.Flag)
            {
                roomNumber.IsEnabled = false;
                amountOfPeople.IsEnabled = false;
                roomCost.IsEnabled = false;
                roomClass.IsEnabled = false;
            }
            this.roomViewModel = roomViewModel;
            grid.DataContext = roomViewModel;
           
        }

        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
