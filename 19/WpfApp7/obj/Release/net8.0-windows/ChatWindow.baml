   M S B A M L   `   `   `  ����   WpfApp6    TeacherJournal.ChatWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � Title$
  Chat��$	��450��$	��400�� � WindowStartupLocation$ CenterOwner=�.��� $��10q� � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��0��$��0,0,0,10q��� $$�Авторизован как �� �� $
��Bold"���� *CurrentUser.Username+�� $��1��$��0,0,0,10q�$��Stretch=����� *
Messages+���� .R��� $
��Wrap=����� � $��2�� � ColumnDefinitions �� $��* ��� $
��Auto �.+��� $��0��$��0,0,10,0q� �� AcceptsReturn$
 True�� �� TextWrapping$
 Wrap=�$��80��" �� VerticalScrollBarVisibility$
 Auto=����� *NewMessageText+ �� UpdateSourceTrigger$ PropertyChanged=�.�� J� InputBindings �� 
	 �� Key$	 Enter��
 �� Command
 �� *SendMessageCommand+.���� $��1��$��Отправить��$��75��$��30��$��Bottom=����� *SendMessageCommand+