   M S B A M L   `   `   `  ����   WpfApp6$    TeacherJournal.EditGradeWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$-  'Редактировать запись��$	��250��$	��350�� � WindowStartupLocation$ CenterOwner=� � 
ResizeMode$ NoResize=�.��� $��10q� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$��ФИО студента:��$��0,0,0,5q��� $��1��$��0,0,0,10q����� *
FullName+ �� UpdateSourceTrigger$ PropertyChanged=��� $��2��$��Оценка (0-10):��$��0,0,0,5q��� -   $��3��$��0,0,0,10q����� *EditedGrade.Grade+$ PropertyChanged=��� $��4��$��Комментарий:��$��0,0,0,5q��� $��5��$��0,0,0,10q� �� AcceptsReturn$
 True��$��40������ *	Comment+$ PropertyChanged=��� $��6�� �� Orientation$ 
Horizontal=�$��Right=�.+��� $ ��Присутствовал��$��0,0,10,0q�$��Center=� d� 	IsChecked �� *	IsPresent+�� -   $
��ОК��$��75��$��0,0,10,0q��� -   $��Отмена��$��75��