Imports System
Imports System.Collections.Generic
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
        End Class
End Namespace
