   M S B A M L   `   `   `  ����>  :TNN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:TNN.Pages.MainWindow.DataGridPages"TNN.Pages.MainWindow.DataGridPages  5      8    2TNN.Pages.MainWindow.DataGridPages.MyRemarkSetPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:TNN.Pages.MainWindow.DataGridPages     5        N� Title$  MyRemarkSetPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $	��20* �6   �� 5      $��30 �6   .+�5   
   � $��0��6   ���#b8b8b8.+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��10,0,0,0q�6   $��Правка��6+   $��30��6<   �� 5      -   5         ��Name$	 Add��5      $��10,0,0,0q�6&   $��Добавить��68   $��30��6K   �� 5      -   5        $��10,0,0,0q�5      $��Обновить��6+   $��30��6>   6J   �� 5      -   5        $ ResetSettings��5      $��10,0,0,0q�60   $)��#Сбросить настройки��6B   $��30��6_   6k   5      �� 5      $��Bottom=�6   $��Stretch=�63   
�������$��3��6]   5      � 5   
   ���#b8b8b8$��1��6$   .+�5      �� $ Vertical=�6   $��0,6,0,0q�60   5!      �� 5"      $��Bottom=�6   $��Stretch=�63   
�������$��3��6]   5#      � 5%   
   ���#b8b8b8$��2��6$   .+�5&      �� $ 
Horizontal=�6   .+�5'      �� $��Поиск:��6   $��Center=�6)   $��5,0,0,0q�6E   �� 5(      -   5         ��Name$ Search��5(      $
��Left=�6+   $��20��6F    �� TextWrapping$
 Wrap=�6R   $��Center=�6f   $	��250��6�   $��0,0,0,0q�6�   6�   5*      �� 5+      $��Bottom=�6   $��Stretch=�63   
�������$��3��6]   5,      � 5-   
   $��3��6   .+�5.      &   System.Windows.Controls.DataGrid  -   5          Name$ AllRemarkSet��5.      $��Right=�6-      AutoGenerateColumns .     
IsReadOnly . 	   Columns	 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Наименование��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 50* 6[   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *	Comment+6[     51      $2
 ,Время подготовки ответа��6)   $	 50* 6x    6J   �� *Time_preparing_responses+6x     52      $-
 'Количество замечаний��6)   $	 50* 6i    6G   �� *Count_remarks+6i     53      $%
 Статус комплекта��6)   $	 50* 6h    6C   �� *Kit_status.Name+6h   56      57      � 5:   
   ���#b8b8b8$��4��6$   .+�5;      �� $	��Top=�6   $��Stretch=�60   
�������$��3��6Z   �� 5<      $ 
Horizontal=�6   .+�5=      �� $
��Left=�6   $��Страница��63   $��Center=�6F   �� 5>      -   5         ��Name$ CurrentPageNum��5>      $��Center=�60   �� 5?      $��Right=�6   $��Страницы��64   $��Center=�6G   �� 5@      -   5        $ 
AllPaheNum��5@      $��Center=�6,   �� 5A      -   5        $ CountElements��5A      $��Center=�6/   5B      5C      5D      5E      