﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            School f = new School();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            House f = new House();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class f = new Class();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Grade f = new Grade();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Headmaster f = new Headmaster();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student f = new Student();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Combined f = new Combined();
            f.Show();
        }
    }
}
