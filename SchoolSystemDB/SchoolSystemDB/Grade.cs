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
    public partial class Grade : Form
    {
        public Grade()
        {
            InitializeComponent();
        }

        private void Grade_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.Grade". При необходимости она может быть перемещена или удалена.
            this.gradeTableAdapter.Fill(this.school2DataSet.Grade);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.gradeTableAdapter.Update(this.school2DataSet);
        }
    }
}
