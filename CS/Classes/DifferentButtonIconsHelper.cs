using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Drawing;

namespace WindowsApplication1
{
    public class DifferentButtonIconsHelper
    {
     
        public delegate void GetButtonIndexEventHandler(object sender, GetButtonIndexEventArgs e);
        public event GetButtonIndexEventHandler GetButtonIndex;

        private GridView _GridView;
        private GridColumn _Column;
        public DifferentButtonIconsHelper(GridView gridView, GridColumn column)
        {
            _Column = column;
            _GridView = gridView;
            InitColumnEditor();
            InitEvents();
        }

        private void InitColumnEditor()
        {
            RepositoryItemButtonEdit ri = new RepositoryItemButtonEdit();
            _Column.ColumnEdit = ri;
            ri.Buttons.Clear();
            ri.Buttons.Add(new EditorButton(ButtonPredefines.Glyph, "", 30, true, true, true, DevExpress.Utils.HorzAlignment.Center, null));
        }

        private void InitEvents()
        {
            _GridView.ShownEditor += _GridView_ShownEditor;
            _GridView.CustomDrawCell += _GridView_CustomDrawCell;
        }

        void _GridView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column == _Column)
            {
                ButtonEditViewInfo viewInfo = (e.Cell as GridCellInfo).ViewInfo as ButtonEditViewInfo;
                if (viewInfo != null)
                {
                    EditorButtonObjectInfoArgs buttonInfo = viewInfo.ButtonInfoById(0);
                    if (buttonInfo != null)
                        SetButtonImage(buttonInfo.Button, e.RowHandle);
                }
            }
        }

        void _GridView_ShownEditor(object sender, EventArgs e)
        {
            if (_GridView.FocusedColumn == _Column)
            {
                ButtonEdit edit = _GridView.ActiveEditor as ButtonEdit;
                SetButtonImage(edit.Properties.Buttons[0], _GridView.FocusedRowHandle);
            }
        }

        Image RaiseGetButtonImage(int rowHandle)
        {
            GetButtonIndexEventArgs args = new GetButtonIndexEventArgs(rowHandle);
            if (GetButtonIndex != null)
                GetButtonIndex(_GridView, args);
            return args.Icon;
        }

        void SetButtonImage(EditorButton button, int rowHanlde)
        {
            Image image = RaiseGetButtonImage(rowHanlde);
            button.Image = image;
        }
    }
}