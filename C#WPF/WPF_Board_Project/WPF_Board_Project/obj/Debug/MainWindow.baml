   M S B A M L   `   `   `  ����L  HWPF_Board_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WPF_Board_ProjectWPF_Board_Project  5   	   "    WPF_Board_Project.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WPF_Board_Project     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��700��6)   .��5	      �� .+�5
   
   �� -   5         ��Name$	 Add��5
      .��6@   게시판 목록 가져오기6M   �� 5   
   -   5         ��Name$ 
txtReqData��5      6(   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ gridBoardList��5         AutoGenerateColumns .   � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5      "  6   .�5      ��  � ��
 ���@�63   �� 5       � ��$ SemiBold"�63   �� 5       � ��$ 0,0,1,2q�68   �� 5       � ��
 �   �64   5      5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 No��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *No+6H     5      $
 Title��6%   $	 100 6N    64   �� *Title+6N     5      $
 Content��6%   $	 100 6R    66   �� *	Content+6R     5      $
 Writer��6%   $	 100 6P    65   �� *Writer+6P     5      $
 	WriteDate��6%   $	 100 6V    68   �� *	WriteDate+6V     5      $	
 Hit��6%   $	 100 6J    62   �� *Hit+6J     5      $
 Password��6%   $	 100 6N    67   �� *PW+6N   5      �� 5   
   -   5        $ 
txtRepData��5      $	��100��6&   65   5       5!      