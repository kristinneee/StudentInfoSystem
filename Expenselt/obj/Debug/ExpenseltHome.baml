   M S B A M L   `   `   `  ����D  @Expenselt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Expenselt	Expenselt  5   	       Expenselt.ExpenseltHome   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Expenselt     5   	     � Title$  Expenselt - Home��5   	   $	��300��6"   $��490.444��6/   $��
10,0,10,10q�6?   .��5	      �  � 	Resources 5
   
      ExpenseDataSource � XPath��%�  &	        � 5      $ Expenses��68   .��5      ��<Expenses xmlns="">
                        <Person Name="Mike" Department="Legal">
                            <Expense ExpenseType="Lunch" ExpenseAmount="50" />
                            <Expense ExpenseType="Transportation" ExpenseAmount="50" />
                        </Person>
                        <Person Name="Lisa" Department="Marketing">
                            <Expense ExpenseType="Document printing" ExpenseAmount="50" />
                            <Expense ExpenseType="Gift" ExpenseAmount="125" />
                        </Person>
                        <Person Name="John" Department="Engineering">
                            <Expense ExpenseType="Magazine subscription" ExpenseAmount="50" />
                            <Expense ExpenseType="New machine" ExpenseAmount="600" />
                            <Expense ExpenseType="Software" ExpenseAmount="500" />
                        </Person>
                        <Person Name="Mary" Department="Finance">
                            <Expense ExpenseType="Dinner" ExpenseAmount="100" />
                        </Person>
                        <Person Name="Theo" Department="Marketing">
                            <Expense ExpenseType="Dinner" ExpenseAmount="100" />
                        </Person>
                        <Person Name="James" Department="Marketing">
                            <Expense ExpenseType="Breakfast" ExpenseAmount="10" />
                        </Person>
                        <Person Name="David" Department="Marketing">
                            <Expense ExpenseType="Gift" ExpenseAmount="140" />
                        </Person>
                    </Expenses>        5*      5+       � ColumnDefinitions 5-   
   �� 5.      $	��230 �6   �� 5/       � RowDefinitions 51   
   �� 52      $
��Auto �6   �� 53      �� 54      �� 55      $
��Auto �6   ��57   
   �� 58       �� ImageSource$ watermark.png��6   .+�5:   
   �� $��0��6   $��2��6"   ��6/   ��  �� Path$ PersonsChecked�5<      �� 5>   
   $��Center=�6   
�������$��1��6>   $��Names��6K   ���	#FF5242EB$��2��6r   $��36��6�   $��230,82,0,0.4q�6�   �� 5@   
   $��35��5A       �� Padding$ 5q�6   $��1��6&   $��1��66   5B      �� 5C   
   -   5        $��peopleListBox��5C      $��1��6\   $��2��6l   ��6y   ��  �� Source# [  	 �� XPath$	 Person����5D      �� 5E      .R�5F      �� ��6   �� $	 @Name��5H      5I      5K      �� 5M   
   -   5        $��0,10,0,5q�5M      $��1��6$   $��4��64   $	��125��6A   $��25��6M   $��Right=�6Y   ��6�   �� 
 �� ElementName$
 peopleListBox��$# SelectedItem.Attributes[Name]�5O      �� 5P   
   $��Greeting��6   $
��Left=�6$   $	��Top=�6?   $	��125��6W   $��25��6c   $��0,10,0,5q�6o   $��1��5Q      $��4��6!   �� 5S   
   $��0��6   $��3��6    ��6-   �� $ LastChecked�5U      5V      