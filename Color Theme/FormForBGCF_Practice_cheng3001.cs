using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Color_Theme
{
    public partial class FormForBGCF_Practice_cheng3001 : Form
    {
        public FormForBGCF_Practice_cheng3001()
        {
            InitializeComponent();
        }

        private void radioBtnRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnRed.Checked)
            {
                this.BackColor = Color.Red; //"this" for whole form
            }
        }

        private void radioBtnGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnGreen.Checked)
            {
                this.BackColor = Color.Green;
            }
        }

        private void radioBtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnBlue.Checked)
            {
                this.BackColor = Color.Blue;
            }
        }

        private void radioBtnWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnWhite.Checked)
            {
                this.BackColor = Color.White;
            }
        }

        private void radioBtnNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnNormal.Checked)
            {
                this.BackColor = Color.Gray;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //Close this form
        }


    }  //End of FormForBGCF_Practice_cheng3001
}
