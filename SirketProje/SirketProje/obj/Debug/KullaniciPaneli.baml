   M S B A M L   `   `   `  ����F  BSirketProje, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SirketProjeSirketProje  5   	   !    SirketProje.KullaniciPaneli   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   %localclr-namespace:SirketProje  5   	   -   5          � Title$  KullaniciPaneli��5	   	   $��535.5��6!   $��366.5��60    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   
������ .��5      � $��1��6   ���#00000D$��0,0,2,2q�60   .+�5   
   �� $	��150��6   $	��Top=�6   $��Assets/back.jpg��65   $��UniformToFill=�6N   A� 5   
   $	��100��6   $	��100��6   $	��Top=�6+   $��Right=�6C   $��20 100q�6_   
���������5      �� 5      -   5        
image1�� j� Stretch$ UniformToFill=�5   E    �� ImageSource 6-   �� 6E   5      �� 5   
   -   5         ��Name$ textAd��5      
�������$��20(�67   $��Nirmala UI Semilight)�6E   $��10,100,120,0q�6g   $	��Top=�6}   �� 5   
   $��
0,150,0,10q�6   .+�5      � $��60��6   $��
20,50,10,0q�6    � ColumnDefinitions 5      �� 5      $	��65* �6'   �� 5      $
��116* �6'   �� 5      $	��115 �6'    � RowDefinitions 5      �� 5       $��30 �6$   �� 5!      $��30 �6$   �� 5"      $��30 �6$   .+�5$      �� $��MAAŞ��6   $��Bottom=�6(   ���	#FFFBFBFB$��5,0,5,5q�6Z   $��16��6k   �� 5%      -   5        $ textMaas��5%      $
��---K��6.   $	��Top=�6:   ���	#FFFBFBFB$��1��6i   $��5,0,15,0q�6v   $��16��6�   �� 5'      $��	DEPARTMAN��6   $��Bottom=�6-   ���	#FFFBFBFB$��5,0,5,5q�6_   $��1��6p   $��16��6�   �� 5(      -   5        $ textDepartman��5(      $	��---��63   $	��Top=�6>   ���	#FFFBFBFB$��1��6m   $
��10 0q�6z   $��1��6�   $��16��6�   �� 5+      $��Şube��6   $��Bottom=�6(   ���	#FFFBFBFB$��5,0,5,5q�6Z   $��2��6k   $��16��6{   �� 5,      -   5        $ textSube��5,      $	��Top=�6.   ���	#FFFBFBFB$��1��6]   $	��5,0q�6j   $��2��6w   $��16��6�   5-      �� 5/      -   5        $ textHakkinda��5/      $
��Wrap=�6.   $��20,20,10,20q�6B   ���	#FFFBFBFB$��14(�6n   $	��167��6|   6�   �� 51      $
��Left=�6   .+�52      �� -   5        	 ��Name$	 btnGeri��52      $��40��6*   $��40��65   $��30(�6A   $	��←��6O   $��15,0,0,0q�6[   6m   53      56      57      58      