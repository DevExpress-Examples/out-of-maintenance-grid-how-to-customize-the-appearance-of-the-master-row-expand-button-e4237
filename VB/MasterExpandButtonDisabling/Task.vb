Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq

Namespace MasterExpandButtonDisabling
		Public Class Task

		Public Sub New(ByVal Name As String, ByVal start As Date, ByVal finish As Date, ByVal isComplete As Boolean, ByVal taskSteps As List(Of String))
			Me.Name = Name
			StartDate = start
			FinishDate = finish
			IsCompleted = isComplete
			Steps = taskSteps
		End Sub

		Public Property Name() As String
		Public Property FinishDate() As Date
		Public Property StartDate() As Date
		Public Property IsCompleted() As Boolean
		Public Property Steps() As List(Of String)

		Public Shared ReadOnly Property GetList() As ObservableCollection(Of Task)
			Get
				Dim tasks As New ObservableCollection(Of Task)()
				tasks.Add(New Task("Task1", New Date(2012, 9, 3), Date.Now, True, New List(Of String)() ))
				tasks.Add(New Task("Task2", Date.Now, New Date(2012, 9, 7), False, New List(Of String)() From {"Step1", "Step2", "Step3", "Step4"}))
				tasks.Add(New Task("Task3", New Date(2012, 8, 12), Date.Now, True, New List(Of String)() From {"Step1", "Step2"}))
				tasks.Add(New Task("Task4", New Date(2012, 9, 3), Date.Now, True, New List(Of String)() From {"Step1", "Step2", "Step3"}))
				tasks.Add(New Task("Task5", New Date(2012, 7, 15), New Date(2012, 9, 23), False, New List(Of String)() ))
				tasks.Add(New Task("Task6", New Date(2012, 4, 3), New Date(2012, 4, 2), True, New List(Of String)() From {"Step1", "Step2", "Step3", "Step4"}))
				tasks.Add(New Task("Task7", New Date(2012, 9, 3), Date.Now, False, New List(Of String)() From {"Step1", "Step2", "Step3"}))
				Return tasks
			End Get
		End Property
		End Class
End Namespace
