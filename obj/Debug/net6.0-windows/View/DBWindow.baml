   M S B A M L   `   `   `  ????J  FRegistrationApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:RegistrationApp.ViewRegistrationApp.View  5   	   U/clr-namespace:RegistrationApp.View.UserControls!RegistrationApp.View.UserControls  5   	   E'clr-namespace:RegistrationApp.ViewModelRegistrationApp.ViewModel  5   	   #    RegistrationApp.View.DBWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:RegistrationApp.View     5   	   >uc/clr-namespace:RegistrationApp.View.UserControls     5   	   6vm'clr-namespace:RegistrationApp.ViewModel     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5	   	     ? Title$  DBWindow??5   	   $	??450??6   $	??800??6'    ? 	Resources 5      (   "RegistrationApp.ViewModel.GroupsVM   vm??%   &	          5   
   6   5      .??5      ]?  ? DataContext# [  6   .+?5   
   o? $	??Top=?6   ???	#FF3268C1.@?5      m? $
??File??6   
???????.@?5      m? $??New Database??6    m? Command 5      ?? *NewDatabaseCommand+m? 5      $??	New Group??6    5      ?? *NewGroupCommand+ m? CommandParameter 5      ?? *SelectedDatabase+?? 5      m? 5      -   5        $
??Exit??5      6)   5      5      ?? 5   
   $??Bottom=?6   .@?5      ?? ???	#FF30335F
???????.??5      ?? -   5         ??Name$ statusTextBlock??5      5       5"      ?? 5#   
   $
??Left=?6   ???	#FF103275$	??140??5%      
??????? ?? SelectedValue 5'      ?? *SelectedDatabase+ ?? Mode$ TwoWay=? ?? UpdateSourceTrigger$ PropertyChanged=???5(      ?? *	Databases+??5)      ?? 5*      .R?5+      ? .+?5,      7   1RegistrationApp.View.UserControls.DisplayDatabase  	   Database	 6-   ?? 
 ? ContextMenu
 5-      ?? 5.   "   .@?5/   &   m? $??Reset??6/    50   +   ??  ?? Source# [   ?? Path$ EditCommand?51   #   53      ?? 54      ??6"   ?? *Name+$ TwoWay=?y?55   "   ?? # [  $ 	IsVisible?*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 56      +  %Microsoft.Xaml.Behaviors.EventTrigger  57         	EventName$ 	LostFocus??6-   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 58   "   2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 68   ?? # [  $ EndEditingCommand?   CommandParameter 5:   8   ?? 5;      5=      5>      5@      ?? 5A   
   $
??Left=?6   $	??140??5B      
??????????	#FF4A51B5 5D      ?? *SelectedGroup+$ TwoWay=?$ PropertyChanged=???5E      ?? *Groups+??5F      ?? 5G      .R?5H      4   .RegistrationApp.View.UserControls.DisplayGroup     Group 6&   ?? 5I      5K      `? 5L   
   $	??Top=?6    `? 
Background ?	#FF014592.?5M      c? .@?5N      ?? -   5        $
??Send??5N      5O      ?? 5P      -   5        $
??Save??5P      5Q      5R      5S      ? 5T   
    ? ColumnDefinitions 5U      ?? 5V      $
??312* ?6#   ?? 5W      $	??57* ?6#   ?? 5X      $
??151* ?6#   .+?5Z      ?? -   5         ??Name$ contentRichTextBox??5Z      ???	#FFECF0FF$??3??5[   ^   5]      5^      5_      