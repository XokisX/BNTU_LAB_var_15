   M S B A M L   `   `   `  ����@  <Lab_6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab_6Lab_6  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       Lab_6.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Lab_6     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � .+�5   
   �� -   5         ��Name$ 	InputName��5      $
��Left=�6%   $��23��6@   $��	96,13,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��245��6�   �� 5   
   $��Name:��6   $
��Left=�6    $��	46,10,0,0q�6;   $	��Top=�6N   �� 5   
   -   5        $ 	InputMark��5      $
��Left=�6%   $��23��6@   $��	96,37,0,0q�6L   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��245��6�   �� 5   
   $��Mark:��6   $
��Left=�6    $��	46,34,0,0q�6;   $	��Top=�6N   �� 5   
   $��Status:��6   $
��Left=�6"   $��	46,60,0,0q�6=   $	��Top=�6P   �� 5   
   $��Mark:��6   $
��Left=�6    $��
46,144,0,0q�6;   $	��Top=�6O   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ 	InputDate��5      $
��Left=�6&   $��
96,144,0,0q�6A   $	��Top=�6U   �� 5   
   -   5         ��Name$ InputStatus��5      $
��Left=�6'   $��68��6B   $��	96,65,0,0q�6N   $	��Top=�6a   $	��245��6y   .@�5      ��In_progress��6)   ��5      	Ready��6#   ��5      
Finish��6$   5      �� 5   
   -   5        $��Create or Open��5      $
��Left=�6*   $��
33,374,0,0q�6E   $	��Top=�6Y   $	��149��6q   6}   �� 5   
   -   5        $
��Save��5      $
��Left=�6    $��215,374,0,0q�6;   $	��Top=�6P   $��75��6h   6s   �� 5   
   -   5        $��Close��5      $
��Left=�6!   $��324,374,0,0q�6<   $	��Top=�6Q   $��75��6i   6t   �� 5   
   -   5         ��Name$ ButtonWrite��5      $��Write��6&   $
��Left=�66   $��
96,318,0,0q�6Q   $	��Top=�6e   $	��140��6}   $��29��6�   $y�Hidden=�6�   &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ 
ResultGrid��5   /      AutoGenerateColumns . $
��Left=�6C   $	��299��6^   $��
392,13,0,0q�6k   $	��Top=�6   $	��380��6�   5"      �� 5#   
   -
   5        $��Sort by current day��5#      $
��Left=�6/   $��392,317,0,0q�6J   $	��Top=�6_   $	��151��6w   $��30��6�   6�   �� 5$   
   -   5        $	��All��5$      $
��Left=�6   $��621,317,0,0q�6:   $	��Top=�6O   $	��151��6g   $��30��6s   6   5&      5'      