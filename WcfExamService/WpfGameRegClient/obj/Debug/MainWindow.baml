   M S B A M L   `   `   `  ����K  GWpfGameRegClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfGameRegClientWpfGameRegClient  5   	   !    WpfGameRegClient.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WpfGameRegClient     5   	     � Title$  GameReg ��5   	   $��236.765��5	      $	��525��6    � 
ResizeMode$ NoResize=�6     � WindowStartupLocation$ CenterScreen=�66   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5        $��Login��5      $��1��6!   $
��Left=�61   $��
75,163,0,0q�6L   $	��Top=�6`   $	��157��6x   6�   �� 5   
   -   5        $��Registration��5      $
��Left=�6(   $��
78,163,0,0q�6C   $	��Top=�6W   $	��172��6o   6{   �� 5   
   -   5        $��	logPasswd��5      $��1��6#   $
��Left=�63   $��23��6N   $��
75,118,0,0q�6Z    �� TextWrapping$
 Wrap=�6n   $�� ��6�   $	��Top=�6�   $	��157��6�    J� RenderTransformOrigin$ 0.858,0.534&�6�   �� 5   
   -   5        $��logLogin��5      $��1��6"   $
��Left=�62   $��23��6M   $��	75,83,0,0q�6Y   $
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��157��6�   �� 5   
   -   5        $��	regPasswd��5      $
��Left=�6#   $��23��6>   $��
78,118,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��172��6�   �� 5   
   -   5        $��regLogin��5      $
��Left=�6"   $��23��6=   $��	78,90,0,0q�6I   $
 Wrap=�6\   $	��Top=�6q   $	��172��6�   �� 5   
   -   5        $��regNick��5      $
��Left=�6!   $��23��6<   $��	78,62,0,0q�6H   $
 Wrap=�6[   $	��Top=�6p   $	��172��6�   �� 5   
   $��Login��6   $��1��6!   $
��Left=�61   $��	10,83,0,0q�6L   $	��Top=�6_   $��26��6w   �� 5   
   $��1��6   $
��Left=�6!   $��
10,114,0,0q�6<   $	��Top=�6P   $��26��6h   �� 5   
   $��Nickname��6   $
��Left=�6$   $��	10,59,0,0q�6?   $	��Top=�6R   �� 5   
   $��Login��6   $
��Left=�6!   $��	10,90,0,0q�6<   $	��Top=�6O   �� 5   
   $��Password��6   $
��Left=�6$   $��
10,115,0,0q�6?   $	��Top=�6S   �� 5   
   -   5        $��ResultLabel��5      $��26(�6#   $��Gamers Service��62   $
��Left=�6K   $��32,9,0,0q�6f   $	��Top=�6x   $	��443��6�   $��2��6�   �� 5   
   $��Passw��6   $��1��6!   $
��Left=�61   $��
11,115,0,0q�6L   $	��Top=�6`   $��26��6x   �� 5   
   -	   5        $��Test con��5      $��10,154,190,10q�6%   6<   5      5       