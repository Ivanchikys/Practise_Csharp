   M S B A M L   `   `   `  ����B  >WpfApp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TeacherJournalTeacherJournal  5   	       TeacherJournal.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   7teacherJournalclr-namespace:TeacherJournal     5   	   -   5          � Title$)  #Электронный журнал��5   	   $	��600��6$   $	��800��61    � 	Resources 5         	BoolToVis  FadeInAnimation �� TargetProperty W� From	 W� To g� Duration&    TeacherJournal.LessThanConverter  LessThanConverter��%�   &	        &	      &	 u     �� 5   
   6'   �� 5	   
   .��5
      W� $ Opacity�6    06B    16K   $ 0:0:1D�6R   5        5   
   6+   5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   o� $��0��6   .@�5      m� $��Файл��6   m� 5      $��Студенты��6   .@�5      m� $��Открыть чат��6    m� Command 60   �� *OpenChatCommand+5      m� 5      $��Оценки��6   m� 5       $��Настройки��6   5!      �� 5#   
   $��1��6   $)��#Электронный журнал��5$      $��20(�5%      $
��Bold"�6"   $��Center=�5&      $��0,0,0,10q�5'      �� 5)   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��0,0,0,10q�6;   .+�5*      �� $��Предмет:��6   $��Center=�6(   $��0,0,10,0q�6C   �� 5+      $	��200��6   	 �� DisplayMemberPath$	 
CourseName��5-      ��5,      �� *	Courses+
 �� SelectedItem
 5.      �� *SelectedCourse+5/      � 51   
   $��3��6   $��20��6#    � IsIndeterminate$
 True��6/   $��0,0,0,10q�6F   y�52      �� *	IsLoading+ �� 	Converter# [  &   System.Windows.Controls.DataGrid  54   
   -   5        $��4��54         CanUserAddRows$ False��6       AutoGenerateColumns$ False��55      $��0,0,0,10q�56         
IsReadOnly$
 True��5:      ��57      �� *Enrollments+
 58      �� *SelectedEnrollment+��5;      �� 5<       �� 
TargetType"  6   .�5=      ��  �� Property �@J�Opacity �� Value$ 0Q�60    �� Triggers 5>      �� 5?       �� Binding 6&   �� *	IsLoading+ �� Value	 False6D    N� EnterActions 5@      �� 5A   "   #��[ 62   5C      5E       5G      )  #System.Windows.Controls.DataGridRow �� ConverterParameter	 �� To g� AutoReverse g� RepeatBehavior��%�  '        7  �� 5H      "  6   .�5I      ��  � ��
 ���� 63    5J      �� 5K       6&   �� *Grades[0].Average+8   $ 3�� True6�    5L      �� 5M   "   .��5N   &   �� .��5O   *   �� $* $(Background).(SolidColorBrush.Color)�5P   -    Red5Q   -   $ 0:0:0.5D�5R   -   $
 True��5S   -   $ Forever��5T   -   5U   '   5V   #   5X      5Z      5[         Columns 5\      0  *System.Windows.Controls.DataGridTextColumn  5]      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО студента��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Student.FullName+6`     5^      $ Оценка��6%   $ 75 6Y    65   �� *Grades[0].Grade+6Y     5_      $ Комментарий��6%   $ * 6`    6:   �� *Grades[0].Comment+6`   4  .System.Windows.Controls.DataGridTemplateColumn  5`      $ Присутствие��6)      CellTemplate 5a      �� 5b      .R�5c      �� $��Center=�6^     d� 	IsChecked  6'   �� *Grades[0].IsPresent+! �� Mode$! OneWay=�6^   5d      5f        5g      $ Средний балл��6%   "   
IsReadOnly$
" True��6a   $	 100 6s    6;   �� *Grades[0].Average+6s   5i      �� 5k   
   $��5��6   $ 
Horizontal=�6"   $��Stretch=�6;   $��0,10,0,0q�6Y   $��Center=�5l      .+�5m      �� $ Vertical=�6   $	��300��60   .+�5n      �� $��30��5p      $��0,0,0,5q�6&   # � ToolTip$7# 1Введите домашнее задание...��5q      ��5n      �� *HomeworkText+$ �� UpdateSourceTrigger$$ PropertyChanged=�$! TwoWay=�y�5o      �� *	IsTeacher+# [  5q      �� 5r      
��� d �$
��Bold"�5s   3   ��5r      �� *HomeworkNotification+5s   3   5t      �� 5v      $��Отправить ДЗ��6   $	��120��6,   $��30��68   $
��10,0q�6D   ��5w      �� *SendHomeworkCommand+y�5x      �� *	IsTeacher+# [  5y      �� 5{   
   $��6��6   $ 
Horizontal=�6"   $��Right=�6;   $��0,10,0,0q�6W   .+�5|      �� $#��Добавить оценку��6   $	��120��6/   $��5q�6;   ���	#FF6DA5FF��6F   �� *AddGradeCommand+y�5}      �� *	IsTeacher+# [  5~      �� 5      $ ��Редактировать��6   $	��120��6-   $��5q�69   ���	#FF6DA5FF��6D   �� *EditGradeCommand+y�5�      �� *	IsTeacher+# [  5�      �� 5�      $!��Удалить оценку��6   $	��120��6.   $��5q�6:   ���	#FFEA3D55��6E   �� *DeleteGradeCommand+y�5�      �� *	IsTeacher+# [  5�      �� 5�      $	��150��6   $��30��6!   $��10q�6-   $��Экспорт в Excel��69   y�5�      �� *	IsTeacher+# [  ��5�      �� 5�      % �� 
TargetType"% ��6&   .R�5�      �� $ 
Horizontal=�6%   .+�5�      �� $��/Assets/excel.png��6$   $��16��6?   $��16��6J   $��5q�6V   �� 5�      $��Center=�6/   5�      5�      5�      5�      5�      5�      