   M S B A M L   `   `   `  ����F  BCustomerGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CustomerGUICustomerGUI  5   	       CustomerGUI.BookingDLG   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CustomerGUI     5   	     � WindowStartupLocation$  CenterScreen=�5       � 
ResizeMode$ NoResize=�6?    � Title$ Payment��5   	   $	��254��6   $��377.333��6&   $
��Thin"�66   .��5	      � .+�5   
   �� $��Card Holder:��6   $
��Left=�6'   $��	38,25,0,0q�6B   $	��Top=�6U   �� 5   
   -   5         ��Name$ tbName��5      $
��Left=�6"   $��27��6=   $��
120,25,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   $��Card Number:��6   $
��Left=�6'   $��	31,57,0,0q�6B   $	��Top=�6U   �� 5   
   -   5        $ tbNumber��5      $
��Left=�6$   $��27��6?   $��
120,57,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   $��Expiry Date:��6   $
��Left=�6'   $��	43,90,0,0q�6B   $	��Top=�6U   �� 5   
   -   5        $ tbExDate��5      $
��Left=�6$   $��27��6?   $��
120,89,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   $��CCV2:��6   $
��Left=�6    $��
74,121,0,0q�6;   $	��Top=�6O   �� 5   
   -   5        $ tbCCV2��5      $
��Left=�6"   $��27��6=   $��120,121,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5   
   -   5         ��Name$ btnPay��5      $	��Pay��66   $
��Left=�6D   $��184,175,0,0q�6_   $	��Top=�6t   $	��120��6�   $��24��6�    � 	Resources 5       �� 
TargetType �� Property	 �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$	 3��65   5      5      5      �� 5   
   $��Images/VisaCard.png��6   $��258,28,80,169q�6-   �� 5   
   $��Images/MasterCard.png��6   $��258,62,80,142q�6/   �� 5   
   -   5        $ 	btnCancel��5      $��Cancel��6<   $
��Left=�6M   $��
49,175,0,0q�6h   $	��Top=�6|   $	��120��6�   $��24��6�    5      ��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$	 3��65   5       5!      5"      5#      5$      