   M S B A M L   `   `   `  ����J  FTableTapManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:TableTapManagerTableTapManager  5   	       TableTapManager.CSV   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:TableTapManager     5   	     � Title$	  CSV��5   	   $	��450��6   $	��800��6"   .��5
      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   �� 5      6   �� 5      6   �� 5      $
��Auto �6   6,   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DgridBooking��5   4   $��2��6   $��3��6       AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$' !Дата бронирования��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6a   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6@   �� *Booking_date+6a     5      $) #Время бронирования��6%   $ * 6b   	 6A   �� *Booking_time+6b     5      $' !Количество гостей��6%   $ * 6e   	 6@   �� *Number_of_guests+6e     5      $ Статус��6%   $ * 6h   	 65   �� * Booking_status.Booking_status1+6h     5      $ Номер стола��6%   $ * 6a   	 6:   �� *Table.Table_number+6a     5      $ 
Логин��6%   $ * 6S   	 64   �� *
User.Login+6S   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   5!      �� 5$   
   -   5        $��1��5$      $��3��6!   $��Экспорт��6.   $
��Left=�6@   $	��Top=�6\   $	��120��6t   $��
107,42,0,0q�6�   �� 5%   
   -   5        $��
Назад��5%      $
��Left=�6!   $	��Top=�6<   $��75��6T   6_   5&      5'      