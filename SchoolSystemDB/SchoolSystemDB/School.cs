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
    public partial class School : Form
    {
        public School()
        {
            InitializeComponent();
        }

        private void School_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.School". При необходимости она может быть перемещена или удалена.
            this.schoolTableAdapter.Fill(this.school2DataSet.School);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.schoolTableAdapter.Update(this.school2DataSet);
        }

    }
}
