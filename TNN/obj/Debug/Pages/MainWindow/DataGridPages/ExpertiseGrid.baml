   M S B A M L   `   `   `  ����>  :TNN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:TNN.Pages.MainWindow.DataGridPages"TNN.Pages.MainWindow.DataGridPages  5      6    0TNN.Pages.MainWindow.DataGridPages.ExpertiseGrid   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:TNN.Pages.MainWindow.DataGridPages     5        N� Title$  ExpertiseGrid��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $	��20* �6   �� 5      $��30 �6   .+�5   
   � $��0��6   ���#b8b8b8.+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ Refresh��5      $��10,0,0,0q�6*   $��Обновить��6<   $��30��6O   6[   �� 5      -   5        $ ResetSettings��5      $��10,0,0,0q�60   $)��#Сбросить настройки��6B   $��30��6_   6k   5      �� 5      $��Bottom=�6   $��Stretch=�63   
�������$��3��6]   5      � 5   
   ���#b8b8b8$��1��6$   .+�5      �� $ Vertical=�6   $��0,6,0,0q�60   5       �� 5!      $��Bottom=�6   $��Stretch=�63   
�������$��3��6]   5"      � 5$   
   ���#b8b8b8$��2��6$   .+�5%      �� $ 
Horizontal=�6   .+�5&      �� $��Поиск:��6   $��Center=�6)   $��5,0,0,0q�6E   �� 5'      -   5         ��Name$ Search��5'      $
��Left=�6+   $��20��6F    �� TextWrapping$
 Wrap=�6R   $��Center=�6f   $	��250��6�   $��0,0,0,0q�6�   6�   5(      �� 5)      $��Bottom=�6   $��Stretch=�63   
�������$��3��6]   5*      � 5,   
   $��3��6   .+�5-      &   System.Windows.Controls.DataGrid  -   5          Name$ 	Expertise��5-      $��Right=�6*      AutoGenerateColumns .     
IsReadOnly . 	   Columns	 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Название��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 50* 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Name+6T     50      $
 Описание��6)   $	 50* 6T    6;   �� *Info+6T   52      53      � 56   
   ���#b8b8b8$��4��6$   .+�57      �� $	��Top=�6   $��Stretch=�60   
�������$��3��6Z   �� 58      $ 
Horizontal=�6   .+�59      �� $
��Left=�6   $��Страница��63   $��Center=�6F   �� 5:      -   5         ��Name$ CurrentPageNum��5:      $��Center=�60   �� 5;      $��Right=�6   $��Страницы��64   $��Center=�6G   �� 5<      -   5        $ 
AllPaheNum��5<      $��Center=�6,   �� 5=      -   5        $ CountElements��5=      $��Center=�6/   5>      5?      5@      5A      