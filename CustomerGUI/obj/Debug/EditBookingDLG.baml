   M S B A M L   `   `   `  ����F  BCustomerGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CustomerGUICustomerGUI  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5           CustomerGUI.EditBookingDLG   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:CustomerGUI     5      6sys&clr-namespace:System;assembly=mscorlib     5        � Title$  EditBookingDLG��5	   	    � WindowStartupLocation$ CenterScreen=�6    $	��315��5
   	   $	��400��6   .��5      � .+�5   
   �� $��	Court #: ��6   $
��Left=�6$   $��
107,54,0,0q�6?   $	��Top=�6S   �� 5   
   $��Date : ��6   $
��Left=�6"   $��
119,88,0,0q�6=   $	��Top=�6Q   �� 5   
   $��
Session : ��6   $
��Left=�6%   $��103,118,0,0q�6@   $	��Top=�6U   �� 5   
   $��
Trainer : ��6   $
��Left=�6%   $��108,150,0,0q�6@   $	��Top=�6U   �� 5   
   $��Equipment : ��6   $
��Left=�6'   $��
87,176,0,0q�6B   $	��Top=�6V   �� 5   
   $��Reservation ID : ��6   $
��Left=�6,   $��	68,19,0,0q�6G   $	��Top=�6Z   �� 5   
   -   5         ��Name$ lblBookingId��5      $	�� - ��6&   $
��Left=�64   $��
163,21,0,0q�6O   $	��Top=�6c   $��46��6{   �� 5   
   $y�Hidden=�6   $��Trainer Name :��6$   $
��Left=�6=   $��
203,26,0,0q�6X   $	��Top=�6l   �� 5   
   -   5        $ lblTrainerName��5   $   $y�Hidden=�6   $	�� - ��6<   $
��Left=�6J   $��
297,26,0,0q�6e   $	��Top=�6y    J� RenderTransformOrigin$ 8.866,0.521&�6�   �� 5   
   -   5        $��comboSession��5       �� SelectedValuePath$ Content��6'   $
��Left=�6C   $��170,119,0,0q�6^   $	��Top=�6s   $	��149��6�   $��26��6�   .@�5      ��  �� 
IsSelected . .��5      ��  �� TextAlignment$ Center=�6   $��Select a session...��63   $��25��6N   $	��133��6Z   $��0,2,0,0q�6f   5      �� 5      $��10:00 AM��6   60   �� 5      $��12:00 PM��6   60   �� 5      $��2:00 PM��6   6/   �� 5      $��4:00 PM��6   6/   �� 5      $��6:00 PM��6   6/   5       �� 5!   
   -   5        $��
comboCourt��5!      $
��Left=�6%   $��
170,54,0,0q�6@   $	��Top=�6T   $	��149��6l   $��29��6x   .@�5#      ��  . .��5$      �� $ Center=�6   $��Select one court...��63   $��22��6N   $	��133��6Z   $��0,3,0,0q�6f   5%      �� 5&      .��6   	Court 16%   �� 5'      .��6   	Court 26$   �� 5(      .��6   	Court 36$   �� 5)      .��6   	Court 46$   5*      �� 5+   
   -   5         ��Name$ comboTrainer��5+       �� DisplayMemberPath$
 Name��6)   $ 	TrainerId��6B   $
��Left=�6`   	 �� 
IsEditable	 . 
 �� 
IsReadOnly
 .  $��170,151,0,0q�6�   $	��Top=�6�   $	��149��6�   $��26��6�   5/      	� 50   
   -   5         	�Name$ rbEquipment_Yes��50      $	��Yes��6/   $
��Left=�6=   $��180,182,0,0q�6X   $	��Top=�6m   $ 	0.417,2.8&�6�    d� 	IsChecked$
 TrueY�6�    	� 	GroupName$ 	Equipment��6�   	� 51   
   -   5        $ rbEquipment_No��51      $��No��6.   $
��Left=�6;   $��249,182,0,0q�6V   $	��Top=�6k   $ 	0.417,2.8&�6�   $ 	Equipment��6�   (  "System.Windows.Controls.DatePicker  54   
   -   5        $��dpDate��54      $
��Left=�6#   $��
170,87,0,0q�6>   $	��Top=�6R   $��28��6j   $	��149��6v    �� Today   DisplayDateStart# Z 6�   �� 56   
   -	   5         ��Name$ btUpdate��56      $��Update��6:   $��24��6K   $��95,216,200,20q�6W    �� 	IsDefault .  � 	Resources 57       �� 
TargetType �� Property �� Value��%^   '��       �� 58      " ��6   .�59      ��  �@��CornerRadius$ 3��65   5:      5;      5<      �� 5=   
   -
   5        $ btCancel��5=      $��Cancel��6#   $��24��64   $��239,216,56,20q�6@    �� IsCancel .  5>      ��%^   '��       �� 5?      " ��6   .�5@      ��  �@��CornerRadius$ 3��65   5A      5B      5C      �� 5D   
   -   5        $ lblDateTime��5D      $�� ��6%   $
��Left=�60   $��	185,0,0,0q�6K   $	��Top=�6^   $	��207��6v   $
��Bold"�6�   $y�Hidden=�6�    J� Effect 5E      3  -System.Windows.Media.Effects.DropShadowEffect  5F         Color$ 	#FF0C00FF��6#      ShadowDepth$ 2Q�65      Opacity$	 0.5Q�6E   5H      5J      5K      