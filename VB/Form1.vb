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

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			Dim TempGridExplorerHelper As GridExplorerHelper = New GridExplorerHelper(gridView1, "D:\")
			AddHandler CType(New DifferentButtonIconsHelper(gridView1, gridView1.Columns(0)), DifferentButtonIconsHelper).GetButtonIndex, AddressOf GetButtonIndex
			gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
			gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp
		End Sub

		Public Sub GetButtonIndex(ByVal sender As Object, ByVal e As GetButtonIndexEventArgs)
			e.Icon = imageCollection1.Images(e.RowHandle Mod imageCollection1.Images.Count)
		End Sub
	End Class
End Namespace