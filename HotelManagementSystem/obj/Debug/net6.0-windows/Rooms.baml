   M S B A M L   `   `   `  ����P  LHotelManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HotelManagementSystemHotelManagementSystem  5   	   !    HotelManagementSystem.Rooms   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:HotelManagementSystem     5   	     � Title$  Rooms��5   	   $	��500��6   $	��800��6$   .��5	      � $��0,0,0,2q�6   .+�5
   
   ]� $��False��6   $��	0,0,0,408q�6*   
��� ���5      �� 5   
   $��Rooms Infomation��6   $��	0,0,0,408q�6+   $
��Bold"�6>   $��24(�6P   ���	#FF171BEF$	��230��6u   $��Center=�6�   �� 5   
   $
��Left=�6   $��552,120,0,0q�6+   $	��Top=�6@   �� 5   
   $��	Room List��6   $
��Left=�6$   $��
557,93,0,0q�6?   $	��Top=�6S   $��32��6k   $��86��6w   ���	#FFDE3131$��16(�6�   $
��Bold"�6�   �� 5   
   $��450,135,50,142q�6>    �� View 5      �� 5      .P�5      �� $��Room Number��6%    �� Width$	 100��6:   �� 5      $��Room Status��6%   $	 100��6:   �� 5      $��Booked��6%   $	 100��65   5      5      �� 5   
   -   5        $
��Left=�5      $��
82,135,0,0q�6-    �� TextWrapping$
 Wrap=�6A   $	��Top=�6U   $	��115��6m   $��32��6y   $��Room Number��6�   ���	#FFBB2323 �� TextAlignment$ Justify=�6�   $��16(�6  $��2,2,2,2q�6#  �� 5   
   $��
ROOMSTATUS��6   $
��Left=�6%   $��
76,187,0,0q�6@   $	��Top=�6T   $	��143��6l   $
��Bold"�6x   $��18(�6�   ���	#FFE223236�   �� 5   
   -   5         ��Name$ 
cb_Status_��5      $
��Left=�6'   $��224,187,0,0q�6B   $	��Top=�6W   $	��120��6o   $��34��6{    �� SelectedIndex$ 0��6�   $��16(�6�   .@�5      �� $��active��6   $��16(�6,   �� 5      $��	netactive��6   $��16(�6/   5      �� 5   
   $��BOOKED��6   $
��Left=�6!   $��
76,258,0,0q�6<   $	��Top=�6P   $��81��6h   $
��Bold"�6s   ���	#FFCE1E1E$��16(�6�   	� 5    
   $	��Yes��6   $
��Left=�6$   $��176,266,0,0q�6?   $	��Top=�6T   $��23��6l   $��16(�6x    d� 	IsChecked$
 trueY�6�   	� 5!   
   $��No��6   $
��Left=�6#   $��249,266,0,0q�6>   $	��Top=�6S   $��16(�6k   ]� 5"   
   $��False��6   $��	0,417,0,0q�6*   
��� ���6=   �� 5#   
   $��PowerByNhatWin��6   $��	0,417,0,0q�6)   $
��Bold"�6<   $��24(�6N   ���	#FF171BEF$	��230��6s   $
��Left=�6   $��Freestyle Script)�6�   �� 5$   
   $	��ADD��6   $
��Left=�6   $��
82,368,0,0q�6:   $	��Top=�6N   $��34��6f   $��45��6r   ���	#FF1B6311
�������
�������6�   �� 5%   
   $��UPDATE��6   $
��Left=�6"   $��176,368,0,0q�6=   $	��Top=�6R   $��46��6j   $��34��6u   ���	#FF1B6311
�������
�������6�   �� 5&   
   $��DELETE��6   $
��Left=�6"   $��269,368,0,0q�6=   $	��Top=�6R   $��34��6j   $��43��6v   ���	#FF1B6311
�������
�������6�   �� 5'   
   -   5        $
��BACK��5'      $
��Left=�6    $��706,368,0,0q�6;   $	��Top=�6P   $��34��6h   $��44��6t   ���	#FF1B6311
�������
�������6�   5(      5)      