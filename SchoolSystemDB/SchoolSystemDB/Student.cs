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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.Headmaster". При необходимости она может быть перемещена или удалена.
            this.headmasterTableAdapter.Fill(this.school2DataSet.Headmaster);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.school2DataSet.Student);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.studentTableAdapter.Update(this.school2DataSet);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
