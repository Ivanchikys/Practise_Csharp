   M S B A M L   `   `   `  ���� B  >WpfApp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TeacherJournalTeacherJournal      TeacherJournal.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     7teacherJournalclr-namespace:TeacherJournal     -     � Title$)  #Электронный журнал��$	��600��$	��800�� � 	Resources    	BoolToVis  FadeInAnimation �� TargetProperty W� From	 W� To g� Duration&    TeacherJournal.LessThanConverter  LessThanConverter��%[   &	        &	      &	 8     �� �� .��W� $ Opacity� 0 1$ 0:0:1D�  .��� $��10q� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $
��auto ��� $
��auto �.+�o� $��0��.@�m� $��Файл��m� $��Студенты��.@�m� $��Открыть чат�� m� Command �� *OpenChatCommand+m� $��Оценки��m� $��Настройки���� $��1��$)��#Электронный журнал��$��20(�$
��Bold"�$��Center=�$��0,0,0,10q��� $��2�� �� Orientation$ 
Horizontal=�$��0,0,0,10q�.+��� $��Предмет:��$��Center=�$��0,0,10,0q��� $	��200��	 �� DisplayMemberPath$	 
CourseName������ *	Courses+
 �� SelectedItem
 �� *SelectedCourse+� $��3��$��20�� � IsIndeterminate$
 True��$��0,0,0,10q�y��� *	IsLoading+ �� 	Converter# [  &   System.Windows.Controls.DataGrid  -   $��4��   CanUserAddRows$ False��   AutoGenerateColumns$ False��$��0,0,0,10q�   
IsReadOnly$
 True������ *Enrollments+
 �� *SelectedEnrollment+����  �� 
TargetType"  .���  �� Property �@J�Opacity �� Value$ 0Q� �� Triggers ��  �� Binding �� *	IsLoading+ �� Value	 False N� EnterActions �� #��[  )  #System.Windows.Controls.DataGridRow �� ConverterParameter	 �� To g� AutoReverse g� RepeatBehavior��%�   '        7  �� "  .���  � ��
 ����  ��  �� *Grades[0].Average+8   $ 3�� True �� .���� .���� $* $(Background).(SolidColorBrush.Color)� Red$ 0:0:0.5D�$
 True��$ Forever��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО студента��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Student.FullName+  $ Оценка��$ 75  �� *Grades[0].Grade+  $ Комментарий��$ *  �� *Grades[0].Comment+4  .System.Windows.Controls.DataGridTemplateColumn  $ Присутствие��   CellTemplate �� .R��� $��Center=�  d� 	IsChecked  �� *Grades[0].IsPresent+! �� Mode$! OneWay=�  $ Средний балл��"   
IsReadOnly$
" True��$	 100  �� *Grades[0].Average+�� $��5��$ 
Horizontal=�$��Stretch=�$��0,10,0,0q�$��Center=�.+��� $ Vertical=�$	��300��.+��� $��30��$��0,0,0,5q�# � ToolTip$7# 1Введите домашнее задание...������ *HomeworkText+$ �� UpdateSourceTrigger$$ PropertyChanged=�$! TwoWay=�y��� *	IsTeacher+# [  �� 
��� d �$
��Bold"����� *HomeworkNotification+�� $��Отправить ДЗ��$	��120��$��30��$
��10,0q����� *SendHomeworkCommand+y��� *	IsTeacher+# [  �� $��6��$ 
Horizontal=�$��Right=�$��0,10,0,0q�.+��� $#��Добавить оценку��$	��120��$��5q����	#FF6DA5FF���� *AddGradeCommand+y��� *	IsTeacher+# [  �� $ ��Редактировать��$	��120��$��5q����	#FF6DA5FF���� *EditGradeCommand+y��� *	IsTeacher+# [  �� $!��Удалить оценку��$	��120��$��5q����	#FFEA3D55���� *DeleteGradeCommand+y��� *	IsTeacher+# [  �� $	��150��$��30��$��10q�$��Экспорт в Excel��y��� *	IsTeacher+# [  ���� % �� 
TargetType"% ��.R��� $ 
Horizontal=�.+��� $��/Assets/excel.png��$��16��$��16��$��5q��� $��Center=�