   M S B A M L   `   `   `  ����  WpfApp6)    #TeacherJournal.StudentSummaryWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$(  "Сводка по студенту��5   	   $	��300��6$   $	��400��61    � 
ResizeMode$ NoResize=�6=   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5	      $
��Auto �6   .+�5   
   �� $��0��6   $��20(�6;   $
��Bold"�6I   $��10q�6[   ��6!   �� *
FullName+6[   �� 5   
   $��1��6   $��10q�6?   ��6    �� *Grades+ �� View 5      �� 5      .P�5      �� $��Оценка��6%    �� Width$ 50��6\    �� DisplayMemberBinding 65   �� *Grade+6\   �� 5      $��Комментарий��6%   $	 220��6c    6:   �� *	Comment+6c   �� 5      $��Присутствие��6%   $ 80��6e    6:   �� *	IsPresent+6e   5      5      �� 5   
   $��2��6   $��16(�6_   $��10q�6m   ��6!   �� *	Average+ �� StringFormat$% Средний балл: {0:F2}��6m   5      5      