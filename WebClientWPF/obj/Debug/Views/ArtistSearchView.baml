   M S B A M L   `   `   `  ����G  CWebClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WebClientWPF.ViewsWebClientWPF.Views  5      )    #WebClientWPF.Views.ArtistSearchView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:WebClientWPF.Views     5      
�������  � DataContext  5	      ��    ArtistSearchViewModel �� Source# [  .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6   $��10q�5      $��16(�6   ��6-   �� *	QueryText+�� 5   
   $��1��6   $��0��6   $��10q�5      $��16(�6    �� 	IsDefault . $��Search��6g   {�6=   �� *IsLoadButtonEnabled+��6x   �� *LoadArtistsCommand+�� 5   
   $��2��6   $��0��6!   $��14(�5      ��6"   �� *
StatusText+�� 5   
   $��3��6   $��0��6   ��5      �� *	Artists+ �� SelectedItem 62   �� *SelectedArtist+��5      �� 5      .R�5      ]� ��. .+�5       �� $��10q�6    $��54��6,   $
��Left=�6\   ��67   ��  �� Path$ Image[2].Url�6\   �� 5!      $��10q�6$   $��16(�60   ��6>   �� $
 Name�5"      5#      5%      �� 5&   
   $��0��6   $��1��6$   $��4��64   .��5'      �� $��Center=�5(        5'      �� *DetailedArtist+.+�5)      ��  �� Padding$ 25q�6   $��28(�6%   ��63   �� *Name+�� 5*      $��10q�6   $	��480��6    $
��Left=�6,   ��6B   �� *Image[3].Url+�� 5,      $ 15q�6   $��14(�6)   $
��Wrap=�67   ��6K   �� *Bio.Content+5-      5.      5/      50      