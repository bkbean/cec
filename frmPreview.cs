using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CEC
{
    public partial class frmPreview : Form
    {
        public frmPreview(string title, string content)
        {
            InitializeComponent();

            this.Text = title;
            txtContent.Text = content;
        }
    }
}