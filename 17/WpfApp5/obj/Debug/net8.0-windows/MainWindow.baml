   M S B A M L   `   `   `  ����  WpfApp5    TeacherJournal.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$)  #Электронный журнал��5   	   $	��600��6$   $	��800��61    � 	Resources 5         	BoolToVis��%   &	        �� 5   
   6'   5	      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   o� $��0��6   .@�5      m� $��Файл��6   m� 5      $��Студенты��6   .@�5      m� $��Открыть чат��6    m� Command 60   �� *OpenChatCommand+5      m� 5      $��Оценки��6   m� 5      $��Настройки��6   5      �� 5   
   $��1��6   $)��#Электронный журнал��5       $��20(�5!      $
��Bold"�6"   $��Center=�5"      $��0,0,0,10q�5#      �� 5%   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��0,0,0,10q�6;   .+�5&      �� $��Предмет:��6   $��Center=�6(   $��0,0,10,0q�6C   �� 5'      $	��200��6    �� DisplayMemberPath$ 
CourseName��5)      ��5(      �� *	Courses+ �� SelectedItem 5*      �� *SelectedCourse+5+      � 5-   
   $��3��6   $��20��6#    � IsIndeterminate$
 True��6/   $��0,0,0,10q�6F   y�5.      �� *	IsLoading+ �� 	Converter# [  &   System.Windows.Controls.DataGrid  50   
   -   5        $��4��50      	   CanUserAddRows$	 False��6    
   AutoGenerateColumns$
 False��51      $��0,0,0,10q�52         
IsReadOnly$
 True��55      ��53      �� *StudentGrades+ 54      �� *SelectedGrade+   Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО студента��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *
FullName+6X     59      $ Оценка��6%   $ 75 6O    65   �� *Grade+6O     5:      $ Комментарий��6%   $ * 6V    6:   �� *	Comment+6V   4  .System.Windows.Controls.DataGridTemplateColumn  5;      $ Присутствие��6)      CellTemplate 5<      �� 5=      .R�5>      �� $��Center=�6T    d� 	IsChecked 6'   �� *	IsPresent+ �� Mode$ TwoWay=�6T   5?      5A        5B      $ Средний балл��6%      
IsReadOnly$
 True��6W   $	 100 6i    6;   �� *	Average+6i   5D      �� 5F   
   $��5��6   $ 
Horizontal=�6"   $��Stretch=�6;   $��0,10,0,0q�6Y   $��Center=�5G      .+�5H      �� $ Vertical=�6   $	��300��60   .+�5I      �� $��30��5K      $��0,0,0,5q�6&    � ToolTip$7 1Введите домашнее задание...��5L      ��5I      �� *HomeworkText+ �� UpdateSourceTrigger$ PropertyChanged=�$ TwoWay=�y�5J      �� *DataContext.IsTeacher+ �� RelativeSource ��  �� AncestorType
 Window# [  5L      �� 5M      
��� d �$
��Bold"�5N   3   ��5M      �� *HomeworkNotification+5N   3   5O      �� 5Q      $��Отправить ДЗ��6   $	��120��6,   $��30��68   $
��10,0q�6D   ��5R      �� *SendHomeworkCommand+y�5S      �� *DataContext.IsTeacher+ �� 
 Window# [  5T      �� 5V   
   $��6��6   $ 
Horizontal=�6"   $��Right=�6;   $��0,10,0,0q�6W   .+�5W      �� $#��Добавить оценку��6   $	��120��6/   $��5q�6;   ���	#FF6DA5FF��6F   �� *AddGradeCommand+y�5X      �� *DataContext.IsTeacher+ �� 
 Window# [  5Y      �� 5Z      $ ��Редактировать��6   $	��120��6-   $��5q�69   ���	#FF6DA5FF��6D   �� *EditGradeCommand+y�5[      �� *DataContext.IsTeacher+ �� 
 Window# [  5\      �� 5]      $!��Удалить оценку��6   $	��120��6.   $��5q�6:   ���	#FFEA3D55��6E   �� *DeleteGradeCommand+y�5^      �� *DataContext.IsTeacher+ �� 
 Window# [  5_      �� 5`      $	��150��6   $��30��6!   $��10q�6-   $��Экспорт в Excel��69   y�5a      �� *DataContext.IsTeacher+ �� 
 Window# [  ��5b      �� 5c       �� 
TargetType" ��6&   .R�5d      �� $ 
Horizontal=�6%   .+�5e      �� $��/Assets/excel.png��6$   $��16��6?   $��16��6J   $��5q�6V   �� 5f      $��Center=�6/   5g      5h      5j      5k      5l      5m      