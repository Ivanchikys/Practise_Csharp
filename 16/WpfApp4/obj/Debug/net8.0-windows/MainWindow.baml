   M S B A M L   `   `   `  ����  WpfApp4    TeacherJournal.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$)  #Электронный журнал��5   	   $	��600��6$   $	��800��61    � 	Resources 5         	BoolToVis��%   &	        �� 5   
   6'   5      .��5	      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   o� $��0��6   .@�5      m� $��Файл��6   m� 5      $��Студенты��6   m� 5      $��Оценки��6   m� 5      $��Настройки��6   5      �� 5   
   $��1��6   $)��#Электронный журнал��5      $��20(�5      $
��Bold"�6"   $��Center=�5      $��0,0,0,10q�5      �� 5!   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��0,0,0,10q�6;   .+�5"      �� $��Предмет:��6   $��Center=�6(   $��0,0,10,0q�6C   �� 5#      $	��200��6    �� DisplayMemberPath$ 
CourseName��5%      ��5$      �� *	Courses+ �� SelectedItem 5&      �� *SelectedCourse+5'      � 5)   
   $��3��6   $��20��6#    � IsIndeterminate$
 True��6/   $��0,0,0,10q�6F   y�5*      �� *	IsLoading+ �� 	Converter# [  &   System.Windows.Controls.DataGrid  5,   
   $��4��6      CanUserAddRows$ False��6    	   AutoGenerateColumns$	 False��5-      $��0,0,0,10q�5.      ��5/      �� *StudentGrades+ 50      �� *SelectedGrade+
   Columns
 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО студента��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *
FullName+6X     53      $ Оценка��6%   $ 75 6O    65   �� *Grade+6O     54      $ Комментарий��6%   $ * 6V    6:   �� *	Comment+6V   4  .System.Windows.Controls.DataGridTemplateColumn  55      $ Присутствие��6)      CellTemplate 56      �� 57      .R�58      �� $��Center=�6T    d� 	IsChecked 6'   �� *	IsPresent+ �� Mode$ TwoWay=�6T   59      5;        5<      $ Средний балл��6%      
IsReadOnly$
 True��6W   $	 100 6i    6;   �� *	Average+6i   5>      �� 5@   
   $��5��6   $ 
Horizontal=�6"   $��Right=�6;   $��0,10,0,0q�6W   .+�5A      �� $#��Добавить оценку��6   $	��120��6/   $��5q�6;   ��6F   �� *AddGradeCommand+�� 5B      $ ��Редактировать��6   $	��120��6-   $��5q�69   ��6D   �� *EditGradeCommand+�� 5C      $!��Удалить оценку��6   $	��120��6.   $��5q�6:   ��6E   �� *DeleteGradeCommand+�� 5D      $	��150��6   $��30��6!   $��10q�6-   $��Экспорт в Excel��69   ��5E      �� 5F       �� 
TargetType" ��6&   .R�5G      �� $ 
Horizontal=�6%   .+�5H      �� $��/Assets/excel.png��6$   $��16��6?   $��16��6J   $��5q�6V   �� 5I      $��Center=�6/   5J      5K      5M      5N      5O      5P      