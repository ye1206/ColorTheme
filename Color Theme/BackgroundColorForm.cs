﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Theme
{
    public partial class BackgroundColorForm : Form
    {
        public BackgroundColorForm()
        {
            InitializeComponent();
        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowRadioButton.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (redRadioButton.Checked)
            {
                this.BackColor = Color.Red;
            }
        }

        private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (whiteRadioButton.Checked)
            {
                this.BackColor = Color.White;
            }
        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (normalRadioButton.Checked)
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void colorGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
