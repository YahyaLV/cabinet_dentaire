   M S B A M L   `   `   `  ����  Hospital Management System,    &Hospital_Management_System.AdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  AdminWindow��5   	    � WindowState$ 	Maximized=�6    � WindowStartupLocation$ CenterScreen=�65   $	��600��6Z   $	��800��6g   ��5      �� 5   
    �� ImageSource$ image/dentiste.jpg��6   .��5      �  � ColumnDefinitions 5	   
   �� 5
      $	��49* �6   �� 5      $	��16* �6   �� 5      $
��735* �6   .+�5   
   �� -   5         ��Name$ label��5      $)��#Connecté en tant qu'administrateur��6   $
��Left=�6L   $��	25,28,0,0q�6g   $	��Top=�6z   $��3��6�   
���  ��$��26��6�   �� 5   
   -   5         ��Name$ 	btnLogout��5      $��Logout��6$   $
��Left=�65   $��
34,505,0,0q�6P   $	��Top=�6d   $	��136��6|   $��3��6�   $��25��6�   �� 5   
   -   5        $ lblAdmin��5      $��Gestion des infirmiers : ��6"   $
��Left=�6F   $	��Top=�6a   $��
22,101,0,0q�6y   $��3��6�   �� 5   
   -   5        $ btnAddStaff��5      $��ajouter infermier ��6&   $
��Left=�6C   $��
36,138,0,0q�6^   $	��Top=�6r   $��25��6�   $	��146��6�   $��3��6�   ���	#FF87CEFA6�   �� 5   
   -   5        $ btnUpdateDeleteStaff��5      $��information de infirmiers��6/   $
��Left=�6S   $��
36,171,0,0q�6n   $	��Top=�6�   $��25��6�   $	��146��6�   $��3��6�   ���	#FF87CEFA6�   �� 5   
   -   5        $ btnAddDoctor��5      $��ajouter dentiste��6'   $
��Left=�6B   $��
36,267,0,0q�6]   $	��Top=�6q   $��25��6�   $	��146��6�   $��3��6�   ���	#FF87CEFA6�   �� 5   
   -   5        $ btnUpdateDeleteDoctor��5      $��information de dentists��60   $
��Left=�6R   $��
34,300,0,0q�6m   $	��Top=�6�   $��25��6�   $	��146��6�   $��3��6�   ���	#FF87CEFA6�    � 5   
   -   5          �Name$ 
adminFrame��5        � NavigationUIVisibility$ Hidden=�6$   $�� ��6D   $	��600��6O   $��235,0,-819,0q�6\   $	��Top=�6r   $��2��6�   �� 5   
   -	   5        $��
traitement��5      $
��Left=�6&   $��25��6A   $��
34,407,0,0q�6M   $	��Top=�6a   $	��136��6y   $��3��6�   ���	#FF87CEFA6�   �� 5   
   -
   5        $ lblAdmin_Copy��5      $��Gestion des dentists : ��6'   $
��Left=�6I   $	��Top=�6d   $��
24,222,0,0q�6|   $��3��6�   �� 5   
   -   5        $ lblAdmin_Copy1��5      $ ��Gestion des traitements : ��6(   $
��Left=�6M   $	��Top=�6h   $��
16,358,0,0q�6�   $��3��6�   �� 5   
   -   5        $ lblAdmin_Copy2��5      $��Se déconnecter :��6(   $
��Left=�6C   $	��Top=�6^   $��
22,459,0,0q�6v   $��3��6�   5      5      