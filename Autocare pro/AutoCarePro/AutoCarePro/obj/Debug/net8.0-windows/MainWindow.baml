   M S B A M L   `   `   `  ����F  BAutoCarePro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AutoCareProAutoCarePro  5   	       AutoCarePro.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AutoCarePro     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      � -   5         �Name$
 grid��5
      .+�5   
   �� $b��\C:\Users\User\Desktop\Autocare pro\AutoCarePro\AutoCarePro\istockphoto-495378164-612x612.jpg��6   $
��Fill=�6v   $��0��6�   $��2��6�   ]� 5   
   $��False��6   $	��Top=�6*   
�������$��34��6U   .+�5      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�62   $��Center=�6H   $��20,0,0,0q�6c   .+�5      �� $��	AutoCare ��6   $��Pacifico)�6-   $��18(�6C   ���#E74C3C$
��Bold"�6f   �� 5      $	��Pro��6   $��Courier New)�6'   $��15(�6@   
���   �$
��Bold"�6a   $��3,3,0,0q�6s   5      �� 5      $ 
Horizontal=�6   $��210,0q�62   $	��235��6A   .+�5      �� -   5        $
��Home��5      
 � Tag$
 home��6(   
�������$��0q�6e   $��15(�6y   $	��0,0q�6�   �� 5      -   5        $��About��5      $ about��6)   
�������$��0q�6g   $��15(�6{   $
��10,0q�6�   �� 5      -   5        $��Register��5      $ register��6,   
�������$��0q�6m   $��15(�6�   $
��10,0q�6�   �� 5      -   5        $��Login��5      $ login��6)   
�������$��0q�6g   $��15(�6{   $
��10,0q�6�   5      5      �� 5!   
   $��Center=�6   $	��top=�62   $��0,30,0,0q�6J   .+�5"      �� $��Welcome to AutoCare Pro��6   $��50q�67   $��36(�6C   $
��Bold"�6Q   
���   �6c   �� 5#      $"��Garage and Car Wash Services��6   $��24(�6<   
������� �� TextAlignment$ Center=�6b    J� RenderTransformOrigin$ 0.509,-0.969&�6y   $��31��6�   5$      �� 5'   
   $ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   $��0,0,0,50q�6f   .+�5)      �� 
������� �� Padding$ 10q�6(   $��10q�65    �� CornerRadius$ 8��6A   $	��300��6R   ._�5*      �� .+�5+      �� $��Garage Booking��6    $��16(�66   $
��Bold"�6D   $��0,0,0,10q�6V   �� 5,      $ 
Horizontal=�6!   $	��0,5q�6:   .+�5-      �� $��Check-in Date:��6$   $��Center=�6:   $	��100��6U   (  "System.Windows.Controls.DatePicker  5.      -   5          Name$ GarageCheckInDatePicker��5.   %   $	��150��6F   5/      �� 50      $ 
Horizontal=�6!   $	��0,5q�6:   .+�51      �� $��Vehicle Type:��6$   $��Center=�69   $	��100��6T   �� 52      -   5        	 ��Name$	 GarageVehicleTypeComboBox��52   #   $	��150��6F   .@�53      �� $
��Bike��6+   �� 54      $	��Car��6+   �� 55      $	��Van��6+   �� 56      $��Lorry��6+   57      58      �� 59      -   5        $��book Garage ��59      
���  ��
�������$��14(�6X   $��0,10,0,0q�6f   6x   5:      5;      �� 5>      
�������$ 10q�6(   $��10q�65   $ 8��6A   $	��300��6R   ._�5?      �� .+�5@      �� $��Car Wash Booking��6    $��16(�68   $
��Bold"�6F   $��0,0,0,10q�6X   �� 5A      $ 
Horizontal=�6!   $	��0,5q�6:   .+�5B      �� $��Check-in Date:��6$   $��Center=�6:   $	��100��6U     5C      -	   5        $ CarWashCheckInDatePicker��5C   %   $	��150��6G   5D      �� 5E      $ 
Horizontal=�6!   $	��0,5q�6:   .+�5F      �� $��Vehicle Type:��6$   $��Center=�69   $	��100��6T   �� 5G      -
   5        $ 	 CarWashVehicleTypeComboBox��5G   #   $	��150��6G   .@�5H      �� $
��Bike��6+   �� 5I      $	��Car��6+   �� 5J      $	��Van��6+   �� 5K      $��Lorry��6+   5L      5M      �� 5N      -   5        $��Book Car Wash��5N      
���  ��
�������$��14(�6Y   $��0,10,0,0q�6g   6y   5O      5P      5Q      �� 5T   
   $0��*© 2025 AutoCare Pro. All rights reserved.��6   $��Center=�6E   $��Bottom=�6b   
�������$��0,0,0,10q�6�   5U      5W      