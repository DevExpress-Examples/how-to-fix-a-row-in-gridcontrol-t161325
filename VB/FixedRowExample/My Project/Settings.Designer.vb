﻿' Developer Express Code Central Example:
' How to fix a row in GridControl
' 
' This example demonstrates how to provide the capability to fix a row in
' GridControl. Our GridControl doesn't have the capability to fix a row. So, to
' provide this capability in this sample, we manipulate
' the child collection of
' the HeirarchyPanel. We add a StackPanel with a collection of editors to the
' child
' collection of the HeirarchyPanel and bind them to respective cells of the
' selected row. Then, we assign
' it to a ScrollChanged event of the ScrollViewer.
' When ScrollChanged raises, we change the location of the StackPanel, so it is
' always displayed on the top of the grid view.
' Please note, that this approach
' is not compatible with Bands and Conditional Formatting. Also, a fixed row may
' not be displayed immediately when PerPixelScrolling is enabled.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T161325

' Developer Express Code Central Example:
' How to fix a row in GridControl
' 
' This example demonstrates how to provide the capability to fix a row in
' GridControl. Our GridControl doesn't have the capability to fix a row. So, to
' provide this capability in this sample, we manipulate
' the child collection of
' the HeirarchyPanel. We add a StackPanel with a collection of editors to the
' child
' collection of the HeirarchyPanel and bind them to respective cells of the
' selected row. Then, we assign
' it to a ScrollChanged event of the ScrollViewer.
' When ScrollChanged raises, we change the location of the StackPanel, so it is
' always displayed on the top of the grid view.
' Please note, that this approach
' is not compatible with Bands and Conditional Formatting. Also, a fixed row may
' not be displayed immediately when PerPixelScrolling is enabled.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T161325

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
Namespace My


	<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")> _
	Friend NotInheritable Partial Class Settings
		Inherits System.Configuration.ApplicationSettingsBase

		Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

		Public Shared ReadOnly Property [Default]() As Settings
			Get
				Return defaultInstance
			End Get
		End Property
	End Class
End Namespace
