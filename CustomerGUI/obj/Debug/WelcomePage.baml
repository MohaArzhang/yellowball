   M S B A M L   `   `   `  ����F  BCustomerGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CustomerGUICustomerGUI  5   	       CustomerGUI.WelcomePage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CustomerGUI     5   	     � 
ResizeMode$  NoResize=�5       � WindowStartupLocation$ CenterScreen=�60    � Title$ Welcome to Yellow Ball��5      $	��500��6'   $	��650��64   .��5	      � -   5         �Name$ gridWelcome��5	      .+�5
   
   �� $	��134��6   $	��Top=�6!   $��0,338,-0.333,0q�69   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ White��6#   � 5      $ Beige��6#    � Offset$ 1Q�61   � 5      $ Beige��6#   $ 0.546Q�61   5      5      � 5   
    � RowDefinitions 5      �� 5      $
��231* �6    �� 5      $	��64* �6    �� 5      $	��40* �6    �� 5      $	��33* �6    �� 5      $
��104* �6    5      �� 5   
   $��Images/Welcome.jpg��6   $��0,0,-0.333,240q�6,   $��0��6D   �� 5   
   -   5        	 ��Name$	 btnBook��5      $��Book Now��6"   $
��Left=�65   $��217,250,0,0q�6P   $	��Top=�6e   $	��207��6}   $��30��6�   $��16(�6�   $��1��6�   
 � 	Resources
 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5       " ��6   .�5!      ��  �@��CornerRadius$ 3��65   5"      5#      5$      �� 5&   
   $
��Left=�6   $��120,301,0,0q�6/   $
��Wrap=�6D   $����Our courts can be booked up to one day in advance on the telephone, or in person with the attendant. You can also book here by this machine.��6X   $	��Top=�6�   $	��400��6   �� TextAlignment$ Center=�6  $��Segoe UI Light)�6'  $��2��6C  �� 5'   
   $
��Left=�6   $��
393,55,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   
�������$��30(�6�   $��Trebuchet MS)�6�   $ Center=�6�   �� 6�   $�Yellow Ball��6�   �� 6�   �� 6�   $�Tennis Courts��6�   6  �� 5(   
   $��Images/Trainers.png��6   $��0,374,-0.333,25q�6-   �� 5)   
   $��Our Trainers��6   $
��Left=�6'   $��270,338,0,0q�6B   $	��Top=�6W   $	��101��6o   $��18(�6{   $��Segoe UI Light)�6�   5*      5+      