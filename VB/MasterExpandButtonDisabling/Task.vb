Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace MasterExpandButtonDisabling
		Public Class Task

		Public Sub New(ByVal Name As String, ByVal start As DateTime, ByVal finish As DateTime, ByVal isComplete As Boolean, ByVal taskSteps As List(Of String))
			Me.Name = Name
			StartDate = start
			FinishDate = finish
			IsCompleted = isComplete
			Steps = taskSteps
		End Sub

		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateFinishDate As DateTime
		Public Property FinishDate() As DateTime
			Get
				Return privateFinishDate
			End Get
			Set(ByVal value As DateTime)
				privateFinishDate = value
			End Set
		End Property
		Private privateStartDate As DateTime
		Public Property StartDate() As DateTime
			Get
				Return privateStartDate
			End Get
			Set(ByVal value As DateTime)
				privateStartDate = value
			End Set
		End Property
		Private privateIsCompleted As Boolean
		Public Property IsCompleted() As Boolean
			Get
				Return privateIsCompleted
			End Get
			Set(ByVal value As Boolean)
				privateIsCompleted = value
			End Set
		End Property
		Private privateSteps As List(Of String)
		Public Property Steps() As List(Of String)
			Get
				Return privateSteps
			End Get
			Set(ByVal value As List(Of String))
				privateSteps = value
			End Set
		End Property
		End Class
End Namespace
