   M S B A M L   `   `   `  ����J  FTableTapManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:TableTapManagerTableTapManager  5   	       TableTapManager.Editing   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:TableTapManager     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Editing��5	   	   $	��450��6   $	��800��6&   .��5
      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DgridBooking��5      $��0��6)   $��3��69   $��2��6M      AutoGenerateColumns .     
IsReadOnly . $��
0,115,72,0q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$' !Дата бронирования��6&      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6b   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6A   �� *Booking_date+6o     5      $) #Время бронирования��6&   $ * 6c   	 6B   �� *Booking_time+6o     5      $' !Количество гостей��6&   $ * 6f   	 6A   �� *Number_of_guests+6r     5      $ Статус��6&   $ * 6i   	 66   �� * Booking_status.Booking_status1+6u     5      -   5        	Table��$ Номер стола��5   4   $ * 6p   	 6I   �� *Table.Table_number+6|     5      -   5        User��$ 
Логин��5   3   $ * 6a   	 6B   �� *
User.Login+6m   4  .System.Windows.Controls.DataGridTemplateColumn  5       $
 auto 6)   5!      5#      �� 5$   
   -   5        
 ��Name$
 Booking_date��5$   /   $��1��6   $��3��6   $��Center=�6E   $��32��6b    �� TextWrapping$
 Wrap=�6o   $"��Дата(дд.мм.гггг)��6�   $	��Top=�6�   $	��144��6�   �� 5%   
   -   5        $
 Booking_time��5%   /   $��1��6   $��3��6   $��Center=�6E   $��39��6b   $
 Wrap=�6o   $��
Время��6�   $	��Top=�6�   $	��143��6�   $��0,45,0,0q�6�   �� 5&   
   -   5        $
 Number_of_guests��5&   /   $��1��6   $��3��6   $��Center=�6I   $��41��6f   $
 Wrap=�6s   $'��!Количесвто гостей��6�   $	��Top=�6�   $	��143��6�   $��0,89,0,0q�6�   �� 5'   
   -   5         ��Name$ Id��5'   #   $��4��6   $��Center=�6/   $	��Top=�6M   $	��138��6e    �� DisplayMemberPath$ Booking_status1��6r    �� SelectedValuePath$ Id_Booking_status��6�   $��0,0,0,0q�6�   $��1��6�   $��32��6�   �� 5(   
   -   5        $	 Id2��5(   0   $��1��6   $��4��6    $��Center=�6=   $	��Top=�6[   $	��138��6s   $ Table_number��6�   $ Id_Table��6�   $��0,37,0,0q�6�   $��47��6�   �� 5)   
   -	   5        $	 Id3��5)   0   $��1��6   $��4��6    $��Center=�6=   $	��Top=�6[   $	��140��6s   $ Login��6   $ Id_User��6�   $��0,89,0,0q�6�   $��41��6�   �� 5+   
   -
   5        $��2��5+      $��4��6   $��Изменить��6.   $��Center=�6A   $	��Top=�6_   $	��123��6w   $��	0,10,35,0q�6�   $��60��6�   �� 5,   
   -   5        $��
Назад��5,      $
��Left=�6!   $	��Top=�6<   $��75��6T   6_   �� 5-   
   $��2��6   $��20(�6$   $#��Изменение брони��62   $��1��6L   $
��Left=�6\   $��	88,46,0,0q�6w   $	��Top=�6�   5.      5/      