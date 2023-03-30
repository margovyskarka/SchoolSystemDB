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
    public partial class Combined : Form
    {
        public Combined()
        {
            InitializeComponent();
        }

        private void Common_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.Grade". При необходимости она может быть перемещена или удалена.
            this.gradeTableAdapter.Fill(this.school2DataSet.Grade);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.GradesClasses". При необходимости она может быть перемещена или удалена.
            this.gradesClassesTableAdapter.Fill(this.school2DataSet.GradesClasses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.HousesGrades". При необходимости она может быть перемещена или удалена.
            this.housesGradesTableAdapter.Fill(this.school2DataSet.HousesGrades);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.Class". При необходимости она может быть перемещена или удалена.
            this.classTableAdapter.Fill(this.school2DataSet.Class);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.StudentsClasses". При необходимости она может быть перемещена или удалена.
            this.studentsClassesTableAdapter.Fill(this.school2DataSet.StudentsClasses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.Headmaster". При необходимости она может быть перемещена или удалена.
            this.headmasterTableAdapter.Fill(this.school2DataSet.Headmaster);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.school2DataSet.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.House". При необходимости она может быть перемещена или удалена.
            this.houseTableAdapter.Fill(this.school2DataSet.House);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school2DataSet.School". При необходимости она может быть перемещена или удалена.
            this.schoolTableAdapter.Fill(this.school2DataSet.School);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.schoolTableAdapter.Update(this.school2DataSet);
        }
    }
}
