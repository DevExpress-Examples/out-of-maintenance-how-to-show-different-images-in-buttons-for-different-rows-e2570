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
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository

Namespace WindowsApplication1
	Public Class GridExplorerHelper

		Private _GridView As GridView
		Private _Folder As String
		Public Sub New(ByVal gridView As GridView, ByVal folder As String)
			_Folder = folder
			_GridView = gridView
			InitColumns()
			InitData()
		End Sub

		Private Sub InitData()
			_GridView.GridControl.DataSource = DirectoryHelper.GetFiles(_Folder)
		End Sub
		Private Sub InitColumns()
			_GridView.Columns.Clear()
			Dim col As GridColumn = _GridView.Columns.AddVisible("Path")
		End Sub
	End Class

End Namespace
