   M S B A M L   `   `   `  ����A  =NetSim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NetSim.DetailPagesNetSim.DetailPages  5      #    NetSim.DetailPages.ClientPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:NetSim.DetailPages     5        N� Title$  
ClientPage��5	      .��5      �� $��5,5,5,5q�6   
�������$��2q�65   ._�5   
   � 
������� � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��0��6   $��0��6(   $
��Bold"�65   Client6P   �� 5      $��1��6   $��0��6(   ��65   ��  �� Path$ 	Client.Id�6X   �� 5      $��0��6   $��1��6(   $��0 0 0 10q�65   Client Step6U   �� 5      $��1��6   $��1��6(   ��65   �� $ Client.StepCounter�6a   �� 5      $��0��6   $��2��6(   $��0 5 0 0q�65   $
��Bold"�6F   Table6`   �� 5      $��0��6   $��3��6(   $��2��65   $��Consolas)�6�   ��6I   �� $( "Client.RoutingProtocol.RoutingData�6�   �� 5       $��0��6   $��4��6(   $��0 5 0 0q�65   $
��Bold"�6F   Received Data6h   �� 5!      $��0��6   $��5��6(   $��2��65   $��Consolas)�6r   ��6I   �� $ Client.CurrentData�6�   5"      5#      5$      