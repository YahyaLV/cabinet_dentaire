   M S B A M L   `   `   `  ����  Hospital Management System,    &Hospital_Management_System.StaffWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  StaffWindow��5   	    � WindowState$ 	Maximized=�6    � WindowStartupLocation$ CenterScreen=�65   $	��600��6Z   $	��800��6g   ��5      �� 5   
    �� ImageSource$ image/qs.jpg��6    j� Stretch$ UniformToFill=�60   .��5	      � .+�5
   
   �� -   5         ��Name$ 
lblPatient��5
      $��
Patient : ��6$   $
��Left=�69   $	��Top=�6T   $��
10,107,0,0q�6l   �� 5   
   -   5         ��Name$ btnAdmitPatient��5      $��ajouter Patient��6*   $
��Left=�6D   $��25��6_   $��
34,156,0,0q�6k   $	��Top=�6   $	��136��6�   ���	#FF87CEFA6�   �� 5   
   -   5        $ btnPatientDetails��5      $��information de patients��6,   $
��Left=�6N   $��25��6i   $��
33,203,0,0q�6u   $	��Top=�6�   $	��136��6�    J� RenderTransformOrigin$ 0.526,-0.585&�6�   ���	#FF87CEFA6�   �� 5   
   -   5        $ lblSupplier��5      $ ��Gestions des ordonances : ��6%   $
��Left=�6J   $��	8,325,0,0q�6e   $	��Top=�6x   �� 5   
   -   5        $ 
btnAddView��5      $��
ordonnance��6%   $
��Left=�6:   $��25��6U   $��
34,380,0,0q�6a   $	��Top=�6u   $	��136��6�   ���	#FF87CEFA6�    � 5   
   -   5          �Name$ 
staffFrame��5      	  � NavigationUIVisibility$	 Hidden=�6$   $�� ��6D   $
��Left=�6O   $	��600��6j   $��	250,0,0,0q�6w   $	��Top=�6�   $
��1000��6�   �� 5   
   -   5        $ label��5      $%��Connecté en tant que personnel��6   $
��Left=�6H   $��	12,25,0,0q�6c   $	��Top=�6v   �� 5   
   -   5        $ button��5      $��Logout��6!   $
��Left=�62   $��
34,487,0,0q�6M   $	��Top=�6a   $	��136��6y   $��25��6�   �� 5   
   -	   5        
 ��Name$
 loginAsStaff��5      $
��Left=�6(   $��20��6C   $��	34,51,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��136��6�   {�.  6�   �� 5   
   -
   5        $ lblSupplier_Copy��5      $��Se déconnecter :��6*   $
��Left=�6E   $��	8,446,0,0q�6`   $	��Top=�6s   5      5      