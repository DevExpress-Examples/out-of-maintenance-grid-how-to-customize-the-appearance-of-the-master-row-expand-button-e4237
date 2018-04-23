Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Collections.ObjectModel

Namespace MasterExpandButtonDisabling
    Partial Public Class MainWindow
        Inherits Window

        Public tasks As ObservableCollection(Of Task)

        Public Sub New()
            InitializeComponent()
            FillData()
            gridControl1.ItemsSource = tasks
        End Sub

        Public Sub FillData()
            tasks = New ObservableCollection(Of Task)()
            tasks.Add(New Task("Task1", New Date(2012, 9, 3), Date.Now, True, New List(Of String)() From {}))
            tasks.Add(New Task("Task2", Date.Now, New Date(2012, 9, 7), False, New List(Of String)() From {"Step1", "Step2", "Step3", "Step4"}))
            tasks.Add(New Task("Task3", New Date(2012, 8, 12), Date.Now, True, New List(Of String)() From {"Step1", "Step2"}))
            tasks.Add(New Task("Task4", New Date(2012, 9, 3), Date.Now, True, New List(Of String)() From {"Step1", "Step2", "Step3"}))
            tasks.Add(New Task("Task5", New Date(2012, 7, 15), New Date(2012, 9, 23), False, New List(Of String)() From {}))
            tasks.Add(New Task("Task6", New Date(2012, 4, 3), New Date(2012, 4, 2), True, New List(Of String)() From {"Step1", "Step2", "Step3", "Step4"}))
            tasks.Add(New Task("Task7", New Date(2012, 9, 3), Date.Now, False, New List(Of String)() From {"Step1", "Step2", "Step3"}))
        End Sub
    End Class
End Namespace
