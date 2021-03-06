﻿Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace WpfApplication41
    Public Class ViewModel
        Public Overridable Property FixedTopRows() As ObservableCollection(Of Customer)
        Public Property Customers() As ObservableCollection(Of Customer)

        Public Sub New()
            Customers = New ObservableCollection(Of Customer)()
            For i As Integer = 1 To 29
                Customers.Add(New Customer() With {.ID = i, .Name = "Name" & i})
            Next i

            FixedTopRows = New ObservableCollection(Of Customer)()
            FixedTopRows.Add(Customers(5))
            FixedTopRows.Add(Customers(20))
        End Sub
    End Class

    Public Class Customer
        Public Property ID() As Integer

        Public Property Name() As String
    End Class
End Namespace
