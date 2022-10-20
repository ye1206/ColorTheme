
namespace Color_Theme
{
    partial class FormForBGCF_Practice_cheng3001
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnWhite = new System.Windows.Forms.RadioButton();
            this.radioBtnGreen = new System.Windows.Forms.RadioButton();
            this.radioBtnRed = new System.Windows.Forms.RadioButton();
            this.radioBtnBlue = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.radioBtnNormal = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnNormal);
            this.groupBox1.Controls.Add(this.radioBtnBlue);
            this.groupBox1.Controls.Add(this.radioBtnRed);
            this.groupBox1.Controls.Add(this.radioBtnGreen);
            this.groupBox1.Controls.Add(this.radioBtnWhite);
            this.groupBox1.Location = new System.Drawing.Point(100, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a background color";
            // 
            // radioBtnWhite
            // 
            this.radioBtnWhite.AutoSize = true;
            this.radioBtnWhite.Location = new System.Drawing.Point(84, 119);
            this.radioBtnWhite.Name = "radioBtnWhite";
            this.radioBtnWhite.Size = new System.Drawing.Size(51, 16);
            this.radioBtnWhite.TabIndex = 0;
            this.radioBtnWhite.TabStop = true;
            this.radioBtnWhite.Text = "White";
            this.radioBtnWhite.UseVisualStyleBackColor = true;
            this.radioBtnWhite.CheckedChanged += new System.EventHandler(this.radioBtnWhite_CheckedChanged);
            // 
            // radioBtnGreen
            // 
            this.radioBtnGreen.AutoSize = true;
            this.radioBtnGreen.Location = new System.Drawing.Point(84, 55);
            this.radioBtnGreen.Name = "radioBtnGreen";
            this.radioBtnGreen.Size = new System.Drawing.Size(51, 16);
            this.radioBtnGreen.TabIndex = 1;
            this.radioBtnGreen.TabStop = true;
            this.radioBtnGreen.Text = "Green";
            this.radioBtnGreen.UseVisualStyleBackColor = true;
            this.radioBtnGreen.CheckedChanged += new System.EventHandler(this.radioBtnGreen_CheckedChanged);
            // 
            // radioBtnRed
            // 
            this.radioBtnRed.AutoSize = true;
            this.radioBtnRed.Location = new System.Drawing.Point(84, 21);
            this.radioBtnRed.Name = "radioBtnRed";
            this.radioBtnRed.Size = new System.Drawing.Size(42, 16);
            this.radioBtnRed.TabIndex = 2;
            this.radioBtnRed.TabStop = true;
            this.radioBtnRed.Text = "Red";
            this.radioBtnRed.UseVisualStyleBackColor = true;
            this.radioBtnRed.CheckedChanged += new System.EventHandler(this.radioBtnRed_CheckedChanged);
            // 
            // radioBtnBlue
            // 
            this.radioBtnBlue.AutoSize = true;
            this.radioBtnBlue.Location = new System.Drawing.Point(84, 88);
            this.radioBtnBlue.Name = "radioBtnBlue";
            this.radioBtnBlue.Size = new System.Drawing.Size(45, 16);
            this.radioBtnBlue.TabIndex = 3;
            this.radioBtnBlue.TabStop = true;
            this.radioBtnBlue.Text = "Blue";
            this.radioBtnBlue.UseVisualStyleBackColor = true;
            this.radioBtnBlue.CheckedChanged += new System.EventHandler(this.radioBtnBlue_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(184, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 27);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radioBtnNormal
            // 
            this.radioBtnNormal.AutoSize = true;
            this.radioBtnNormal.Location = new System.Drawing.Point(84, 155);
            this.radioBtnNormal.Name = "radioBtnNormal";
            this.radioBtnNormal.Size = new System.Drawing.Size(46, 16);
            this.radioBtnNormal.TabIndex = 4;
            this.radioBtnNormal.TabStop = true;
            this.radioBtnNormal.Text = "Gray";
            this.radioBtnNormal.UseVisualStyleBackColor = true;
            this.radioBtnNormal.CheckedChanged += new System.EventHandler(this.radioBtnNormal_CheckedChanged);
            // 
            // FormForBGCF_cheng3001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 364);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormForBGCF_cheng3001";
            this.Text = "Color_Mixture Using Background";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnBlue;
        private System.Windows.Forms.RadioButton radioBtnRed;
        private System.Windows.Forms.RadioButton radioBtnGreen;
        private System.Windows.Forms.RadioButton radioBtnWhite;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radioBtnNormal;
    }
}