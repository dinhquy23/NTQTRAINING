﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClient
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            Form1 form1=new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct=new frmProduct ();
            frmProduct.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmProductDetail frmProductDetail=new frmProductDetail ();
            frmProductDetail.Show();
        }
    }
}
