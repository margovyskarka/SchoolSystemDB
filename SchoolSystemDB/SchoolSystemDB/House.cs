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
    public partial class House : Form
    {
        public House()
        {
            InitializeComponent();
        }

        private void House_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.School". При необходимости она может быть перемещена или удалена.
            this.schoolTableAdapter.Fill(this.school2DataSet.School);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.House". При необходимости она может быть перемещена или удалена.
            this.houseTableAdapter.Fill(this.school2DataSet.House);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.houseTableAdapter.Update(this.school2DataSet);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
