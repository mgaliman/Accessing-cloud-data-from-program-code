   M S B A M L   `   `   `  ����C  ?WPF-CRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPF_CRUDWPF_CRUD  5      !    WPF_CRUD.ListProfessionPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:WPF_CRUD     5        N� Title$  ListProfessionPage��5	      .��5      �    GradientBackground#��[  6   .+�5   
   �� -   5        $��LvProfessions��5   *   $��153,53,157,70q�6    �� AlternationCount$ 2��6?   ��5      �� 5       �� 
TargetType" ��6   .�5      -   5        �� 5       �� Property � �� �� Value
 ��ح�63    �� Triggers 5      P� 5       P� Property �@��AlternationIndex P� Value$ 1��6G   . �5      ��  � ��
 �����6;   5      ]� 5       ]� 
Conditions 5      �� 5   "   	 �� Property	 �@��
IsSelected
 �� Value
 . 6B   ./�5      ��  � ��
 ���_�6;   5      5       �� View 5      �� 5      .P�5       ��  �� Width$	 280��6%   $��
Profession��61    �� DisplayMemberBinding 6E   �� *ProfessionName+5!      5#      �� 5%   
   -   5         ��Name$ BtnEdit��5&      $
��Edit��5'      $
��Left=�5(      $	��Top=�5)      $��75��5*      
����������#13242C J� RenderTransformOrigin$ 1.101,3.807&�5-   #   $��394,363,0,0q�6G   �� 5.   
   -   5        $ 	BtnDelete��5/      $��Delete��50      $
��Left=�51      $	��Top=�52      $��75��53      
����������	#FFD41B43$ 1.101,3.807&�56   %   $��491,363,0,0q�6I   �� 57   
   -   5        $ BtnAdd��58      $	��Add��59      $
��Left=�5:      $	��Top=�5;      $��75��5<      
����������	#FF246844$ 1.101,3.807&�5?   "   $��294,363,0,0q�6F   �� 5@   
   -   5        $ 	BtnChange��5A      $��Person��5B      $
��Left=�5C      $	��Top=�5D      $��75��5E      
�������
��� ���$ 1.101,3.807&�5H   %   $��
28,363,0,0q�6I   5I      5J      