   M S B A M L   `   `   `  ����V  RInventory-Management-System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Inventory_Management_SystemInventory_Management_System  5   	   Y1clr-namespace:InventoryManagementSystem.ViewModel#InventoryManagementSystem.ViewModel  6A   ,    &Inventory_Management_System.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Inventory_Management_System     5   	   @vm1clr-namespace:InventoryManagementSystem.ViewModel     6A     � Title$  
MainWindow��5   	   $	��579��6   $	��808��6)    � DataContext 5	      :  4InventoryManagementSystem.ViewModel.ProductViewModel  5
   
   .��5      � $	��250��6   $	��Top=�6    � ColumnDefinitions 5   
   �� 5      $
��123* �6   �� 5      $	��37* �6   .+�5   
   �� -   5         ��Name$ ProductIDLabel��5      $��Product ID:��6(   $
��Left=�6>   $��25��6Y   $��	43,40,0,0q�6e   $	��Top=�6x   $	��107��6�   �� 5   
   -   5        $ ProductNameLabel��5      $��Product Name:��6*   $
��Left=�6B   $��25��6]   $��	43,75,0,0q�6i   $	��Top=�6|   $	��107��6�   �� 5   
   -   5        $ ProductQuantityLabel��5      $��	Quantity:��6.   $
��Left=�6B   $��25��6]   $��
43,110,0,0q�6i   $	��Top=�6}   $	��107��6�   �� 5   
   -   5        $ PurchaseDateLabel��5      $��Purchase Date:��6+   $
��Left=�6D   $��25��6_   $��
43,145,0,0q�6k   $	��Top=�6   $	��107��6�   �� 5   
   -   5         ��Name$ ProductIDTextBox��5      $
��Left=�6,   $��25��6G   $��
160,42,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��255��6�   ��6�   �� *
Product.ID+ �� Mode$ TwoWay=��� 5   
   -   5        $ ProductNameTextBox��5      $
��Left=�6.   $��25��6I   $��
160,77,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��255��6�   ��6�   �� *Product.Name+$ TwoWay=��� 5   
   -   5        $ ProductQuantityTextBox��5      $
��Left=�62   $��25��6M   $��160,110,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��255��6�   ��6�   �� *Product.Quantity+$ TwoWay=�(  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ PurchaseDateTextBox��5      $
��Left=�62   $��25��6M   $��160,147,0,0q�6Y   $	��Top=�6n   $	��255��6�      DisplayDate$  ��6�   	   Text	 6�   �� *Product.PurchaseDate+$ TwoWay=��� 5   
   -	   5        
 ��Name$
 AddNewButton��5      $��Add New��6'   $
��Left=�69   $��160,190,0,0q�6T   $	��Top=�6i   $��75��6�   ��6�   �� *
AddCommand+�� 5    
   -
   5        $
 UpdateButton��5       $��Update��6'   $
��Left=�68   $��250,190,0,0q�6S   $	��Top=�6h   $��75��6�   ��6�   �� *UpdateCommand+�� 5!   
   -   5        $
 DeleteButton��5!      $��Delete��6'   $
��Left=�68   $��340,191,0,0q�6S   $	��Top=�6h   $��75��6�   ��6�   �� *DeleteCommand+&   System.Windows.Controls.DataGrid  5#   
   -   5          Name$ InventoryTable��5$      $	��263��5%      $��43,262,39,-275q�6   $	��Top=�5&      $��2��6%      SelectionUnit$ FullRow=�5(         SelectionMode$ Single=�5)         
IsReadOnly .    AutoGenerateColumns .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5-       �� SelectedItem 5'      �� *SelectedProduct+��5+      �� *	Inventory+5-      5/      50      