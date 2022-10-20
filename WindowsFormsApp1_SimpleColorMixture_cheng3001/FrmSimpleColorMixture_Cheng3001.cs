using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_SimpleColorMixture_cheng3001
{
    public partial class FrmSimpleColorMixture_Cheng3001 : Form
    {
        #region global variables 
        public const int BLACK_COLOR = 0, RED_COLOR = 4, GREEN_COLOR = 2, BLUE_COLOR = 1, CYAN_COLOR = 3, MAGENTA_COLOR = 5, YELLOW_COLOR = 6, WHITE_COLOR = 7, DEFAULT_COLOR = -1;
        public int ColorMixture_rgb = 0;
        const int IF_ELSE_IF_METHOD = 1, SWITCH_METHOD = 2;
        int decisionMethod = SWITCH_METHOD;
        AdditiveColorMixture_Cheng3001 additiveColorMixture;  //Create new variance additivecolormixture under class AdditiveColor
        int r = 0, g = 0, b = 0, alpha = 0;
        public Color backColor = Color.White;
        #endregion global variables
        private void BtnColorMix_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changing the background color.");
            this.backColor = Color.FromArgb(r,g,b);
        }

        //Add color in result
        public void AdditiveColorMixture_Cheng3001(CheckBox _ckBoxRed, CheckBox _ckBoxGreen, CheckBox _ckBoxBlue, int _decisionMethod)
        {
            ckBoxRed = _ckBoxRed;
            ckBoxGreen = _ckBoxGreen;
            ckBoxBlue = _ckBoxBlue;

            ColorMixture_rgb = 0;

            if (ckBoxRed.Checked)
                ColorMixture_rgb += RED_COLOR;
            if (ckBoxGreen.Checked)
                ColorMixture_rgb += GREEN_COLOR;
            if (ckBoxBlue.Checked)
                ColorMixture_rgb += BLUE_COLOR;

            decisionMethod = _decisionMethod;
            backColor = getColor(decisionMethod);
        }

        
        public FrmSimpleColorMixture_Cheng3001()
        {
            InitializeComponent();
        }


        private void btnChangeBC_Click(object sender, EventArgs e)
        {
            Color color = Color.White;

            if (rdbDifferent.Checked)
            {
                if (rdbIfElse.Checked)
                    decisionMethod = IF_ELSE_IF_METHOD;
                else
                    decisionMethod = SWITCH_METHOD;
                additiveColorMixture = new AdditiveColorMixture_Cheng3001(ckBoxRed, ckBoxGreen, ckBoxBlue, decisionMethod);
                this.BackColor = additiveColorMixture.backColor;
            }
            else
            {
                if (rdbIfElse.Checked)
                {
                    MessageBox.Show("You select if-else method.");
                    color = getMixColorUsingIfElseIf();
                }
                else
                {
                    MessageBox.Show("You select switch method.");
                    color = getColorMixtureUsingSwitch();
                }
                this.BackColor= color;
            }
        }


        /// <summary>Decisions the which method.</summary>
        private void decisionWhichMethod()
        {
            Color color = Color.White;
            ColorMixture_rgb = 0;

            if (rdbIfElse.Checked)
            {
                MessageBox.Show("You select if-else method.");
                color = getMixColorUsingIfElseIf();
            }
            else
            {
                MessageBox.Show("You select switch method.");
                color = getColorMixtureUsingSwitch();
            }
        }

        #region method
        
        //ifelseif
        #region ifelseif
        private Color getMixColorUsingIfElseIf()
        {
            Color mixedColor = Color.Black; //default color

            if (ckBoxRed.Checked && ckBoxGreen.Checked && ckBoxBlue.Checked)
            {
                mixedColor = Color.White;
            }
            else if (ckBoxRed.Checked && ckBoxGreen.Checked)
            {
                mixedColor = Color.Yellow;
            }
            else if (ckBoxRed.Checked && ckBoxBlue.Checked)
            {
                mixedColor = Color.Magenta;
            }
            else if (ckBoxRed.Checked && ckBoxGreen.Checked)
            {
                mixedColor = Color.Yellow;
            }
            else if (ckBoxGreen.Checked && ckBoxBlue.Checked)
            {
                mixedColor = Color.Cyan;
            }
            else if (ckBoxRed.Checked)
            {
                mixedColor = Color.Red;
            }
            else if (ckBoxGreen.Checked)
            {
                mixedColor = Color.Green;
            }
            else if (ckBoxBlue.Checked)
            {
                mixedColor = Color.Blue;
            }
            else
            {
                mixedColor = Color.Black;
            }
            return mixedColor;
        }
        #endregion ifelseif

        
        #region switch
        private void AdditiveColorMixtureSwitch_rgb()
        {
            //BLACK_COLOR = 0, RED_COLOR = 4, GREEN_COLOR = 2, BLUE_COLOR = 1,
            //CYAN_COLOR = 3, MAGENTA_COLOR = 5, YELLOW_COLOR = 6, WHITE_COLOR = 7, DEFAULT_COLOR = -1

            ColorMixture_rgb = 0;
            if (ckBoxRed.Checked)
                ColorMixture_rgb += RED_COLOR;
            if (ckBoxGreen.Checked)
                ColorMixture_rgb += GREEN_COLOR;
            if (ckBoxBlue.Checked)
                ColorMixture_rgb += BLUE_COLOR;
        }


        private Color getColor(int _decisionMethod)
        {
            Color color = Color.White;

            if (decisionMethod == IF_ELSE_IF_METHOD)
            {
                MessageBox.Show("You select if-else method.");
                color = getMixColorUsingIfElseIf();
            }
            else
            {
                MessageBox.Show("You select switch method.");
                color = getColorMixtureUsingSwitch();
            }
            return color;
        }
        private Color getColorMixtureUsingSwitch()
        {
            Color mixedcolor = Color.Black;
            AdditiveColorMixtureSwitch_rgb();

            switch (ColorMixture_rgb)
            {
                case BLACK_COLOR:
                    mixedcolor = Color.Black;
                    break;
                case RED_COLOR:
                    mixedcolor = Color.Red;
                    break;
                case GREEN_COLOR:
                    mixedcolor = Color.Green;
                    break;
                case BLUE_COLOR:
                    mixedcolor = Color.Blue;
                    break;
                case YELLOW_COLOR:
                    mixedcolor = Color.Yellow;
                    break;
                case CYAN_COLOR:
                    mixedcolor = Color.Cyan;
                    break;
                case MAGENTA_COLOR:
                    mixedcolor = Color.Magenta;
                    break;
                case WHITE_COLOR:
                    mixedcolor = Color.White;
                    break;
            }
            return mixedcolor;
        }
        #endregion switch
        #endregion method

        #region bar

        private void bar_ColorChanged(object sender, EventArgs e)
        {
            ColorChange();
        }


        private void ColorChange()
        {
            r = hScrollBar_R.Value; //get the value of red bar
            g = hScrollBar_G.Value;
            b = hScrollBar_B.Value;
            alpha = hScrollBar_Alpha.Value;

            r = Math.Max(Math.Min(hScrollBar_R.Value, 255), 0); //先取最小(並設置上限值為255)再取最大值
            g = Math.Max(Math.Min(hScrollBar_G.Value, 255), 0);
            b = Math.Max(Math.Min(hScrollBar_B.Value, 255), 0);
            alpha = Math.Max(Math.Min(hScrollBar_Alpha.Value, 255), 0);

            tb_R.Text = r .ToString();
            tb_G.Text = g.ToString();
            tb_B.Text = b.ToString();
            tb_Alpha.Text = alpha.ToString();

            gpbR_bar.BackColor = Color.FromArgb(alpha, r, 0, 0); //change color from rgb
            gpbG_bar.BackColor = Color.FromArgb(alpha, 0, g, 0);
            gpbB_bar.BackColor = Color.FromArgb(alpha, 0, 0, b);

            this.BackColor = Color.FromArgb(r, g, b);
        }
        #endregion bar

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

   
}
