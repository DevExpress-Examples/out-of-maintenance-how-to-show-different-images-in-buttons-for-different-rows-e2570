Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Drawing

Namespace WindowsApplication1
	Public Class DifferentButtonIconsHelper

		Public Delegate Sub GetButtonIndexEventHandler(ByVal sender As Object, ByVal e As GetButtonIndexEventArgs)
		Public Event GetButtonIndex As GetButtonIndexEventHandler

		Private _GridView As GridView
		Private _Column As GridColumn
		Public Sub New(ByVal gridView As GridView, ByVal column As GridColumn)
			_Column = column
			_GridView = gridView
			InitColumnEditor()
			InitEvents()
		End Sub

		Private Sub InitColumnEditor()
			Dim ri As New RepositoryItemButtonEdit()
			_Column.ColumnEdit = ri
			ri.Buttons.Clear()
			ri.Buttons.Add(New EditorButton(ButtonPredefines.Glyph, "", 30, True, True, True, DevExpress.Utils.HorzAlignment.Center, Nothing))
		End Sub

		Private Sub InitEvents()
			AddHandler _GridView.ShownEditor, AddressOf _GridView_ShownEditor
			AddHandler _GridView.CustomDrawCell, AddressOf _GridView_CustomDrawCell
		End Sub

		Private Sub _GridView_CustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs)
			If e.Column Is _Column Then
				Dim viewInfo As ButtonEditViewInfo = TryCast((TryCast(e.Cell, GridCellInfo)).ViewInfo, ButtonEditViewInfo)
				If viewInfo IsNot Nothing Then
					Dim buttonInfo As EditorButtonObjectInfoArgs = viewInfo.ButtonInfoById(0)
					If buttonInfo IsNot Nothing Then
						SetButtonImage(buttonInfo.Button, e.RowHandle)
					End If
				End If
			End If
		End Sub

		Private Sub _GridView_ShownEditor(ByVal sender As Object, ByVal e As EventArgs)
			If _GridView.FocusedColumn Is _Column Then
				Dim edit As ButtonEdit = TryCast(_GridView.ActiveEditor, ButtonEdit)
				SetButtonImage(edit.Properties.Buttons(0), _GridView.FocusedRowHandle)
			End If
		End Sub

		Private Function RaiseGetButtonImage(ByVal rowHandle As Integer) As Image
			Dim args As New GetButtonIndexEventArgs(rowHandle)
			RaiseEvent GetButtonIndex(_GridView, args)
			Return args.Icon
		End Function

		Private Sub SetButtonImage(ByVal button As EditorButton, ByVal rowHanlde As Integer)
			Dim image As Image = RaiseGetButtonImage(rowHanlde)
			button.Image = image
		End Sub
	End Class
End Namespace