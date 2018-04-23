using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace WindowsApplication1
{
    public class GridFile
    {
        public GridFile(string path, int icon)
        {
            Path = path;
           
        }

        private string _Path;
        public string Path
        {
            get { return _Path; }
            set { _Path = value; }
        }


        private int _Icon;
        public int Icon
        {
            get { return _Icon; }
            set { _Icon = value; }
        }
    }
}
