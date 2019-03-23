using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WFA_DGV
{
    public partial class Form1 : Form
    {
        private enum eDGVcol
        {
            order = 0,
            cbFast, fileName,
            XelemNum, YelemNum, Xsize, Ysize,
            diffXelem, diffYelem, diffXsize, diffYsize,
            Remove,
        }

        private List<int> _order = new List<int>();
        bool b_order;

        public Form1()
        {
            InitializeComponent();
            b_order = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            b_order = false;
            var row = dGV_CGHs.Rows[dGV_CGHs.Rows.Add()];
            dGV_CGHs.Rows[dGV_CGHs.Rows.Count - 1].Cells[(int)eDGVcol.order].Value = dGV_CGHs.Rows.Count;
            _order.Add(dGV_CGHs.Rows.Count);            
        }

        private void dGV_CGHs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridView dgv = (DataGridView)sender;
            switch ((eDGVcol)e.ColumnIndex)
            {
                case eDGVcol.fileName:
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "CGH File|*.bmp|All Files (*.*)|*.*";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(ofd.FileName))
                        {
                            FileInfo inFileInfo = new FileInfo(ofd.FileName);
                            if (inFileInfo.Extension == ".bmp")
                            {
                                readBMPfileHeader(ofd.FileName, e.RowIndex);
                            }
                        }
                    }
                    break;
            }
        }

        private void dGV_CGHs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridView dgv = (DataGridView)sender;
            switch ((eDGVcol)e.ColumnIndex)
            {
                case eDGVcol.Remove:                    
                    dGV_CGHs.Rows.RemoveAt(e.RowIndex);
                    _order.RemoveAt(e.RowIndex);
                    changeOrder();
                    break;
            }
        }

        private void readBMPfileHeader(string fileName, int rowIdx)
        {

        }

        private void changeOrder()
        {
            _order.Sort();
            int[] tmp = new int[dGV_CGHs.RowCount];
            for (int i = 0; i < dGV_CGHs.RowCount; i++)
            {
                for (int j = 0; j < dGV_CGHs.RowCount; j++)
                {
                    if (_order[i] == int.Parse(dGV_CGHs.Rows[j].Cells[(int)eDGVcol.order].Value.ToString()))
                    {
                        tmp[j] = i + 1;
                        break;
                    }
                }
            }
            for (int i = 0; i < dGV_CGHs.RowCount; i++)
            {
                _order[i] = tmp[i];
                dGV_CGHs.Rows[i].Cells[(int)eDGVcol.order].Value = tmp[i];
            }
        }

        private void dGV_CGHs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
#if false
            if(b_order)
            {
                int num;
                if (e.RowIndex < 0) return;
                switch ((eDGVcol)e.ColumnIndex)
                {
                    case eDGVcol.order:
                        num = int.Parse(dGV_CGHs.Rows[e.RowIndex].Cells[(int)eDGVcol.order].Value.ToString());
                        for (int i = 0; i < dGV_CGHs.RowCount; i++)
                        {
                            if (_order[i] >= num && i != e.RowIndex)
                            {
                                _order[i] += 1;
                                dGV_CGHs.Rows[i].Cells[(int)eDGVcol.order].Value = _order[i];
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            b_order = true;
#endif
            if (b_order)
            {
                if (e.RowIndex < 0) return;
                switch ((eDGVcol)e.ColumnIndex)
                {
                    case eDGVcol.order:
                        _order[e.RowIndex] = int.Parse(dGV_CGHs.Rows[e.RowIndex].Cells[(int)eDGVcol.order].Value.ToString());
                        break;
                    default:
                        break;
                }
            }
            b_order = true;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
