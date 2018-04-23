using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;

namespace WindowsApplication1
{
    public class GridExplorerHelper
    {

        private GridView _GridView;
        private string _Folder;
        public GridExplorerHelper(GridView gridView, string folder)
        {
            _Folder = folder;
            _GridView = gridView;
            InitColumns();
			InitData();
        }

        private void InitData()
        {
            _GridView.GridControl.DataSource = DirectoryHelper.GetFiles(_Folder);
        }
        private void InitColumns()
        {
            _GridView.Columns.Clear();
            GridColumn col = _GridView.Columns.AddVisible("Path");
        }
    }

}
