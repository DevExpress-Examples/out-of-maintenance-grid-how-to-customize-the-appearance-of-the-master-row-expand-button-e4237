Imports Microsoft.VisualBasic
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
            tasks.Add(New Task("Task1", New DateTime(2012, 9, 3), DateTime.Now, True, New List(Of String)() From {}))
            tasks.Add(New Task("Task2", DateTime.Now, New DateTime(2012, 9, 7), False, New List(Of String)() From {"Step1", "Step2", "Step3", "Step4"}))
            tasks.Add(New Task("Task3", New DateTime(2012, 8, 12), DateTime.Now, True, New List(Of String)() From {"Step1", "Step2"}))
            tasks.Add(New Task("Task4", New DateTime(2012, 9, 3), DateTime.Now, True, New List(Of String)() From {"Step1", "Step2", "Step3"}))
            tasks.Add(New Task("Task5", New DateTime(2012, 7, 15), New DateTime(2012, 9, 23), False, New List(Of String)() From {}))
            tasks.Add(New Task("Task6", New DateTime(2012, 4, 3), New DateTime(2012, 4, 2), True, New List(Of String)() From {"Step1", "Step2", "Step3", "Step4"}))
            tasks.Add(New Task("Task7", New DateTime(2012, 9, 3), DateTime.Now, False, New List(Of String)() From {"Step1", "Step2", "Step3"}))
		End Sub
	End Class
End Namespace
