   M S B A M L   `   `   `  ����  WpfApp1    TeacherJournal.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$)  #Электронный журнал��5   	   $	��600��6$   $	��800��61   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5	      $��* �6   �� 5
      $
��auto �6   .+�5   
   �� $��0��6   $)��#Электронный журнал��5      $��20(�5      $
��Bold"�6"   $��Center=�5      $	��Top=�5      $��0,0,0,10q�6)   �� 5   
   $��1��6   $	��Top=�5       �� Orientation$ 
Horizontal=�6"   $��0,0,0,10q�6;   .+�5      �� $��Предмет:��6   $��Center=�6(   $��0,0,10,0q�6C   �� 5      -   5         ��Name$ SubjectComboBox��5      $	��200��60   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ StudentGradesGrid��5   7   $��2��6      CanUserAddRows$ False��6       AutoGenerateColumns$ False��6R   $��0,0,0,10q�6n      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО студента��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6X   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   �� *
FullName+6X     5      $ Оценка��6%   $	 75 6O   
 65   �� *Grade+6O     5      $ Комментарий��6%   $	 * 6V   
 6:   �� *	Comment+6V   5      �� 5!   
   $��3��6   $ 
Horizontal=�5"      $��Right=�6.   .+�5#      �� -   5        $#��Добавить оценку��5#      $	��150��5$      $��30��6!   5%      5'      5(      5)      