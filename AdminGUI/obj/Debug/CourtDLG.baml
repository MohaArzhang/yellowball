   M S B A M L   `   `   `  ����C  ?AdminGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AdminGUIAdminGUI  5   	       AdminGUI.CourtDLG   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:AdminGUI     5   	     � 
ResizeMode$  NoResize=�5       � WindowStartupLocation$ CenterScreen=�60    � Title$ Court availability��5   	   $��321.444��6$   $��377.556��65   .��5	      � .+�5
   
   �� $ ��Change courts availability��6   $
��Left=�65   $��
116,30,0,0q�6P   $	��Top=�6d   $	��164��6|   $
��Bold"�6�   �� 5   
   $��Court 1:��6   $
��Left=�6#   $��	70,66,0,0q�6>   $	��Top=�6Q   	� 5   
   -   5         	�Name$ radio1Avail��5      $��	Available��6+   $
��Left=�6?   $��
132,72,0,0q�6Z   $	��Top=�6n   $��19��6�    	� 	GroupName$ court1��6�   	� 5   
   -   5        $ radio1Un��5      $��Unavailable��6(   $
��Left=�6>   $��
225,71,0,0q�6Y   $	��Top=�6m   $��19��6�   $ court1��6�   �� 5   
   $��Court 2:��6   $
��Left=�6#   $��	70,98,0,0q�6>   $	��Top=�6Q   	� 5   
   -   5        $ radio2Avail��5      $��	Available��6+   $
��Left=�6?   $��132,104,0,0q�6Z   $	��Top=�6o   $��19��6�   $ court2��6�   	� 5   
   -   5        $ radio2Un��5      $��Unavailable��6(   $
��Left=�6>   $��225,103,0,0q�6Y   $	��Top=�6n   $��19��6�   $ court2��6�   �� 5   
   $��Court 3:��6   $
��Left=�6#   $��
70,132,0,0q�6>   $	��Top=�6R   	� 5   
   -   5        $ radio3Avail��5      $��	Available��6+   $
��Left=�6?   $��132,138,0,0q�6Z   $	��Top=�6o   $��19��6�   $ court3��6�   	� 5   
   -   5        $ radio3Un��5      $��Unavailable��6(   $
��Left=�6>   $��225,137,0,0q�6Y   $	��Top=�6n   $��19��6�   $ court3��6�   �� 5   
   $��Court 4:��6   $
��Left=�6#   $��
70,167,0,0q�6>   $	��Top=�6R   	� 5   
   -   5        $ radio4Avail��5      $��	Available��6+   $
��Left=�6?   $��131,173,0,0q�6Z   $	��Top=�6o   $��19��6�   $ court4��6�   	� 5   
   -   5        $ radio4Un��5      $��Unavailable��6(   $
��Left=�6>   $��224,172,0,0q�6Y   $	��Top=�6n   $��19��6�   $ court4��6�   �� 5   
   -	   5         ��Name$ btnAdd��5      $��Update��69   $
��Left=�6J   $��203,222,0,0q�6e   $	��Top=�6z   $	��115��6�   $��25��6�    � 	Resources 5       �� 
TargetType �� Property	 �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$	 3��65   5      5      5      �� 5   
   -
   5        $ 	btnCancel��5      $��Cancel��6<   $
��Left=�6M   $��
65,223,0,0q�6h   $	��Top=�6|   $	��115��6�   $��25��6�    5      ��%^   '��       �� 5       " ��6   .�5!      ��  �@��CornerRadius$	 3��65   5"      5#      5$      5&      5'      