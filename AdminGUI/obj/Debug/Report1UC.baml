   M S B A M L   `   `   `  ����C  ?AdminGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AdminGUIAdminGUI  5          AdminGUI.Report1UC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:AdminGUI     5      l hSystem.Windows.Controls.DataVisualization.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=nullMDataVAhttp://schemas.microsoft.com/winfx/2006/xaml/presentation/toolkit  63   .��5	      � -   5          �Name$  	gridTotal��5	      .+�5
   
   � -   5        $  gridMain��5
      
�������.+�5      >  8System.Windows.Controls.DataVisualization.Charting.Chart  -   5        $��ColumnChart��5      ���	#FFF5F5DC$��59,59,58,127q�6F   $��14(�6\   $��Segoe UI Semibold)�6j    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FF645200��6'      Series 5      E  ?System.Windows.Controls.DataVisualization.Charting.ColumnSeries  ?  9System.Windows.Controls.DataVisualization.Charting.Series   Title$ Revenue per Court��6)   H  BSystem.Windows.Controls.DataVisualization.Charting.DataPointSeries   IndependentValueBinding 6C   ��  �� Path$ 	CourtName�   DependentValueBinding 6w   �� $ Revenue�5      5        5      -   5        $��PieChart��5      
 �� Top$ 80��6,   	 �� Left$	 10��6<   
   LegendTitle$
 Courts��6M      Title$ Revenue per Court��6c   ���	#FFF5F5DC$��59,60,59,127q�5   &    5        5      $ 	#FF645200��6'    5#      B  <System.Windows.Controls.DataVisualization.Charting.PieSeries  $ 
Experience��6&    5$      �� $ CourtName_Pie� 5%      �� $ Revenue_Pie�5+        5/      -   5        $��	AreaChart��5/   P   $y�Hidden=�6   $ 80��6/   $	 10��6?   ���	#FFF5F5DC$
 Revenue��51      $��60,58,59,128q�6'    52        53      $ 	#FF645200��6'    56      C  =System.Windows.Controls.DataVisualization.Charting.AreaSeries  $ 
 per Court��57         IndependentValuePath$ CourtName_Area��58         DependentValuePath$ Revenue_Area��59      5:      5<      �� 5?      -   5        $�� ��5?      $
��Left=�6!   $��350,394,0,0q�6<   $	��Top=�6Q   $��20��6i   $��20��6t   $
��Bold"�6�   $��Segoe UI Black)�6�   
������� � 	Resources 5@       �� 
TargetType �� Property �� Value��%`   '��       �� 5A      " ��6   .�5B      ��  �@��CornerRadius$	 200��69   5C      5D      5E      �� 5H      -   5        $�� ��5H      $
��Left=�6!   $��307,394,0,0q�6<   $	��Top=�6Q   $��20��6i   $
��Bold"�6u   $��Segoe UI Black)�6�   $��20��6�   
������� 5I      ��%`   '��       �� 5J      " ��6   .�5K      ��  �@��CornerRadius$	 200��69   5L      5M      5N      �� 5Q      -   5        $�� ��5Q      $
��Left=�6    $��266,394,0,0q�6;   $	��Top=�6P   $��20��6h   $
��Bold"�6s   $��Segoe UI Black)�6�   $��20��6�   
������� 5S      ��%`   '��       �� 5T      " ��6   .�5U      ��  �@��CornerRadius$	 200��69   5V      5W      5X      �� 5Z      -	   5        $
��Back��5Z      $
��Left=�6$   $��
57,394,0,0q�6?   $	��Top=�6S   $��75��6k   $��28��6v    5[      ��%^   '��       �� 5\      " ��6   .�5]      ��  �@��CornerRadius$ 3��69   5^      5_      5`      5b      5d      5f      