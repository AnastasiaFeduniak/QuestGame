   M S B A M L   `   `   `  ����?  ;Lab5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab5Lab5  5   	       Lab5.StoryWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab5     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	     � Title$  StoryWindow��5	   	   $	��500��6   $	��800��6*    � 	Resources 5
       �� 
TargetType �� Property �� Value��%p  '��       '�� s     �� 5   
   " ��6   .�5      ��  � ��$ 	minecraft)�6+   �� 5       � ��$ 16(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 	minecraft)�6+   �� 5       � ��$ 16(�6)   �� 5       � ��
 ���� 6+   �� 5       � ��
 ���� 6,   �� 5       � �� �#b3a59b6+   5      5      .��5      � -   5        $
��grid��5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $	��150 �6   .+�5   
   �� -   5        $��
Background��5   e   $9��3D:\LABS_2\MAPZ\Lab5\Lab5\Images\menu_background.jpg��6   $��UniformToFill=�6M   $��0��6w   $��2��6�   �� 5    
   -   5        $��CharacterSprite��5        K� ZIndex$ 3��6'   $��UniformToFill=�6:   $��Center=�6R   $	��Top=�6o   $	��260��6�   $	��315��6�   $��0,10,0,0q�6�   $��0��6�   �� 5#   
   ���	#AA000000$��Bottom=�6(   $��7,0,7,7q�6C   ���#2e2b28$��5q�6j   $��1��6~   ._�5$      � $��Bottom=�6    5%      �� 5&      $��25 �6$   �� 5'      $��95 �6$   �� 5(      $
��Auto �6$   .+�5,      �� -   5        $��CharacterName��5,      $
��Wrap=�61   $��
10, 5 0, 0q�6E   $��18(�6Y   ���#bda986$
��Bold"�6|   $��0��6�   �� 5/      -   5        $��	StoryText��5/      $
��Wrap=�6-   $��10q�6A   
�������$��16(�6`   $��1��6n   �� 52       �� Orientation$ 
Horizontal=�6   $��Stretch=�66   $��Bottom=�6T   $��0,0,0,0q�6o   $��2��6�   .+�53      �� -   5        $��
Назад��53      $	��100��6-   $
��10,0q�6R   �� 54      $��Зберегти��6   $	��100��60   $
��10,0q�6<   �� 55      $��Загрузити��6   $	��100��61   $
��10,0q�6=   �� 56      $��Інвентар��6   $	��100��60   $
��10,0q�6<   �� 57      $��Меню��6   $	��100��6,   $
��10,0q�68   58      59      5:      5;      5<      