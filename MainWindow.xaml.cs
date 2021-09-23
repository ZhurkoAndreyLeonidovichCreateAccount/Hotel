using Lab10.BusinessLayer.Interfaces;
using Lab10.BusinessLayer.Models;
using Lab10.BusinessLayer.Services;
using Lab10.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lab10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   //Флаг ограничения редактирования комнаты
        static public bool Flag = false;
        
        ObservableCollection<RoomViewModel> rooms;
        IRoomService roomService;
       static public IStatisticsService statisticsSevices;



        public MainWindow()
        {

            InitializeComponent();
            addRoom.IsEnabled = false;
            delRoom.IsEnabled = false;
           
            

            roomService = new RoomService("Lab11");
            statisticsSevices =new StatisticsSevices("Lab11");
            rooms = roomService.GetAll();
          
            cBoxRoom.DataContext = rooms;
           
           


        }

       
        //Добавить клиента
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                var clientViewModel = new ClientViewModel();

                var dialog = new EditClient(clientViewModel);
                var result = dialog.ShowDialog();
                if (result == true)
                {
                    var room = (RoomViewModel)cBoxRoom.SelectedItem;
                    room.clients.Add(clientViewModel);
                    roomService.AddClientToRoom(room.RoomID, clientViewModel);
                    dialog.Close();
                }
            
            
        }

        //Добавить комнату
        private void Button_Click_Room(object sender, RoutedEventArgs e)
        {
            RoomViewModel roomViewModel = new RoomViewModel();
           
            EditRoom dialog = new EditRoom(roomViewModel);
            var result = dialog.ShowDialog();
            if (result == true)
            {
                TimeSpan AmountOfDay = roomViewModel.CheckInDate.Subtract(DateTime.Now);
                if (AmountOfDay.Days > 14)
                {
                    MessageBox.Show("Нужно регистрироваться не ранее чем за две недели");
                    return;
                }
            

                    roomService.CreateRoom(roomViewModel);
            }
            rooms = roomService.GetAll();
            cBoxRoom.DataContext = rooms;
            cBoxRoom.SelectedIndex = 0;
        }

        //Удалить комнату
        private void Button_Click_Delete_Room(object sender, RoutedEventArgs e)
        {
            
                if (cBoxRoom.SelectedIndex < 0)
                return;
            MessageBoxResult p = (MessageBoxResult)MessageBox.Show("Вы действительно хотите удалить Комнату?", "Confirmation", MessageBoxButton.YesNo);
            if(p==MessageBoxResult.Yes)
            {
                

            roomService.DeleteRoom((cBoxRoom.SelectedItem as RoomViewModel).RoomID);
            rooms = roomService.GetAll();
            cBoxRoom.DataContext = rooms;
            cBoxRoom.SelectedIndex = 0;

            }

        }

        //Удалить клиента
        private void Button_Click_Delete_Client(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex < 0)
                return;
             MessageBoxResult p = (MessageBoxResult)MessageBox.Show("Вы действительно хотите удалить клиента?", "Confirmation", MessageBoxButton.YesNo);
            if (p == MessageBoxResult.Yes)
            {
                int si = cBoxRoom.SelectedIndex;
                RoomViewModel roomViewModel = cBoxRoom.SelectedItem as RoomViewModel;
                ClientViewModel clientViewModel = listBox.SelectedItem as ClientViewModel;
                roomService.RemoveClientFromRoom(roomViewModel.RoomID, clientViewModel.ClientID);
                rooms = roomService.GetAll();
                cBoxRoom.DataContext = rooms;
                cBoxRoom.SelectedIndex = si;
            }
            else
                return;

           
        }

        //Зарегистрироваться в комнате
        private void Button_Click_Update_Room(object sender, RoutedEventArgs e)
        {
            if (cBoxRoom.SelectedIndex < 0)
                return;
            RoomViewModel roomViewModel = cBoxRoom.SelectedItem as RoomViewModel;
            EditRoom dialog = new EditRoom(roomViewModel);
            var result = dialog.ShowDialog();
            if (result == true)
            {


                 TimeSpan AmountOfDay = roomViewModel.CheckInDate.Subtract(DateTime.Now);
                if (AmountOfDay.Days > 14)
                {
                    MessageBox.Show("Нужно регистрироваться не ранее чем за две недели");
                    return;
                }
                roomService.UpdateRoom(roomViewModel);
                rooms = roomService.GetAll();
               
                var room = (RoomViewModel)cBoxRoom.SelectedItem;
                totalSum.Text = room.TotalSum.ToString();
               // Запись в статистику
                StatisticsViewModel statistics = new StatisticsViewModel();
                statistics.CheckInDate = roomViewModel.CheckInDate;
                statistics.RoomNumber = roomViewModel.RoomNumber;
                statistics.CheckOutDate = roomViewModel.CheckOutDate;
                statistics.TotalSum = roomViewModel.TotalSum;
                statisticsSevices.CreateStatistic(statistics);
                int index = cBoxRoom.SelectedIndex;
                cBoxRoom.DataContext = rooms;
                cBoxRoom.SelectedIndex = index;
            }
        }

        //Отредактировать клиента

        private void Button_Click_Update_Client(object sender, RoutedEventArgs e)
        {
            
            if (listBox.SelectedIndex < 0)
                return;
            ClientViewModel clientViewModel = listBox.SelectedItem as ClientViewModel;
            var dialog = new EditClient(clientViewModel);
            var result = dialog.ShowDialog();
            if(result==true)
            {
                roomService.UpdateClient(clientViewModel);
                dialog.Close();
            }


        }

        //Зайти как Админ
        private void Button_Click_Like_Admin(object sender, RoutedEventArgs e)
        {

            PasswordWindow passwordWindow = new PasswordWindow();
            var result = passwordWindow.ShowDialog();
            if (result == true)
            {
                if (passwordWindow.Password == "12345678")
                {
                    Flag = true;
                    addRoom.IsEnabled = true;
                    delRoom.IsEnabled = true;
                    buttonUp.Content = "Отредактировать комнату";
                    MessageBox.Show("Вы прошли авторизацию");

                }
                else
                {
                    MessageBox.Show("Неверный пороль");
                    Flag = false;
                    addRoom.IsEnabled = false;
                    delRoom.IsEnabled = false;
                    buttonUp.Content = "Зарегистрировать в комнате";
                }

            }
           
        }

        // Поиск свободной комнаты
        private void Button_Click_Search(object sender, RoutedEventArgs e)
        {

           
            RoomViewModel roomViewModel = new RoomViewModel();
            var dialog = new SearchRoom(roomViewModel);
            var result = dialog.ShowDialog();
            if (result == true)
            {
               
                cBoxRoom.DataContext =roomService.Find(roomViewModel.AmountOfPeople, roomViewModel.RoomClass);
                cBoxRoom.SelectedIndex = 0;


            }

            
        }

        //Отмена поиска
        private void Button_Click_Search_Cansel(object sender, RoutedEventArgs e)
        {
            cBoxRoom.DataContext = rooms;

            cBoxRoom.SelectedIndex = 0;
        }

        // Поиск клиента
        private void Button_Click_Search_Client(object sender, RoutedEventArgs e)
        {
            ClientViewModel client = new ClientViewModel();

            var dialog = new SearchClient(client);
            var result = dialog.ShowDialog();
            if (result == true)
            {
                ObservableCollection<RoomViewModel> rooms1;
                ObservableCollection<RoomViewModel> rooms2 = new ObservableCollection<RoomViewModel>();
                for (int i = 0; i < rooms.Count; i++)
                {
                    for (int j = 0; j < rooms[i].clients.Count; j++)
                    {
                        if (rooms[i].clients[j].FullName.Contains(client.FullName))
                        {



                            rooms1 = roomService.FindClient(rooms[i].RoomID);
                            rooms2.Add(rooms1[0]);



                        }

                    }

                }
                cBoxRoom.DataContext = rooms2;
                cBoxRoom.SelectedIndex = 0;

            }
        }

        private void Report_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new StatisticsWindow();
            //dialog.dGrid.DataContext = rooms;
            var result = dialog.ShowDialog();

            //if (result == true)
            //{

            //}
        }
    }
    
}
