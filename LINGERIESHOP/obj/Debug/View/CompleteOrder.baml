   M S B A M L   `   `   `  ����G  CLINGERIESHOP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:LINGERIESHOP.ViewLINGERIESHOP.View  5      %    LINGERIESHOP.View.CompleteOrder   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:LINGERIESHOP.View     5        N� Title$  CompleteOrder��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��75 �6   .+�5   
   �� -   5        $��50��5      $��50��6   $
��Left=�6(   $	��Top=�6C   $��10q�6[      back#��[  6t   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ SecretOrder��5   /      AutoGenerateColumns .  $y�Hidden=�6D      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 UID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.5* 62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   ��  �� Path$	 Uid�  5      $ Название��6%   $ * 69    6C   �� $
 Name�  5      $ Размер��6%   $
 0.5* 67    6D   �� $
 Size�  5      $ Комплект��6%   $ * 69    6C   �� $ 	Structure�  5      $ Цена��6%   $
 0.5* 63    6@   �� $
 Cost�  5      $ Кол-во��6%   $
 0.5* 65    6B   �� $ Count�  5      $ 
Итого��6%   $ * 64    6>   �� $ Costing�5        5   
   -   5        $ order��5!      $��0��5      $
��30,0q�5      
������ 	 �� SelectedItem$	 false��5       
������ 
   
IsReadOnly
 .  .  $   HorizontalScrollBarVisibility$ Hidden=�5%      "   VerticalScrollBarVisibility$ Hidden=�5&         CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .     CanUserSortColumns .     CanUserAddRows .     CanUserDeleteRows .     GridLinesVisibility$
 None=�5-       %� 
ScrollUnit$ Pixel=�5.         HeadersVisibility$
 None=�5/      $��Center=�50      $��Center=�51       � 	Resources 52      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Property �� Value)  #System.Windows.Controls.DataGridRow�� 53      %8  '        '  �     �� 54      "  6:   .�55      ��  � �� 67   Z� �� 56       � �� 68   Z� �� 57       � ��
 �   �67   58      �� 59      "  6   .�5:      ��  � �� 67   Z� �� 5;       � �� 68   Z� �� 5<       � ��
 �   �67   5=      5>       5@      4  .System.Windows.Controls.DataGridTemplateColumn  5A      $ Image��6)   $ * 69      
IsReadOnly .    CanUserResize .     CellTemplate 5B      �� 5C      .R�5D      �� 
������� �� CornerRadius$ 30��68   ���	#FF007AFF$
��1000��6b    �� Padding$ 	50,0,50,0q�6o   $��Center=�6�   $��2q�6�   ._�5E   "   �� 
�������$��75,0,0,0q�6@    �� Orientation$ 
Horizontal=�6R   $��Center=�6k   $	��900��6�   $��Center=�6�   .+�5F   &   ��   � UseLayoutRounding  . $	��150��6d   $	��200��6p   $
��25,0q�6}   $��UniformToFill=�6�   ��6F   �� $ Photo�6�   �� 5G   &   $ Vertical=�61   $	��400��6H   $��15,30q�6T   $��Center=�6c   .+�5H   *   �� $��25(�5J   -   ���	#FF007AFF$��Sylfaen)�5L   -   $
��Wrap=�5M   -   ��5I   -   �� $
 Name�5M   -   �� 5N   *   $ 
Horizontal=�65   $
��Left=�6N   .+�5O   .   �� $��20(�5Q   1   $��Sylfaen)�5R   1   $
��Left=�6F   ��5P   1   �� $
 Cost�! �� StringFormat$! Цена: {0}��5R   F   �� 5S   .   ���	#FF007AFF$��20(�5V   1   $��40,0,0,0q�5W   1   $��Sylfaen)�5X   1   ��5U   1   �� $	 Uid�$! UID: {0}��5X   1   5Y   +   �� 5Z   *   $��20(�5\   -   $��Sylfaen)�5]   -   ��5[   -   �� $ Count�$! Кол-во: {0}��5]   -   �� 5^   *   $��20(�5`   -   $��Sylfaen)�5a   -   $
��Bold"�5b   -   ��5_   -   �� $ Costing�$! Итог: {0}��5b   -   5c   '   �� 5d   &   $ 
Horizontal=�61   .+�5e   *   �� $
��plus��6c   -   5          plus#��[ 5e   1   $��	-10,0,0,0q�6P   $��60��6�   $��60��6�   �� 5f   *   $��minus��6b   -   5         	 minus#��[ 5f   1   $��5,0,0,0q�6Q   $��60��6�   $��60��6�   �� 5g   *   $��delete��6b   -   5         	 delet#��[ 5g   2   $��5,0,0,0q�6Q   6p   5h   '   5i   #   5j      5k      5m      5o      � 5p   
   $��1��6   
�������" � ColumnDefinitions" 5q      �� 5r      $��* �6#   �� 5s      $��* �6#   .+�5u      �� -   5        $��wallet��5w      $��0��5v        RTBStyle#��[ 5x      ���	#FF007AFF$��Сумма заказа:��5z      $��Center=�5{      $��Center=�5|      $��25(�5}      $��Sylfaen)�5~      
������ 5      �� 5�      -   5        $��1��5�        btnStyle#��[ 5�      $��120, 10q�5�      $��Оплатить��5�      5�      5�      5�      5�      