﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleTrouble
{
    public partial class InsertUsername : Form
    {
        public static string username;
        public InsertUsername()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void InsertUsername_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {   
            if(this.txtUsername.Text != null && this.txtUsername.Text != "")
            {
                username = this.txtUsername.Text;
                this.Dispose();
            }
            
        }
    }
}
