   M S B A M L   `   `   `  ����C  ?WPF-CRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPF_CRUDWPF_CRUD  5          WPF_CRUD.ListPeoplePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:WPF_CRUD     5        N� Title$  ListPeoplePage��5	      .��5      �    GradientBackground#��[  6   .+�5   
   �� -   5        $��LvUsers��5   (   $��48,49,46,74q�6    �� AlternationCount$ 2��67   ��5      �� 5       �� 
TargetType" ��6   .�5      -   5        �� 5       �� Property � �� �� Value
 ��ح�63    �� Triggers 5      P� 5       P� Property �@��AlternationIndex P� Value$ 1��6G   . �5      ��  � ��
 �����6;   5      ]� 5       ]� 
Conditions 5      �� 5   "   	 �� Property	 �@��
IsSelected
 �� Value
 . 6B   ./�5      ��  � ��
 ���_�6;   5      5       �� View 5      �� 5      .P�5       ��  �� Width$	 100��6%   $��	FirstName��61    �� DisplayMemberBinding 6D   �� *	FirstName+�� 5!      $	 100��6%   $��LastName��61    6C   �� *
LastName+�� 5"      $	 100��6%   $	��Age��61    6>   �� *Age+�� 5#      $	 100��6%   $��Email��61    �� CellTemplate 5$      �� 5%      .R�5&   "   �� $��	Underline{�6C   
���   � � Cursor$
 Hand��6r   ��6,   �� *Email+ � ToolTip 5'   &   �� 5(   *    ��Name$ Picture��60   $��60��6Z   $��60��6e   $��0,0,5,0q�6q   ��6A   �� *Image+6q   5*   #   5+      5-      �� 5.      $	 100��6%   $��
Profession��61    6E   �� *ProfessionName+5/      51      �� 53   
   -   5         ��Name$ BtnEdit��54      $
��Edit��55      $
��Left=�56      $	��Top=�57      $��75��58      
����������#13242C J� RenderTransformOrigin$ 1.101,3.807&�5;   #   $��402,363,0,0q�6G   �� 5<   
   -   5        $ 	BtnDelete��5=      $��Delete��5>      $
��Left=�5?      $	��Top=�5@      $��75��5A      
����������	#FFD41B43$ 1.101,3.807&�5D   %   $��499,363,0,0q�6I   �� 5E   
   -   5        $ BtnAdd��5F      $	��Add��5G      $
��Left=�5H      $	��Top=�5I      $��75��5J      
����������	#FF246844$ 1.101,3.807&�5M   "   $��302,363,0,0q�6F   �� 5N   
   -   5        $ 	BtnChange��5O      $��
Profession��5P      $
��Left=�5Q      $	��Top=�5R      $��75��5S      
�������
��� ���$ 1.101,3.807&�5V   %   $��
28,363,0,0q�6I   5W      5X      