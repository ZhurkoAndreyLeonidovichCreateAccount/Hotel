   M S B A M L   `   `   `  ����@  <Lab10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Lab10.DialogsLab10.Dialogs  5   	       Lab10.Dialogs.EditRoom   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Lab10.Dialogs     5   	     � Title$F  @Добавление/Редактирование комнаты��5   
   $	��450��64   $	��800��6A   $��Lucida Bright)�6M   $��22(�6h   .��5	      � -   5         �Name$
 grid��5	       � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Номер комнаты��6   $��0��6(   �� 5   
   -   5         ��Name$ 
roomNumber��5      $��0��6&   $��1��63   ��6D   ��  �� Path$ 
RoomNumber��� 5   
   $)��#Количество человек��6   $��1��6-   �� 5   
   -   5        $ amountOfPeople��5      $��1��6*   $��1��67   ��6H   �� $ AmountOfPeople��� 5   
   $'��!Стоимость комнаты��6   $��2��6,   �� 5   
   -   5        $ roomCost��5      $��2��6%   $��1��62   ��6C   �� $ RoomCost��� 5!   
   $��Класс комнаты��6   $��3��6(   �� 5"   
   -   5        $ 	roomClass��5"      $��3��6%   $��1��62   ��6C   �� $ 	RoomClass��� 5$   
   $0��*Дата начала проживания��6   $��4��61   (  "System.Windows.Controls.DatePicker  5%   
   $��4��6   $��25 15q�6"   $��1��5'         SelectedDate 5&      �� $ CheckInDate�5'      �� 5(   
   $3��-Дата выезда из гостиницы��6   $��5��63     5)   
   $��5��6   $��25 15q�6"   $��1��5+       5*      �� $ CheckOutDate�5+      �� 5,   
   -   5         ��Name$ ButtonOK��5,      $��OK��6#   $��6��60   $��0��6=   $��25 15q�6M   6\   �� 5-   
   -   5        $ ButtonCancel��5-      $��Cancel��6'   $��6��68   $��1��6E   $��25 15q�6U   6d   5/      51      