using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void btnSubmitMessage_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are you sure you want to submit this student? ", "Confirm",MessageBoxButtons.OKCancel, MessageBoxIcon.Question ,MessageBoxDefaultButton.Button1) == DialogResult.OK )
            {
                MessageBox.Show("User Pressed Ok");
            }
                Application.Exit();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to cancel this student?","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("User Pressed Ok");
            }
            Application.Exit();
        }

        private void  chbProgrammin_CheckedChanged(object sender, EventArgs e)
        {
            grProgrammingLanguge.Visible = chbProgramming.Checked;
            gbEnglishLevel.Visible = false;
            gbSport.Visible = false;
        }

        private void chbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            gbEnglishLevel.Visible = chbEnglish.Checked;
            grProgrammingLanguge.Visible = false;
            gbSport.Visible = false;
        }
        private void chbSport_CheckedChanged(object sender, EventArgs e)
        {
            gbSport.Visible = chbSport.Checked;
            grProgrammingLanguge.Visible = false;
            gbEnglishLevel.Visible = false;
        }

        private void gbSport_Enter(object sender, EventArgs e)
        {

        }



        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    gbEnglishLevel.Visible = checkBox1.Checked;
        //}

        //private void gbSport_Enter(object sender, EventArgs e)
        //{
        //    gbSport.Visible = checkBox1.Checked;
        //}
    }
}
