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
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
        }

        private void Class_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.School". При необходимости она может быть перемещена или удалена.
            this.schoolTableAdapter.Fill(this.school2DataSet.School);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.Class". При необходимости она может быть перемещена или удалена.
            this.classTableAdapter.Fill(this.school2DataSet.Class);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.classTableAdapter.Update(this.school2DataSet);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
