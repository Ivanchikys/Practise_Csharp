   M S B A M L   `   `   `  ����B  >WpfApp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TeacherJournalTeacherJournal  5   	       TeacherJournal.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   7teacherJournalclr-namespace:TeacherJournal     5   	   -   5          � Title$)  #Электронный журнал��5   	   $	��600��6$   $	��800��61    � 	Resources 5         	BoolToVis  FadeInAnimation �� TargetProperty W� From	 W� To g� Duration&    TeacherJournal.LessThanConverter  LessThanConverter��%�   &	        &	      &	 u     �� 5	   
   6'   �� 5
   
   .��5      W� $ Opacity�6    06B    16K   $ 0:0:1D�6R   5        5   
   6+   5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   o� $��0��6   .@�5      m� $��Файл��6   m� 5      $��Студенты��6   .@�5      m� $��Открыть чат��6    m� Command 60   �� *OpenChatCommand+5      m� 5       $��Оценки��6   m� 5!      $��Настройки��6   5"      �� 5$   
   $��1��6   $)��#Электронный журнал��5%      $��20(�5&      $
��Bold"�6"   $��Center=�5'      $��0,0,0,10q�5(      �� 5*   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��0,0,0,10q�6;   .+�5+      �� $��Предмет:��6   $��Center=�6(   $��0,0,10,0q�6C   �� 5,      $	��200��6   	 �� DisplayMemberPath$	 
CourseName��5.      ��5-      �� *	Courses+
 �� SelectedItem
 5/      �� *SelectedCourse+50      � 52   
   $��3��6   $��20��6#    � IsIndeterminate$
 True��6/   $��0,0,0,10q�6F   y�53      �� *	IsLoading+ �� 	Converter# [  &   System.Windows.Controls.DataGrid  55   
   -   5        $��4��55         CanUserAddRows$ False��6       AutoGenerateColumns$ False��56      $��0,0,0,10q�57         
IsReadOnly$
 True��5:      ��58      �� *StudentGrades+
 59      �� *SelectedGrade+��5<      �� 5=       �� 
TargetType"  6   .�5>      ��  �� Property �@J�Opacity �� Value$ 0Q�60    �� Triggers 5?      �� 5@       �� Binding 6&   �� *	IsLoading+ �� Value	 False6D    N� EnterActions 5A      �� 5B   "   #��[ 62   5D      5F       5H      )  #System.Windows.Controls.DataGridRow �� ConverterParameter	 �� To g� AutoReverse g� RepeatBehavior��%�  '        7  �� 5I      "  6   .�5J      ��  � ��
 ���� 63    5K      �� 5L       6&   �� *	Average+8   $ 3�� True6�    5M      �� 5N   "   .��5O   &   �� .��5P   *   �� $* $(Background).(SolidColorBrush.Color)�5Q   -    Red5R   -   $ 0:0:0.5D�5S   -   $
 True��5T   -   $ Forever��5U   -   5V   '   5W   #   5Y      5[      5\         Columns 5]      0  *System.Windows.Controls.DataGridTextColumn  5^      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО студента��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *
FullName+6X     5_      $ Оценка��6%   $ 75 6O    65   �� *Grade+6O     5`      $ Комментарий��6%   $ * 6V    6:   �� *	Comment+6V   4  .System.Windows.Controls.DataGridTemplateColumn  5a      $ Присутствие��6)      CellTemplate 5b      �� 5c      .R�5d      �� $��Center=�6T     d� 	IsChecked  6'   �� *	IsPresent+! �� Mode$! TwoWay=�6T   5e      5g        5h      $ Средний балл��6%   "   
IsReadOnly$
" True��6W   $	 100 6i    6;   �� *	Average+6i   5j      �� 5l   
   $��5��6   $ 
Horizontal=�6"   $��Stretch=�6;   $��0,10,0,0q�6Y   $��Center=�5m      .+�5n      �� $ Vertical=�6   $	��300��60   .+�5o      �� $��30��5q      $��0,0,0,5q�6&   # � ToolTip$7# 1Введите домашнее задание...��5r      ��5o      �� *HomeworkText+$ �� UpdateSourceTrigger$$ PropertyChanged=�$! TwoWay=�y�5p      �� *DataContext.IsTeacher+% �� RelativeSource% �� & �� AncestorType
& Window# [  5r      �� 5s      
��� d �$
��Bold"�5t   3   ��5s      �� *HomeworkNotification+5t   3   5u      �� 5w      $��Отправить ДЗ��6   $	��120��6,   $��30��68   $
��10,0q�6D   ��5x      �� *SendHomeworkCommand+y�5y      �� *DataContext.IsTeacher+% �� 
& Window# [  5z      �� 5|   
   $��6��6   $ 
Horizontal=�6"   $��Right=�6;   $��0,10,0,0q�6W   .+�5}      �� $#��Добавить оценку��6   $	��120��6/   $��5q�6;   ���	#FF6DA5FF��6F   �� *AddGradeCommand+y�5~      �� *DataContext.IsTeacher+% �� 
& Window# [  5      �� 5�      $ ��Редактировать��6   $	��120��6-   $��5q�69   ���	#FF6DA5FF��6D   �� *EditGradeCommand+y�5�      �� *DataContext.IsTeacher+% �� 
& Window# [  5�      �� 5�      $!��Удалить оценку��6   $	��120��6.   $��5q�6:   ���	#FFEA3D55��6E   �� *DeleteGradeCommand+y�5�      �� *DataContext.IsTeacher+% �� 
& Window# [  5�      �� 5�      $	��150��6   $��30��6!   $��10q�6-   $��Экспорт в Excel��69   y�5�      �� *DataContext.IsTeacher+% �� 
& Window# [  ��5�      �� 5�      ' �� 
TargetType"' ��6&   .R�5�      �� $ 
Horizontal=�6%   .+�5�      �� $��/Assets/excel.png��6$   $��16��6?   $��16��6J   $��5q�6V   �� 5�      $��Center=�6/   5�      5�      5�      5�      5�      5�      