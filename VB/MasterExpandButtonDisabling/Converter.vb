Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Data
Imports System.Globalization
Imports System.Windows.Media

Namespace MasterExpandButtonDisabling
	Public Class Converter
		Implements IValueConverter
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
			If parameter IsNot Nothing Then
				Dim param As String = parameter.ToString()
				If TypeOf value Is Task AndAlso param.Equals("BoolConversion") Then
					Dim rw As Task = CType(value, Task)
					Return If(rw.Steps.Count > 0, True, False)
				End If
			End If
			If TypeOf value Is Task Then
				Dim rw As Task = CType(value, Task)
				Return If(rw.Steps.Count > 0, New SolidColorBrush(Colors.DarkBlue), New SolidColorBrush(Colors.Gray))
			End If
			Return value
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Return value
		End Function
	End Class
End Namespace
