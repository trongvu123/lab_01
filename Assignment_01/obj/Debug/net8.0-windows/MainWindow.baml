   M S B A M L   `   `   `  ����H  DAssignment_01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Assignment_01Assignment_01  5   	       Assignment_01.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Assignment_01     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Product Management��5
   	   $	��670��6$   $	��710��61   .��5      � ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #0099FF��6    � Offset$ 0Q�6/   � 5      $ 	#FF347BDA��6   $ 0.794Q�61   � 5      $ 	#FF60B1E7��6   $ 1Q�61   � 5      $ 	#FF596FDD��6   $ 0.309Q�61   � 5      $ 	#FF472FDE��6   $ 0.484Q�61   5       � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5       $	��150 �6   �� 5!      $	��150 �6   �� 5"      $��* �6   �� 5#      $��* �6   .+�5&   
   �� -   5         ��Name$ label��5&      $��Product Management��6   $��0��6<   $��0��6L   $��36(�6Y   $��4��6g   $��Center=�6{   �� 5(   
   -   5        $ label1��5(      $��2q�6    $��
Product ID��6+   $��0��6@   $��1��6P   $��2��6]   �� 5)   
   -   5        	 ��Name$	 txtProductID��5)      $��4q�6(   $��2��63   $��1��6C   
 �� TextWrapping$

 Wrap=�6P   $��2��6d   ${�False��6x   �� 5+   
   -   5        $ label2��5+      $��2q�6    $��0��6+   $��2��6;   $��Product Name��6H   $��2��6_   �� 5,   
   -   5        $	 txtProductName��5,      $��4q�6*   $��2��65   $��2��6E   $

 Wrap=�6R   $��2��6f   �� 5.   
   -   5        $ label8��5.      $��2q�6    $��Price��6+   $��0��6;   $��3��6K   $��2��6X   �� 5/   
   -   5        $	 txtPrice��5/      $��4q�6$   $��2��6/   $��3��6?   $

 Wrap=�6L   $��2��6`   �� 51   
   -	   5        $ label3��51      $��2q�6    $��Units In Stock��6+   $��0��6D   $��4��6T   $��2��6a   �� 52   
   -
   5        $	 txtUnitsInStock��52      $��4q�6+   $��2��66   $��4��6F   $

 Wrap=�6S   $��2��6g   �� 54   
   -   5        $ label4��54      $��2q�6    $��Category��6+   $��0��6>   $��5��6N   $��2��6[   �� 55   
   -   5         ��Name$ cboCategory��55      $��4q�6(   $��2��63   $��5��6C   $��2��6P   &   System.Windows.Controls.DataGrid  57   
   -   5          Name$ dgData��57      $��4q�6#   $��0��6.   $��6��6>   $��4��6K      AutoGenerateColumns$ False��6_      Columns 58      0  *System.Windows.Controls.DataGridTextColumn  59      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	ProductId+  5:      $
 Name��6%    63   �� *ProductName+  5;      $ Price��6%    64   �� *	UnitPrice+  5<      $ Stock��6%    64   �� *UnitsInStock+  5=      $ Category ID��6%    6:   �� *
CategoryId+5?      �� 5A   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��7��6K   $��0��6X   $��4��6h   .+�5B      �� -   5         ��Name$ 	btnCreate��5B      $��Create��6(   $��5q�69   $	��121��6D   ���	#FF0099FF
�������
�������6�   �� 5C      -   5        $ 	btnUpdate��5C      $��Update��6(   $��5q�69   $	��121��6D   ���	#FF1B7140
�������6z   �� 5D      -   5        $ 	btnDelete��5D      $��Delete��6(   $��5q�69   $	��121��6D   
����������	#FFA2AA3D6z   �� 5E      -   5        $ btnClose��5E      $��Close��6'   $��5q�67   $	��121��6B   ���	#FFEF8F18
�������6x   5F      5G      5H      