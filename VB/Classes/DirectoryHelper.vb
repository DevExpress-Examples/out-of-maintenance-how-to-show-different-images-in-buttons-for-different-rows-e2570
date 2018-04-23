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
	Public NotInheritable Class DirectoryHelper
		Private Sub New()
		End Sub
		Public Shared Function GetFiles(ByVal path As String) As List(Of GridFile)
			Dim files() As String = Directory.GetFiles(path)
			Dim res As New List(Of GridFile)()
			For i As Integer = 0 To files.Length - 1
				res.Add(New GridFile(files(i), i))
			Next i
			Return res
		End Function
	End Class
End Namespace
