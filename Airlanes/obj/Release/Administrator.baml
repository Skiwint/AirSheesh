   M S B A M L   `   `   `  ���� C  ?Airlanes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AirlanesAirlanes      Airlanes.Administrator   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Airlanes       � Title$  Administrator��$	��450��$	��800��.��� .+��� -    ��Name$ btn_add_user��$��Add user��$
��Left=�$��30��$��	10,10,0,0q�$	��Top=�$��85���� -   $
 Exit��$
��Exit��$
��Left=�$��30��$��
130,10,0,0q�$	��Top=�$��85��&   System.Windows.Controls.DataGrid  -     Name$ dg_admin_user��   AutoGenerateColumns .  $
��Left=�$	��250��$��
40,100,0,0q�$	��Top=�$	��710������  �� 
TargetType)  #System.Windows.Controls.DataGridRow"   �� Triggers ��  �� Binding �� *Active+ �� Value	 false.a���  �� Property � ��	 �� Value
	 �  ����  �� *	User Role+ Administrator.a���  � ��
	 ����
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��   
Visibility$ Hidden=�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ID+   ClipboardContentBinding Z�   $
 Name�� �� *Name+ Z�   $ 	Last name�� �� *	Last Name+ Z�   $	 Age�� �� *Age+ Z�   $ 	User Role��   
IsReadOnly .  �� *	User Role+ Z�   $ Email Address�� �� *Email address+ Z�   $ Office�� �� *Office+ Z�   $ Active��$ Hidden=� �� *Active+ Z� �� $�� ��$
��Left=�$��	40,60,0,0q�$	��Top=��� $��Office
��$
��Left=�$��	40,60,0,0q�$	��Top=��� -    ��Name$ office��$
��Left=�$��	87,63,0,0q�$	��Top=�$	��120�� �� DisplayMemberPath$ Title�� �� SelectedValuePath$ Title���� -   $ reset��$��Reset��$
��Left=�$��30��$��
225,60,0,0q�$	��Top=�$��75���� -   $ enable_disable��$��Enable/Disable Login��$
��Left=�$��
10,370,0,0q�$	��Top=�$	��140��$��30���� -   $ remove��$��Remove��$
��Left=�$��225,370,0,0q�$	��Top=�$��75��$��30���� -   $ Change_role��$��Change role��$
��Left=�$��330,370,0,0q�$	��Top=�$��75�� J� RenderTransformOrigin$ 1.003,1.062&�$��30��