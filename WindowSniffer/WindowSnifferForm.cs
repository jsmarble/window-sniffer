using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowSniffer.Properties;

namespace WindowSniffer
{
    public partial class WindowSnifferForm : Form
    {
        public WindowSnifferForm()
        {
            InitializeComponent();
            this.Icon = Resources.AppIcon;
            RefreshWindows();
            handleDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
        }

        private void RefreshWindows()
        {
            List<Window> windows = NativeMethods.GetAllWindows();
            windows.Sort();
            BindingList<Window> windowsBL = new BindingList<Window>(windows);
            windowBindingSource.DataSource = windowsBL;
            dgdWindows.SortCompare += new DataGridViewSortCompareEventHandler(dgdWindows_SortCompare);
        }

        void dgdWindows_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            e.Handled = true;
            if (e.Column == handleDataGridViewTextBoxColumn)
            {
                IntPtr hWnd1 = (IntPtr)e.CellValue1;
                IntPtr hWnd2 = (IntPtr)e.CellValue2;
                e.SortResult = hWnd1.ToInt32().CompareTo(hWnd2.ToInt32());
            }
            else
                e.SortResult = e.CellValue1.ToString().CompareTo(e.CellValue2.ToString());
        }

        private void moveWindowToScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window w = GetSelectedWindow();
            if (w != null)
                NativeMethods.SetWindowPos(w.Handle, IntPtr.Zero, 0, 0, w.Size.Width, w.Size.Height, 0);
        }

        private void setWindowTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window w = GetSelectedWindow();
            if (w != null)
            {
                using (TextInputForm frm = new TextInputForm(w.Text))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        NativeMethods.SetWindowText(w.Handle, frm.InputText);
                }
            }
        }

        private void showWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window w = GetSelectedWindow();
            if (w != null)
                NativeMethods.ShowWindow(w.Handle, NativeMethods.SW_NORMAL);
        }

        private Window GetSelectedWindow()
        {
            Window result = null;
            if (dgdWindows.SelectedRows.Count > 0)
                result = dgdWindows.SelectedRows[0].DataBoundItem as Window;
            return result;
        }

        private void hideWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window w = GetSelectedWindow();
            if (w != null)
                NativeMethods.ShowWindow(w.Handle, NativeMethods.SW_HIDE);
        }

        private void refreshWindowListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshWindows();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
