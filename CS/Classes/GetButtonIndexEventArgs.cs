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

namespace WindowsApplication1
{
    public class GetButtonIndexEventArgs
    {
        public GetButtonIndexEventArgs(int rowHandle)
        {
            _RowHandle = rowHandle;
        }

        private Image _Icon;
        public Image Icon
        {
            get { return _Icon; }
            set { _Icon = value; }
        }

        private int _RowHandle;
        public int RowHandle
        {
            get { return _RowHandle; }
        }
    }
}
