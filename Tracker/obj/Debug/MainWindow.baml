   M S B A M L   `   `   `  ����B  >Tracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TrackerTracker  5   	       Tracker.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Tracker     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	     � WindowStyle$
  None=�5
   	    � WindowState$ Normal=�5   	    � 
ResizeMode$ NoResize=�5   	   $��13(�5   	   ���#222222 � Title$ 
MainWindow��5   	   $	��430��6   $	��650��6)   .��5      � .+�5   
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
   -   5        $��37,3,49,385q�5)      
������ 6o   �� 5*   
    �� Padding$ 0q�6   $	��Top=�6    $
��Left=�68   $	��200(�6S   $��268,0,268,285q�6c   !  FontAwesome.WPF.FontAwesome  5+         Icon$ 	CaretDown=�6   ���#EF40366.   5,      �� 5-   
   $ 0q�6   $	��Top=�6    $
��Left=�68   $	��100(�6S   $��295,50,295,305q�6c     5.      $ 	CaretDown=�6   ���#2222226.   5/      �� 50   
   $	��Dev��6   
�������$
��Left=�61   $��362,150,0,0q�6L   $	��Top=�6a   $��46��6y   �� 51   
   $
��Dash��6   ���#EF4036$
��Left=�64   $��385,150,0,0q�6O   $	��Top=�6d   �� 53   
   -   5        $��UserName��53      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��6"    �� 
CaretBrush
 ����� %  !MaterialDesignFloatingHintTextBox#��[  6_   
�������
������ 
�������$��65��6�   $��215,183,215,0q�6�    �� TextWrapping$
 Wrap=�6
  $	��Top=�6  G� 54   
   -   5        $��Password��54      $ Password��6'    G� 
CaretBrush
 ����� ) %MaterialDesignFloatingHintPasswordBox#��[ 6d   
�������
������ 
�������$
��Left=�6�   $��215,244,0,0q�6
  $	��Top=�6  $	��212��67  $��65��6C  �� 55   
   -   5        $��LoginButton��55      $��Login��6$   
������ ���#EF4036
�������$��234,350,234,0q�6v   $	��Top=�6�   $��34��6�   6�   �� 56   
   -   5        $��RegisterAccountButton��56      ���#888888
������ ���#888888$��Set up an Account��6r   $��235,388,235,0q�6�   $	��Top=�6�   $��30��6�   6�   57      58      