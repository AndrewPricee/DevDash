   M S B A M L   `   `   `  ����B  >Tracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TrackerTracker  5   	        Tracker.RegistrationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Tracker     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	     � WindowStyle$
  None=�5
   	    � WindowState$ Normal=�5   	    � 
ResizeMode$ NoResize=�5   	   $��13(�5   	   ���#222222 � Title$ Registration��5   	   $	��600��6   $	��600��6+   .��5      � .+�5   
   �� -   5         ��Name$ btnClose��5      $��X��6#   $��Right=�6/   $	��Top=�6K   $��40��6c   $��40��6n   $
��Bold"�6z   $
��Lato)�6�   $��14(�6�   
������ $��0,5,4,0q�6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 ���� 63   �� 5       � ��
 �����63   �� 5       �@�Cursor$
 Hand��6/   �� 5       � �� 5      �� 5       �� 
TargetType" ��6.   .R�5   "   �� #��z��6)   ._�5   &   �� $��Center=�67   $��Center=�6T   5   #   5      5      	 �� Triggers	 5       P� 5!      
 P� Property
 �@J�IsMouseOver P� Value . . �5"      ��  � ��
 ���� 6;   �� 5#       � �� �#00aeef6;   5$      5&      5(      �� 5)   
   -   5        $��37,3,49,442q�5)      
������ 6o   �� 5*   
    �� Padding$ 0q�6   $	��Top=�6    $
��Left=�68   $��75(�6S   $��10,0,0,0q�6b   !  FontAwesome.WPF.FontAwesome  5+         Icon$ 	CaretDown=�6   ���#EF40366.   5,      �� 5-   
   $ 0q�6   $	��Top=�6    $
��Left=�68   $��50(�6S   $��	17,12,0,0q�6b     5.      $ 	CaretDown=�6   ���#2222226.   5/      �� 50   
   $	��Dev��6   
�������$��8(�61   $
��Left=�6>   $��	34,39,0,0q�6Y   $	��Top=�6l   $��24��6�   $��19��6�   �� 51   
   $
��Dash��6   ���#EF4036$��8(�64   $
��Left=�6A   $��	47,39,0,0q�6\   $	��Top=�6o   $��19��6�   $��29��6�   �� 52   
   $��Registration��6   
�������$��30(�6:   $��216,23,216,0q�6H   $	��Top=�6^   �� 53   
   -   5        $��	UserEmail��53      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Email (Username)��6#    �� 
CaretBrush
 ����� %  !MaterialDesignFloatingHintTextBox#��[  6h   
�������
������ 
�������$��65��6�   $��162,107,162,0q�6�    �� TextWrapping$
 Wrap=�6  $	��Top=�6'  �� 54   
   -   5        $��UserFirstName��54      $ 
First Name��6'   
 �����#��[  6f   
�������
������ 
�������$��72��6�   $��162,173,162,0q�6�   $
 Wrap=�6  $	��Top=�6%  �� 55   
   -   5        $��UserSurname��55      $ Surname��6%   
 �����#��[  6a   
�������
������ 
�������$��69��6�   $��162,245,162,0q�6�   $
 Wrap=�6  $	��Top=�6   G� 56   
   -   5        $��UserPassword��56      $ Password��6*    G� 
CaretBrush
 ����� ) %MaterialDesignFloatingHintPasswordBox#��[ 6g   
�������
������ 
�������$��65��6�   $��162,319,162,0q�6�   $	��Top=�6  G� 57   
   -   5        $��UserConfirmPassword��57      $ Confirm Password��61   
 �����#��[ 6v   
�������
������ 
�������$��65��6  $��162,385,162,0q�6  $	��Top=�6%  �� 58   
   -   5        $��RegisterButton��58      $��Register��6'   
����������#EF4036$��216,501,216,0q�6b   $	��Top=�6y   6�   5:      5;      