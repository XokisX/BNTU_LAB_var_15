   M S B A M L   `   `   `  ����@  <Lab_8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab_8Lab_8  5   	   U QInteractiveDataDisplay.WPF, Version=1.1.0.0, Culture=neutral, PublicKeyToken=nullkLclr-namespace:InteractiveDataDisplay.WPF;assembly=InteractiveDataDisplay.WPFInteractiveDataDisplay.WPF 6+       Lab_8.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Lab_8     5   	   [d3Lclr-namespace:InteractiveDataDisplay.WPF;assembly=InteractiveDataDisplay.WPF     6+     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5        $��Start��5
      $
��Left=�6!   $��145,389.016,0,0q�6<   $	��Top=�6U   $	��149��6m   6y   �� 5   
   $��Result��6   $
��Left=�6!   $��10,156.016,0,0q�6<   $	��Top=�6T   �� 5   
   -   5         ��Name$ 	resultBox��5      $
��Left=�6%   $	��191��6@   $��10,187.016,0,0q�6M    �� TextWrapping$
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��429��6�   �� 5   
   $��Input X value:��6   $
��Left=�6*   $��	10,43,0,0q�6E   $	��Top=�6X   �� 5   
   $��Input X value:��6   $
��Left=�6*   $��	10,74,0,0q�6E   $	��Top=�6X   �� 5   
   $��Input X value:��6   $
��Left=�6*   $��
10,105,0,0q�6E   $	��Top=�6Y   �� 5   
   -   5        $ inputX��5      $
��Left=�6"   $��23��6=   $��
108,45,0,0q�6I   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��331��6�   �� 5   
   -   5        $ inputY��5      $
��Left=�6"   $��23��6=   $��
108,77,0,0q�6I   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��331��6�   �� 5   
   -   5        $ inputZ��5      $
��Left=�6"   $��23��6=   $��108,108,0,0q�6I   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��331��6�   �� 5   
   $��Lab_1��6   $
��Left=�6!   $��	10,12,0,0q�6<   $	��Top=�6O   &   InteractiveDataDisplay.WPF.Chart  5   
   -   5          Name$ linear��5         BottomTitle$ Argument��6#      	LeftTitle$ Function��6:   $��448,45,31,44q�6O   .��5      *  $InteractiveDataDisplay.WPF.LineGraph  -   5          Name$ 	linegraph��5         Description$ Simple linegraph��62      Stroke
 ��  �	   StrokeThickness$	 3Q�6_   5      5      5      