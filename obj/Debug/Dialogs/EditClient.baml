   M S B A M L   `   `   `  ����@  <Lab10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Lab10.DialogsLab10.Dialogs  5   	       Lab10.Dialogs.EditClient   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Lab10.Dialogs     5   	     � Title$  
EditClient��5      $	��450��6   $	��800��6+   $��Lucida Bright)�67   $��22(�6R   .��5	      � -   5         �Name$
 grid��5	       � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��	Ф.И.О.��6   $��0��6!   �� 5   
   -   5         ��Name$ textBoxName��5      $��25 15q�6'   $��0��5      $��1��6   ��5      ��  �� Path$ FullName�5      �� 5   
   $��Дата рождения��6   $��1��6(   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpclient��5      $��1��6'   $��25 15q�64   $��1��5         SelectedDate 5      �� $ DateOfBirth�5      �� 5   
   $��Возраст��6   $��2��6"   �� 5   
   -   5        $ textAge��5      $��25 15q�6#   $��2��5!      $��1��6   ��5       �� $	 Age�5!      �� 5"   
   $!��Номер телефона��6   $��3��6)   �� 5#   
   -   5        $ textBoxPhoneNumber��5#      $��25 15q�6/   $��3��5%      $��1��6   ��5$      �� $ PhoneNumber�5%      �� 5(   
   $%��Файл изображения��6   $��4��6+   �� 5)   
   -   5        $ textFileName��5)      $��25 15q�6(   $��4��5+      $��1��6   ��5*      �� $ FileName�5+      �� 5-   
   -   5         ��Name$ ButtonOK��5-      $��OK��6#   $��5��60   $��0��6=   $��25 15q�6M   6\   �� 5.   
   -   5        $ ButtonCancel��5.      $��Cancel��6'   $��5��68   $��1��6E   $��25 15q�6U   6d   50      52      