﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class CusNoOFItem : Form
    {
        public CusNoOFItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CusNoOFItem_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Number Of Items");

            for (int i = 0; i < 6; i++)
            {
                dt.Rows.Add(Which_Customer_Of_Order.cusNumOfOrder[i]);
            }

            dataGridView1.DataSource = dt;
        }
    }
}
