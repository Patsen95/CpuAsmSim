using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpuSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            #region Init crap

            pg.SelectedObject = dgv_regs;

            dgv_regs.BorderStyle = BorderStyle.None;
            dgv_regs.AllowUserToAddRows = false;
            dgv_regs.AllowUserToDeleteRows = false;
            dgv_regs.AllowUserToOrderColumns = false;
            dgv_regs.AllowUserToResizeColumns = false;
            dgv_regs.AllowUserToResizeRows = false;
            dgv_regs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_regs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_regs.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgv_regs.SelectionMode = DataGridViewSelectionMode.CellSelect;

            dgv_ram.BorderStyle = BorderStyle.None;
            dgv_ram.AllowUserToAddRows = false;
            dgv_ram.AllowUserToDeleteRows = false;
            dgv_ram.AllowUserToOrderColumns = false;
            dgv_ram.AllowUserToResizeColumns = false;
            dgv_ram.AllowUserToResizeRows = false;
            dgv_ram.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ram.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgv_ram.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv_ram.RowHeadersVisible = false;

            dgv_regs.Columns.Add("col_bin", "Bin");
            dgv_regs.Columns.Add("col_hex", "Hex");
            dgv_regs.Columns.Add("col_dec", "Dec");
            dgv_regs.Rows.Add(6);

            dgv_ram.Columns.Add("col_addr", "Adres");
            dgv_ram.Columns.Add("col_value", "Wartość");
            dgv_ram.Rows.Add(128);

            foreach(DataGridViewRow row in dgv_regs.Rows)
            {
                row.HeaderCell.Value = "GPR" + row.Index;
            }

            int _dgv_regs_rh = dgv_regs.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            int _dgv_ram_rh = dgv_ram.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            dgv_regs.MaximumSize = new Size(dgv_regs.Width, _dgv_regs_rh + _dgv_regs_rh / 6 - 1);
            dgv_ram.MaximumSize = new Size(dgv_ram.Width, _dgv_ram_rh + _dgv_ram_rh / 128 - 1);

            #endregion

        }
    }
}
