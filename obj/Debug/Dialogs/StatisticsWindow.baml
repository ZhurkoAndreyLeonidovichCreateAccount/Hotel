   M S B A M L   `   `   `  ����@  <Lab10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Lab10.DialogsLab10.Dialogs  5   	   $    Lab10.Dialogs.StatisticsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Lab10.Dialogs     5   	     � Title$  StatisticsWindow��5   	   $	��350��6"   $	��500��6/   .��5
      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��1.5* �6   �� 5      $��4* �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Center=�6   $��Center=�61   $��30(�6L   $��2��6Z    Статисика за год6�   �� 5   
   $��1��6   $��17(�6!   .,Введите год в формате ####6K   � 5   
   $��1��6   $��1��6    5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ textBoxYear��5      $��50��6'   �� 5!      $��1��6   .+�5#      �� -   5        $��60��5#   +   $��5q�69   .��6D   OK6H   �� 5$      -   5        $��60��5$   /   $��5q�6=   .��6H   Отмена6P   5&      5)      �� 5*   
   $��Center=�6   $��3��61   $��Center=�6>   $��20(�6Y   Общая сумма6v   �� 5+   
   -   5         ��Name$ textBlockTotal��5+      $��Center=�6,   $��20(�6I   $��3��6W   $��1��6d   �� 5,   
   -   5         ��Name$ listBoxStatistics��5,      $��10q�6-   $��2��69   $��2��6F   ��6Z   �� ��50      �� 51      .R�52      � $��10q�6    53      �� 54      $
��auto �6/   �� 55      $��* �6/   .+�58      �� $��1��6%   .+�59      �� $��30,0,0,0q�6J   ��6(   ��  �� Path$ 
RoomNumber�6J   �� 5:      $��30,0,0,0q�5<   &   ��5:   (   �� $ TotalSum� �� StringFormat$( " Сумма за год {0} руб��5<   &   5@      5A      5B      5D      5H      5I      