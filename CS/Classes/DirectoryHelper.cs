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
    public static class DirectoryHelper
    {
        public static List<GridFile> GetFiles(string path)
        {
            string[] files = Directory.GetFiles(path);
            List<GridFile> res = new List<GridFile>();
            for (int i = 0; i < files.Length; i++)
            {
                res.Add(new GridFile(files[i], i));
            }
            return res;
        }
    }
}
