using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
            new GridExplorerHelper(gridView1, "D:\\");
            new DifferentButtonIconsHelper(gridView1, gridView1.Columns[0]).GetButtonIndex += GetButtonIndex;
            gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
        }

        public void GetButtonIndex(object sender, GetButtonIndexEventArgs e)
        {
            e.Icon = imageCollection1.Images[e.RowHandle % imageCollection1.Images.Count];
        }
    }
}