﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inspector.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.ShowIcon = false;
            this.Text = Application.ProductName;            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void menuItem_EXIT_Click(object sender, EventArgs e)
        {
            // TODO : 청소
            Environment.Exit(0);
        }
    }
}
