   M S B A M L   `   `   `  ����G  CWebClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WebClientWPFWebClientWPF  5   	   7 clr-namespace:WebClientWPF.ViewsWebClientWPF.Views  5   	       WebClientWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WebClientWPF     5   	   1view clr-namespace:WebClientWPF.Views     5   	     � Title$  
MainWindow��5	   	    � DataContext 6   ��    MainViewModel �� Source# [  .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   o� $��0��6    o� 
IsMainMenu . .@�5      m� $��_File��6   .@�5      m� $
��Exit��6    m� Command 6)   �� *CloseWindowCommand+5      5      )   #WebClientWPF.Views.ArtistSearchView  5   
   $��1��6    5   
   5      