   M S B A M L   `   `   `  ����  	JobPortal     JobPortal.CreateJobListing   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6@      MaterialDesignBody#���   5   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignFont#���  5	   
    � Title$ Create Job Listing��5
   	   $	��590��6$   $	��800��61    � WindowStartupLocation$ CenterScreen=�6=   .��5      � ���	#FFC1C1C1.+�5   
   #  MaterialDesignThemes.Wpf.Card  $��32q�6   $��
16,16,16,0q�6+   ���	#FFF7F7F7$	��505��6V   .��5      �� .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0 0 0 20q�66   .+�5      �� $
��Bold"�6   .��6.   Listing Title:6>   �� 5      -   5        $��listingTitle��5      $��50 0 0 0q�62   $	��450��6D   6R   5      �� 5      .+�5      �� $
��Bold"�6   .��6.   Listing Description:6D   �� 5      -   5        $��listingDescription��5       �� TextWrapping$
 Wrap=�68    �� AcceptsReturn . " �� VerticalScrollBarVisibility$ Visible=�6a   $��70��6�   6�   5      �� 5      $ 
Horizontal=�6   $��0 10 0 0q�66   $��Center=�6H   .+�5      	� -   5        $��	OpenToAll��5   E    d� 	IsChecked$
 TrueY�6"   $��0 0 20 0q�63   ���	#FF302D2D���	#FF302D2D.��6�   Open To All6�   	� 5      -   5        $��SelectedRequirements��5   "   ���	#FF302D2D���	#FF302D2D.��6�   Selected Requirements6�   5       �� 5"      -   5        $��Requirements��5"      $y�Hidden=�61   $��	0 10 0 10q�6E   .+�5$      �� $
��Bold"�6   .��6.   Age Requirement:6@   �� 5%      -   5        $	��Age��5%      5&      �� 5(      $
��Bold"�6   .��6.   GPA Requirement:6@   �� 5)      -   5        $	��Gpa��5)      5-      �� 5/      $
��Bold"�6   .��6.   Experience Requirement:6G   �� 50      -   5        $��
Experience��50      51      54      �� 56      -	   5        $��Cancel��56      $	��100��6'   ���	#FF302D2D���	#FF302D2D.��6w   Cancel6   �� 57      -
   5        $��CreateListing��57      $	��120��6.   $��0 10 0 0q�6:   ���	#FF302D2D���	#FF302D2D.��6�   Create Listing6�   58      5:      5;      5<      