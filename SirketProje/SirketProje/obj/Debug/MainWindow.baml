   M S B A M L   `   `   `  ����F  BSirketProje, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SirketProjeSirketProje  5   	       SirketProje.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SirketProje     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  
MainWindow��5
   	   $	��450��6   $	��380��6)    � AllowsTransparency . 
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ #7be9f6��6'    � Offset$	 0.0Q�67   � 5      $ #f083da��6'   $ 1Q�67   5      5      �� 5!      $��Center=�6   .+�5"      �� $��Assets/House.png��6   $	��150��62   �� 5#      $��Giriş Sayfası��6   $��Light"�5$      $��	helvetica)�5%      $��22(�5&      
�������$��Center=�5(      5)      �� 5-      $��1��6   .+�5.      �� 	 �� Orientation$	 
Horizontal=�6   .+�5/      �� -   5        
 ��Name$
 textMail��5/      $��	Helvetica)�60   $��Light"�50      $�� ��51      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mail Adresi��52      $��20(�53      $��Center=�54      
�������
������ $��0q�57      $	��235��58      $
��Left=�59       J� Opacity$	 0.5Q�5:      $��25��5;      $��63,0,0,0q�5<      .  (MahApps.Metro.IconPacks.PackIconMaterial  5=         Kind$ Account=�61   $��Center=�5>   1   $��Center=�5?   1   
�������5@   1   5A      �� 5B      $	��250��6   $��2��5C      
�������$	 0.5Q�5E      �� 5I      $	 
Horizontal=�6   $��0,20,0,0q�66   .+�5J      G� -   5         G�Name$ 	textSifre��5J   "   $��	Helvetica)�65   $��Light"�5K      $ ********��5L       G� Password$  ��5M      $��20(�5N      $��Center=�5O      
�������
������ $��0q�5R      $	��235��5S      $
��Left=�5T      $	 0.5Q�5U      $��25��5V      $��63,0,0,0q�5W        5X      $	 Key=�61   $��Center=�5Y   1   $��Center=�5Z   1   
�������5[   1   5\      �� 5]      $	��250��6   $��2��5^      
�������$	 0.5Q�5`      �� 5c      $��Center=�6   $��50,25,50,25q�6:   .+�5d      �� -   5         ��Name$ btnGiris��5d      $	��100��6/   $��40��6;   $��Giriş��6G   $��	60,0,60,0q�6W   6j   5e      �� 5g      $
��Left=�6   .+�5h      �� -   5        $ btnCikis��5h      $��40��6/   $��40��6:   $��X��6F   $��15,0,0,0q�6R   6d   5i      5k      5r      5s      5t      