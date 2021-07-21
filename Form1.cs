using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                dataGridView1.Rows.RemoveAt(selectedIndex);
                dataGridView1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = HoTen.Text;
                row.Cells[1].Value = Class.Text;
                if(Male.Checked == true)
                    row.Cells[2].Value = "Male";
                else if(Female.Checked == true)
                    row.Cells[2].Value = "Female";
                else
                    row.Cells[2].Value = "";
                dataGridView1.Rows.Add(row);
        }
    }
}
