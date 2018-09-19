using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Mvvm.Model;

namespace WindowsFormsApp.Mvvm
{
    public partial class Form1 : Form
    {
        Form1Model Model { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Model = new Form1Model();
            txtMsg.DataBindings.Add("Text", Model, "Message");
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMsg.Text))
            {
                lblMsg.Text = txtMsg.Text;
            }
        }
    }
}
