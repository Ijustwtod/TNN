   M S B A M L   `   `   `  ����>  :TNN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:TNN.Pages.MainWindow.DataGridPages"TNN.Pages.MainWindow.DataGridPages  5      9    3TNN.Pages.MainWindow.DataGridPages.AllRemarkSetPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:TNN.Pages.MainWindow.DataGridPages     5        N� Title$  AllRemarkSetPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $	��17* �6   .+�5   
   � ���#b8b8b8.+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Поиск:��6   $��Center=�6)   $��20,0,0,0q�6E   �� 5      -   5         ��Name$ Search��5      $
��Left=�6+   $��20��6F    �� TextWrapping$
 Wrap=�6R   $��Center=�6f   $	��150��6�   $��0,0,0,0q�6�   6�   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ AllRemarkSet��5      $��Right=�6)      AutoGenerateColumns .     
IsReadOnly . $��1��6t      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Наименование��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 50* 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *	Comment+6W     5      $2	 ,Время подготовки ответа��6%   $
 50 6t    6F   �� *Time_preparing_responses+6t     5      $-	 'Количество замечаний��6%   $	
 50* 6e    6C   �� *Count_remarks+6e     5      $%	 Статус комплекта��6%   $	
 25* 6d    6?   �� *Kit_status.Name+6d   5!      5"      5#      