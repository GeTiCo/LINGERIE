   M S B A M L   `   `   `  ����G  CLINGERIESHOP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:LINGERIESHOP.ViewLINGERIESHOP.View  5      "    LINGERIESHOP.View.AdminPanel   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:LINGERIESHOP.View     5        N� Title$  
AdminPanel��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      �� $��20,3,0,3q�6   $y�Hidden=�6'   
������ $��Sylfaen)�6U   
����������	#FF007AFF$-��'Редактировать заказы��6�   $��20(�6�   $	��250��6�   $
��Left=�6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 25��69   5      5      5      �� 5       �� Orientation$ 
Horizontal=�6   $��0��62   $��50��6?   $��
0,-10,20,0q�6K   $��Center=�6_   .+�5      �� -   5           
BbtnStyle2#��[  5      $��Добавить��6=   $	��150��6P   $��0,10,0,0q�6\   $��20(�6n   $��Sylfaen)�6|   ���	#FF007AFF
����������	#FF007AFF 5      ��%f   '��       �� 5      " ��6    .�5      ��  �@��CornerRadius$ 	25,0,0,25��6=   5      5      5      �� 5       -   5        #��[  5       $ ��Редактировать��6=   $	��150��6U   $��0,10,0,0q�6a   $��20(�6s   $��Sylfaen)�6�   ���	#FF007AFF
����������	#FF007AFF6�   �� 5!      -   5        #��[  5!      $��Удалить��6=   $	��150��6O   $��0,10,0,0q�6[   $��20(�6m   $��Sylfaen)�6{   ���	#FF007AFF
����������	#FF007AFF 5"      ��%f   '��       �� 5#      " ��6    .�5$      ��  �@��CornerRadius$ 	0,25,25,0��6=   5%      5&      5'      5(      5)       � 5*   
   -   5        $��SettingsFrame��5*      $��1��6     � NavigationUIVisibility$ Hidden=�62     mainback#��[ 6R   5,      5-      5.      