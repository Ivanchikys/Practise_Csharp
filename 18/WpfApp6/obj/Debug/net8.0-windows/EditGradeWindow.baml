   M S B A M L   `   `   `  ����  WpfApp6$    TeacherJournal.EditGradeWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$-  'Редактировать запись��5   	   $	��250��6&   $	��350��63    � WindowStartupLocation$ CenterOwner=�5   	    � 
ResizeMode$ NoResize=�6-   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��ФИО студента:��6!   $��0,0,0,5q�66   �� 5   
   $��1��6   $��0,0,0,10q�6^   ��6   �� *
FullName+ �� UpdateSourceTrigger$ PropertyChanged=�6^   �� 5   
   $��2��6   $��Оценка (0-10):��6!   $��0,0,0,5q�67   �� 5   
   -   5        $��3��5      $��0,0,0,10q�5      ��5      �� *Grade+$ PropertyChanged=�5   $   �� 5   
   $��4��6   $��Комментарий:��6!   $��0,0,0,5q�65   �� 5   
   $��5��6   $��0,0,0,10q�5       �� AcceptsReturn$
 True��6$   $��40��69   ��5      �� *	Comment+$ PropertyChanged=�5   9   �� 5   
   $��6��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   .+�5      �� $ ��Присутствовал��6   $��0,0,10,0q�6O   $��Center=�6a    d� 	IsChecked 6/   �� *	IsPresent+6a   �� 5      -   5        $
��ОК��5      $��75��6"   $��0,0,10,0q�6-   6?   �� 5      -   5        $��Отмена��5      $��75��6&   61   5       5!      5"      