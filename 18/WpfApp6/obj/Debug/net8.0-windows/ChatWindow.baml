   M S B A M L   `   `   `  ����  WpfApp6    TeacherJournal.ChatWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          � Title$
  Chat��5   	   $	��450��6   $	��400��6#    � WindowStartupLocation$ CenterOwner=�5   	   .��5
      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0,0,0,10q�6!   �� 5      $$�Авторизован как ��6    �� 5      $
��Bold"�68   �6   �� *CurrentUser.Username+68   5      �� 5   
   $��1��6   $��0,0,0,10q�6@   $��Stretch=�5      ��5      �� *
Messages+��5      �� 5      .R�5      �� $
��Wrap=�61   ��6    �� 61   5      5      � 5   
   $��2��6    � ColumnDefinitions 5       �� 5!      $��* �6#   �� 5"      $
��Auto �6#   .+�5$      �� $��0��6   $��0,0,10,0q�6&    �� AcceptsReturn$
 True��5&       �� TextWrapping$
 Wrap=�6+   $��80��6?   " �� VerticalScrollBarVisibility$
 Auto=�6N   ��5%      �� *NewMessageText+ �� UpdateSourceTrigger$ PropertyChanged=�.��5&   q    J� InputBindings 5'      �� 5(      
	 �� Key$	 Enter��6!   
 �� Command
 6-   �� *SendMessageCommand+.��5)   )   5*      �� 5+      $��1��6   $��Отправить��6%   $��75��69   $��30��6D   $��Bottom=�6P   ��5,      �� *SendMessageCommand+5-      5.      5/      