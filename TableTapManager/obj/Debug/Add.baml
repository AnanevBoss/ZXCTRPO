   M S B A M L   `   `   `  ����J  FTableTapManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:TableTapManagerTableTapManager  5   	       TableTapManager.Add   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:TableTapManager     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$	  Add��5	   	   $	��450��6   $	��800��6"   .��5
      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� -   5         ��Name$ Booking_date��5   /   $��2��6   $��1��6"   $
��Left=�6E   $��23��6`    �� TextWrapping$
 Wrap=�6m   $"��Дата(дд.мм.гггг)��6�   $	��Top=�6�   $	��120��6�   $��0,2,0,0q�6�   �� 5   
   -   5        $ Booking_time��5   /   $��2��6   $��1��6"   $
��Left=�6E   $��23��6`   $
 Wrap=�6m   $��
Время��6�   $	��Top=�6�   $	��120��6�   $��0,38,0,0q�6�   �� 5   
   -   5        $ Number_of_guests��5   /   $��2��6   $��1��6"   $
��Left=�6I   $��24��6d   $
 Wrap=�6q   $'��!Количесвто гостей��6�   $	��Top=�6�   $	��120��6�   $��0,80,0,0q�6�   �� 5   
   -   5        $��2��5      $��2��6!   $��Добавить��6.   $
��Left=�6A   $	��Top=�6]   $	��192��6u   $��	40,15,0,0q�6�   $��2��6�   $��90��6�   �� 5   
   -   5        $��
Назад��5      $
��Left=�6!   $	��Top=�6<   $��75��6T   6_   �� 5   
   -   5         ��Name$ Id��5   #   $��2��6   $
��Left=�6/   $	��Top=�6J   $	��120��6b    �� DisplayMemberPath$ Booking_status1��6o    �� SelectedValuePath$ Id_Booking_status��6�   $��	130,0,0,0q�6�   $��2��6�   $��1��6�   �� 5   
   -   5        $	 Id2��5       $��1��6   $
��Left=�6-   $	��Top=�6H   $	��120��6`   $ Table_number��6m   $ Id_Table��6�   $��
130,36,0,0q�6�   $��2��6�   $��2��6�   �� 5   
   -   5        $	 Id3��5   0   $��2��6   $��1��6#   $
��Left=�6=   $	��Top=�6X   $	��120��6p   $ Login��6|   $ Id_User��6�   $��
130,80,0,0q�6�   $��2��6�   �� 5    
   $��2��6   $��20(�6$   $%��Добавление брони��62   $��2��6M   $
��Left=�6]   $��	10,18,0,0q�6x   $	��Top=�6�   5"      5#      