   M S B A M L   `   `   `  ����>  :TNN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:TNN.Pages.MainWindow.AddPagesTNN.Pages.MainWindow.AddPages  5      /    )TNN.Pages.MainWindow.AddPages.TaskGridAdd   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:TNN.Pages.MainWindow.AddPages     5        N� Title$  TaskGridAdd��5	      .��5      � $��0,0,0,0q�6   .+�5   
   � 
�������$��0,10,0,0q�6!   .+�5      �� -   5         ��Name$
 Back��5      $��Отмена��6#   $��25��64   $��50��6@   $	��Top=�6K   $
��Left=�6c   $��5,5,0,0q�6~   6�   �� 5      $��0,35,0,0q�6   .+�5      �� $��Название��6   $��	10,10,0,0q�6+   $��24��6>   �� 5      $��
Текст��6   $��	10,10,0,0q�6(   $��24��6;   �� 5      $��Вложение��6   $��	10,10,0,0q�6+   $��24��6>   �� 5      $0��*Ссылка на документацию��6   $��	10,10,0,0q�69   $��24��6L   �� 5      $#��Дата завершения��6   $��	10,10,0,0q�62   $��24��6E   �� 5      $��Проект��6   $��	10,10,0,0q�6)   $��24��6<   �� 5      $��Заказчик��6   $��	10,10,0,0q�6+   $��24��6>   �� 5      $��Исполнитель��6   $��	10,10,0,0q�6.   $��24��6A   �� 5      $'��!Причина изменений��6   $��	10,10,0,0q�64   $��24��6G   5      �� 5       �� Orientation$ Vertical=�6   $��
180,35,0,0q�60   .+�5      �� -   5         ��Name$
 Name��5      $
��Left=�6(   $��24��6C   $��	10,10,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6x   $	��185��6�   �� 5      -   5        $
 Text��5      $
��Left=�6(   $��24��6C   $��	10,10,0,0q�6P   $
 Wrap=�6d   $	��Top=�6y   $	��185��6�   �� 5      -   5        $ 
Attachment��5      $
��Left=�6.   $��24��6I   $��	10,10,0,0q�6V   $
 Wrap=�6j   $	��Top=�6   $	��185��6�   �� 5       -   5        $ Link_On_Documentation��5       $
��Left=�69   $��24��6T   $��	10,10,0,0q�6a   $
 Wrap=�6u   $	��Top=�6�   $	��185��6�   (  "System.Windows.Controls.DatePicker  5!      -   5          Name$ Date_completion��5!      $
��Left=�66   
���   �
�������$��24��6}   $��	10,10,0,0q�6�   $��Center=�6�   $	��Top=�6�   $	��185��6�   �� 5#      -   5         ��Name$ Project_info��5#       �� SelectedValuePath$ ID��6I    �� DisplayMemberPath$
 Name��6`   $
��Left=�6y   
���   �
�������$��24��6�   $��	10,10,0,0q�6�   $��Center=�6�   $	��Top=�6  $	��185��6  ��61   �� 6  �� 5$      -   5        $ Customer_ID��5$      $ ID��6H   $
 Name��6_   $
��Left=�6x   
���   �
�������$��24��6�   $��	10,10,0,0q�6�   $��Center=�6�   $	��Top=�6  $	��185��6  ��60   �� 6  �� 5%      -	   5        $ Performer_ID��5%      $ ID��6I   $
 Name��6`   $
��Left=�6y   
���   �
�������$��24��6�   $��	10,10,0,0q�6�   $��Center=�6�   $	��Top=�6  $	��185��6  ��61   �� 6  �� 5&      -
   5        $ 	CauseCode��5&      $ ID��6F   $
 Name��6]   $
��Left=�6v   
���   �
�������$��24��6�   $��	10,10,0,0q�6�   $��Center=�6�   $	��Top=�6   $	��185��6  ��6.   �� 6  5'      �� 5(      -   5        $
 Save��5(      $��Сохранить��6#   $
��Left=�67   $��60,5,0,0q�6S   $	��Top=�6e   $��75��6}   $��25��6�   5)      5*      5+      