using Lab10.BusinessLayer.Models;
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
using System.Windows.Shapes;

namespace Lab10.Dialogs
{
    /// <summary>
    /// Логика взаимодействия для StatisticsWindow.xaml
    /// </summary>
    public partial class StatisticsWindow : Window
    {
        ObservableCollection<StatisticsViewModel> Statistics;
        ObservableCollection<StatisticsViewModel> Statistics1;
        ObservableCollection<StatisticsViewModel> Statistics2;
        public StatisticsWindow()
        {
            InitializeComponent();
            Statistics = MainWindow.statisticsSevices.GetAll();
          
           

           
        }
        
        private void Accept_Click(object sender, RoutedEventArgs e)
        {

            Statistics1 = new ObservableCollection<StatisticsViewModel>();
            Statistics2 = new ObservableCollection<StatisticsViewModel>();
            try
            {
                foreach (var item in Statistics)
                {

                    if (item.CheckOutDate.Value.Year == int.Parse(textBoxYear.Text))

                        Statistics1.Add(item);





                }

                var groups = Statistics1.GroupBy(p => p.RoomNumber);
               
                foreach (IGrouping<int, StatisticsViewModel> g in groups)
                {
                    StatisticsViewModel statisticsViewModel = new StatisticsViewModel();
                    decimal TotalSum = 0;
                    foreach (var item in g)
                    {

                        TotalSum += item.TotalSum;

                        statisticsViewModel.RoomNumber = item.RoomNumber;
                        statisticsViewModel.TotalSum = TotalSum;

                    }
                    Statistics2.Add(statisticsViewModel);
                }
                listBoxStatistics.DataContext = Statistics2;
            }
            catch (Exception ex)
            {
                listBoxStatistics = null;
            }

            if (listBoxStatistics!=null)
            {
                decimal TotalSum=0;
                foreach (var item in Statistics2)
                {
                    TotalSum += item.TotalSum;
                }
                textBlockTotal.Text = TotalSum.ToString();
            }

        }

        

        private void Сansel_Click(object sender, RoutedEventArgs e)
        {
            listBoxStatistics.DataContext = null;
        }
    }
}
