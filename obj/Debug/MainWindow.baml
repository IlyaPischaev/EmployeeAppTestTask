   M S B A M L   `   `   `  ����N  JEmployeeAppTestTask, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EmployeeAppTestTaskEmployeeAppTestTask  5   	   $    EmployeeAppTestTask.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:EmployeeAppTestTask     5   	     � Title$  Сотрудники��5   	    �� TextAlignment$ Center=�5	   	   $	��450��5
   	   $	��800��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ employeeGrid��5      $��10,10,10,40q�6)      
IsReadOnly .    SelectionMode$ Single=�6h      AutoGenerateColumns .  ��6P   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 250 6R   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 66   �� *	Surname+6R     5      $ Имя��6%   $		 250 6K   
 62   �� *Name+6K     5      $ Отчество��6%   $	 * 6U   
 67   �� *	ThirdName+6U   5      �� 5   
   -   5        $��Добавить��5      $
��Left=�6$   $��
79,384,0,0q�6?   $	��Top=�6S   $��75��6k   6v   �� 5   
   -   5        $��Удалить��5      $
��Left=�6#   $��614,384,0,0q�6>   $	��Top=�6S   $��75��6k   6v   5      5      