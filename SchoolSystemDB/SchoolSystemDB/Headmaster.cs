using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystemDB
{
    public partial class Headmaster : Form
    {
        public Headmaster()
        {
            InitializeComponent();
        }

        private void Headmaster_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.House". При необходимости она может быть перемещена или удалена.
            this.houseTableAdapter.Fill(this.school2DataSet.House);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.Headmaster". При необходимости она может быть перемещена или удалена.
            this.headmasterTableAdapter.Fill(this.school2DataSet.Headmaster);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.headmasterTableAdapter.Update(this.school2DataSet);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
