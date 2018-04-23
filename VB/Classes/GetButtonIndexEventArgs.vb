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

Namespace WindowsApplication1
	Public Class GetButtonIndexEventArgs
		Public Sub New(ByVal rowHandle As Integer)
			_RowHandle = rowHandle
		End Sub

		Private _Icon As Image
		Public Property Icon() As Image
			Get
				Return _Icon
			End Get
			Set(ByVal value As Image)
				_Icon = value
			End Set
		End Property

		Private _RowHandle As Integer
		Public ReadOnly Property RowHandle() As Integer
			Get
				Return _RowHandle
			End Get
		End Property
	End Class
End Namespace
