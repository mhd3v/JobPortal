   M S B A M L   `   `   `  ����  	JobPortal     JobPortal.ViewApplications   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5	   
     MaterialDesignFont#���  5
   
    � Title$ ViewApplications��5   	   $	��590��6"   $	��800��6/    � WindowStartupLocation$ CenterScreen=�6;    � 
ResizeMode$ NoResize=�6`    � ShowInTaskbar .  .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      $��8* �6   6*    � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��3* �6   6,   .+�5   
   �� $��2��6   $��1��6)   ���	#FF302D2D$��Center=�6Q   $��60��6l   .+�5      �� $��Center=�6   
�������$��0 10 0 0q�6D   $��Segoe WP Light)�6V   $
��Bold"�6r   $��24(�6�   .��6�   Job Applications6�   5      �� 5   
   -   5        $	��100��5      $��39��6   $
��Left=�6)   $
��Back��6D   ���	#FF302D2D
�������6~   �� 5   
   -   5        $��Error��5      $��2��6"   $��2��66   $��Center=�6G   $��Center=�6b   $y�Hidden=�6   .+�5       �� $��Italic$�6   $��10(�6'   .��65    No job applications to show :(6U   5!      �� 5%   
   -   5        $��SideBar��5%   "   $��2��6   ���	#FFC1C1C1.+�5'      �� $��Center=�6   $
��Bold"�61   .��6C   
Candidates6O   �� 5)      -   5        $��CandidateList��5)      $��1��6+   ��5+      �� 5,      .R�5-      �� $��	ListLabel��6    ��61   ��  �� Path$ CandidateName�6Z   5.      51      53      �� 55   
   -   5        $��CandidateProfile��55   2   $��2��6   $��2��6%   .+�57      �� $��Center=�6   $
��Bold"�61   .��6C   Candidate Application6Z   �� 5?      $��30q�6   .+�5@      �� $��Italic$�6   Applied for:6=   �� 5A      -   5        $��	cUserName��5A   .   $��0 0 0 10q�6   $
��Bold"�6�   ��6?   �� 	 �� ElementName$	 CandidateList��$ SelectedItem.AppliedFor�6�   �� 5C      $��Italic$�6   Candidate Age:6?   �� 5D      -   5        $
��cAge��5D   .   $��0 0 0 10q�6   $
��Bold"�6�   ��6:   �� $	 CandidateList��$ SelectedItem.CandidateAge�6�   �� 5F      $��Italic$�6   Candidate GPA:6?   �� 5G      -   5        $
��cGpa��5G   .   $��0 0 0 10q�6   $
��Bold"�6�   ��6:   �� $	 CandidateList��$ SelectedItem.CandidateGPA�6�   �� 5I      $��Italic$�6   Candidate Experience:6F   �� 5J      -	   5        $
��cExp��5J      $
��Bold"�6z   ��6(   �� $	 CandidateList��$&  SelectedItem.CandidateExperience�6�   �� 5K      -
   5        $��	0 240 0 0q�5K      $	��150��6,   ���	#FF302D2D���	#FF302D2D$��Call for interview��6g   6�   5L      5P      5R      5S      