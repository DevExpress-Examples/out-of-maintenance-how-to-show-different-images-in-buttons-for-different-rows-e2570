Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO

Namespace WindowsApplication1
	Public Class GridFile
		Public Sub New(ByVal path As String, ByVal icon As Integer)
			Me.Path = path

		End Sub

		Private _Path As String
		Public Property Path() As String
			Get
				Return _Path
			End Get
			Set(ByVal value As String)
				_Path = value
			End Set
		End Property


		Private _Icon As Integer
		Public Property Icon() As Integer
			Get
				Return _Icon
			End Get
			Set(ByVal value As Integer)
				_Icon = value
			End Set
		End Property
	End Class
End Namespace
