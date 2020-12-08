using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLesson1
{
    public partial class Calculator : Form
    {
        int Age = 88;//global variable
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        { 
            //lblOutput.Text = "Hello World";
            // lblOutput.Text = txtInput.Text;
            // lbxOutput.Items.Add(txtInput.Text);
            string Name = "Tom";
           
            Age = Age + 1;
            lbxOutput.Items.Add("Hello " + Name + " " + Age);
            MessageBox.Show("Hello " + Name + " You are " + Age + " years old");
        }

        private void lbxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
        }
    }
}
