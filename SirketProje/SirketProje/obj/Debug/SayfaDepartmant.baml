   M S B A M L   `   `   `  ����F  BSirketProje, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SirketProjeSirketProje  5   	   !    SirketProje.SayfaDepartmant   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SirketProje     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   -   5          � Title$  	Departman��5	   	   $��275.667��6   $��598.381��6,    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	datagrid1��5      $��
0,0,218,50q�6&   6:   �� 5   
   $
��Left=�6   $	��128��60   $��
395,10,0,0q�6=   $	��Top=�6Q   $	��193��6i   .+�5      �� $��3q�6    �� Orientation$ 
Horizontal=�6$   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$ DepartmanID��5   *      Kind$ Password=�6?   $��Center=�6O   
���   �6j   �� 5      -   5         ��Name$ textDepartmanID��5      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Departman ID��64   $	��166��6b   {�.  $��5q�6�   5      �� 5      $��3q�6   $ 
Horizontal=�6$   .+�5        -   5        $ IconUser��5   *   $ Class=�6<   $��Center=�6I   
���   �6d   �� 5      -   5        $ txtDepartmanAd��5      $	 Departman Adı��63   $	��165��6b   $��5q�6n   5      �� 5      $��3q�6   $ 
Horizontal=�6$   .+�5        -   5        $ 	IconGorev��5   *   $ AccountArrowLeft=�6=   $��Center=�6U   
���   �6p   �� 5      -   5        $ txtDepartmanGorev��5      $	 Departman Gorev��66   $	��166��6g   $��5q�6s   5      5!      �� 5"   
   $
��Left=�6   $��35��60   $��
10,231,0,0q�6<   $	��Top=�6P   $��43��6h   .+�5#      �� -	   5        
 ��Name$
 btnGeri��5#      
���   �$��40��6:   $��40��6E   $��30(�6Q   $	��←��6_   $��2,0,1,0q�6   5%      �� 5&      -
   5        $
 btnEkle��5&      $��35��6&   ���#00000D$
��Ekle��6G   $��385,191,113,50q�6V   $	��100��6n   6z   �� 5(      -   5        $
 btnGuncelle��5(      $��35��6*   ���#00000D$��	Güncelle��6K   $��488,191,10,50q�6^   $	��100��6v   6�   �� 5*      -   5        $
 btnSil��5*   "   $	��100��6   $��35��62   ���#00000D$	��Sil��6S   $��385,231,113,10q�6a   6y   �� 5+      -   5        $
 
btnTemizle��5+   "   $	��100��6   $��35��66   ���#00000D$��Temizle��6W   $��488,231,10,10q�6i   6�   5.      50      