
namespace WindowsFormsApp1_SimpleColorMixture_cheng3001
{
    partial class FrmSimpleColorMixture_Cheng3001
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbMethod = new System.Windows.Forms.GroupBox();
            this.rdbswitch = new System.Windows.Forms.RadioButton();
            this.rdbIfElse = new System.Windows.Forms.RadioButton();
            this.gpbapproach = new System.Windows.Forms.GroupBox();
            this.rdbsame = new System.Windows.Forms.RadioButton();
            this.rdbDifferent = new System.Windows.Forms.RadioButton();
            this.gpbRed = new System.Windows.Forms.GroupBox();
            this.lblRed = new System.Windows.Forms.Label();
            this.gpbGreen = new System.Windows.Forms.GroupBox();
            this.lblGreen = new System.Windows.Forms.Label();
            this.gpbBlue = new System.Windows.Forms.GroupBox();
            this.lblBlue = new System.Windows.Forms.Label();
            this.ckBoxRed = new System.Windows.Forms.CheckBox();
            this.ckBoxGreen = new System.Windows.Forms.CheckBox();
            this.ckBoxBlue = new System.Windows.Forms.CheckBox();
            this.btnChangeBC = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbR_bar = new System.Windows.Forms.GroupBox();
            this.hScrollBar_R = new System.Windows.Forms.HScrollBar();
            this.gpbG_bar = new System.Windows.Forms.GroupBox();
            this.hScrollBar_G = new System.Windows.Forms.HScrollBar();
            this.gpbB_bar = new System.Windows.Forms.GroupBox();
            this.hScrollBar_B = new System.Windows.Forms.HScrollBar();
            this.gpb_alpha = new System.Windows.Forms.GroupBox();
            this.hScrollBar_Alpha = new System.Windows.Forms.HScrollBar();
            this.BtnColorMix = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.tb_R = new System.Windows.Forms.TextBox();
            this.tb_G = new System.Windows.Forms.TextBox();
            this.tb_B = new System.Windows.Forms.TextBox();
            this.tb_Alpha = new System.Windows.Forms.TextBox();
            this.gpbMethod.SuspendLayout();
            this.gpbapproach.SuspendLayout();
            this.gpbRed.SuspendLayout();
            this.gpbGreen.SuspendLayout();
            this.gpbBlue.SuspendLayout();
            this.gpbR_bar.SuspendLayout();
            this.gpbG_bar.SuspendLayout();
            this.gpbB_bar.SuspendLayout();
            this.gpb_alpha.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbMethod
            // 
            this.gpbMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gpbMethod.Controls.Add(this.rdbswitch);
            this.gpbMethod.Controls.Add(this.rdbIfElse);
            this.gpbMethod.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbMethod.Location = new System.Drawing.Point(104, 18);
            this.gpbMethod.Margin = new System.Windows.Forms.Padding(4);
            this.gpbMethod.Name = "gpbMethod";
            this.gpbMethod.Padding = new System.Windows.Forms.Padding(4);
            this.gpbMethod.Size = new System.Drawing.Size(299, 152);
            this.gpbMethod.TabIndex = 0;
            this.gpbMethod.TabStop = false;
            this.gpbMethod.Text = "Select your method";
            // 
            // rdbswitch
            // 
            this.rdbswitch.AutoSize = true;
            this.rdbswitch.Location = new System.Drawing.Point(69, 98);
            this.rdbswitch.Margin = new System.Windows.Forms.Padding(4);
            this.rdbswitch.Name = "rdbswitch";
            this.rdbswitch.Size = new System.Drawing.Size(111, 33);
            this.rdbswitch.TabIndex = 1;
            this.rdbswitch.Text = "Switch";
            this.rdbswitch.UseVisualStyleBackColor = true;
            // 
            // rdbIfElse
            // 
            this.rdbIfElse.AutoSize = true;
            this.rdbIfElse.Checked = true;
            this.rdbIfElse.Location = new System.Drawing.Point(69, 47);
            this.rdbIfElse.Margin = new System.Windows.Forms.Padding(4);
            this.rdbIfElse.Name = "rdbIfElse";
            this.rdbIfElse.Size = new System.Drawing.Size(106, 33);
            this.rdbIfElse.TabIndex = 0;
            this.rdbIfElse.TabStop = true;
            this.rdbIfElse.Text = "If-Else";
            this.rdbIfElse.UseVisualStyleBackColor = true;
            // 
            // gpbapproach
            // 
            this.gpbapproach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpbapproach.Controls.Add(this.rdbsame);
            this.gpbapproach.Controls.Add(this.rdbDifferent);
            this.gpbapproach.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbapproach.Location = new System.Drawing.Point(544, 18);
            this.gpbapproach.Margin = new System.Windows.Forms.Padding(4);
            this.gpbapproach.Name = "gpbapproach";
            this.gpbapproach.Padding = new System.Windows.Forms.Padding(4);
            this.gpbapproach.Size = new System.Drawing.Size(321, 152);
            this.gpbapproach.TabIndex = 1;
            this.gpbapproach.TabStop = false;
            this.gpbapproach.Text = "Select your approach";
            // 
            // rdbsame
            // 
            this.rdbsame.AutoSize = true;
            this.rdbsame.Checked = true;
            this.rdbsame.Location = new System.Drawing.Point(64, 47);
            this.rdbsame.Margin = new System.Windows.Forms.Padding(4);
            this.rdbsame.Name = "rdbsame";
            this.rdbsame.Size = new System.Drawing.Size(161, 33);
            this.rdbsame.TabIndex = 2;
            this.rdbsame.TabStop = true;
            this.rdbsame.Text = "Same Class";
            this.rdbsame.UseVisualStyleBackColor = true;
            // 
            // rdbDifferent
            // 
            this.rdbDifferent.AutoSize = true;
            this.rdbDifferent.Location = new System.Drawing.Point(64, 98);
            this.rdbDifferent.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDifferent.Name = "rdbDifferent";
            this.rdbDifferent.Size = new System.Drawing.Size(198, 33);
            this.rdbDifferent.TabIndex = 3;
            this.rdbDifferent.Text = "Different Class";
            this.rdbDifferent.UseVisualStyleBackColor = true;
            // 
            // gpbRed
            // 
            this.gpbRed.Controls.Add(this.lblRed);
            this.gpbRed.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbRed.Location = new System.Drawing.Point(84, 192);
            this.gpbRed.Margin = new System.Windows.Forms.Padding(4);
            this.gpbRed.Name = "gpbRed";
            this.gpbRed.Padding = new System.Windows.Forms.Padding(4);
            this.gpbRed.Size = new System.Drawing.Size(228, 135);
            this.gpbRed.TabIndex = 2;
            this.gpbRed.TabStop = false;
            this.gpbRed.Text = "Red";
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRed.ForeColor = System.Drawing.Color.Cyan;
            this.lblRed.Location = new System.Drawing.Point(62, 50);
            this.lblRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(105, 48);
            this.lblRed.TabIndex = 4;
            this.lblRed.Text = "Red";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbGreen
            // 
            this.gpbGreen.Controls.Add(this.lblGreen);
            this.gpbGreen.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbGreen.Location = new System.Drawing.Point(396, 204);
            this.gpbGreen.Margin = new System.Windows.Forms.Padding(4);
            this.gpbGreen.Name = "gpbGreen";
            this.gpbGreen.Padding = new System.Windows.Forms.Padding(4);
            this.gpbGreen.Size = new System.Drawing.Size(218, 123);
            this.gpbGreen.TabIndex = 3;
            this.gpbGreen.TabStop = false;
            this.gpbGreen.Text = "Green";
            // 
            // lblGreen
            // 
            this.lblGreen.BackColor = System.Drawing.Color.Lime;
            this.lblGreen.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGreen.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblGreen.Location = new System.Drawing.Point(55, 49);
            this.lblGreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(102, 42);
            this.lblGreen.TabIndex = 5;
            this.lblGreen.Text = "Green";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbBlue
            // 
            this.gpbBlue.Controls.Add(this.lblBlue);
            this.gpbBlue.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbBlue.Location = new System.Drawing.Point(689, 204);
            this.gpbBlue.Margin = new System.Windows.Forms.Padding(4);
            this.gpbBlue.Name = "gpbBlue";
            this.gpbBlue.Padding = new System.Windows.Forms.Padding(4);
            this.gpbBlue.Size = new System.Drawing.Size(224, 123);
            this.gpbBlue.TabIndex = 3;
            this.gpbBlue.TabStop = false;
            this.gpbBlue.Text = "Blue";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.BackColor = System.Drawing.Color.Blue;
            this.lblBlue.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBlue.ForeColor = System.Drawing.Color.Yellow;
            this.lblBlue.Location = new System.Drawing.Point(74, 49);
            this.lblBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(79, 37);
            this.lblBlue.TabIndex = 6;
            this.lblBlue.Text = "Blue";
            // 
            // ckBoxRed
            // 
            this.ckBoxRed.AutoSize = true;
            this.ckBoxRed.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckBoxRed.ForeColor = System.Drawing.Color.Black;
            this.ckBoxRed.Location = new System.Drawing.Point(153, 335);
            this.ckBoxRed.Margin = new System.Windows.Forms.Padding(4);
            this.ckBoxRed.Name = "ckBoxRed";
            this.ckBoxRed.Size = new System.Drawing.Size(82, 33);
            this.ckBoxRed.TabIndex = 4;
            this.ckBoxRed.Text = "Red";
            this.ckBoxRed.UseVisualStyleBackColor = true;
            // 
            // ckBoxGreen
            // 
            this.ckBoxGreen.AutoSize = true;
            this.ckBoxGreen.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckBoxGreen.ForeColor = System.Drawing.Color.Black;
            this.ckBoxGreen.Location = new System.Drawing.Point(447, 335);
            this.ckBoxGreen.Margin = new System.Windows.Forms.Padding(4);
            this.ckBoxGreen.Name = "ckBoxGreen";
            this.ckBoxGreen.Size = new System.Drawing.Size(105, 33);
            this.ckBoxGreen.TabIndex = 5;
            this.ckBoxGreen.Text = "Green";
            this.ckBoxGreen.UseVisualStyleBackColor = true;
            // 
            // ckBoxBlue
            // 
            this.ckBoxBlue.AutoSize = true;
            this.ckBoxBlue.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckBoxBlue.ForeColor = System.Drawing.Color.Black;
            this.ckBoxBlue.Location = new System.Drawing.Point(755, 335);
            this.ckBoxBlue.Margin = new System.Windows.Forms.Padding(4);
            this.ckBoxBlue.Name = "ckBoxBlue";
            this.ckBoxBlue.Size = new System.Drawing.Size(87, 33);
            this.ckBoxBlue.TabIndex = 6;
            this.ckBoxBlue.Text = "Blue";
            this.ckBoxBlue.UseVisualStyleBackColor = true;
            // 
            // btnChangeBC
            // 
            this.btnChangeBC.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChangeBC.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChangeBC.Location = new System.Drawing.Point(396, 376);
            this.btnChangeBC.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeBC.Name = "btnChangeBC";
            this.btnChangeBC.Size = new System.Drawing.Size(240, 57);
            this.btnChangeBC.TabIndex = 7;
            this.btnChangeBC.Text = "Change BackColor";
            this.btnChangeBC.UseVisualStyleBackColor = false;
            this.btnChangeBC.Click += new System.EventHandler(this.btnChangeBC_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnExit.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnExit.Location = new System.Drawing.Point(951, 18);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(108, 39);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1054, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "                                                      ";
            // 
            // gpbR_bar
            // 
            this.gpbR_bar.BackColor = System.Drawing.Color.LightSalmon;
            this.gpbR_bar.Controls.Add(this.tb_R);
            this.gpbR_bar.Controls.Add(this.hScrollBar_R);
            this.gpbR_bar.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbR_bar.ForeColor = System.Drawing.Color.Red;
            this.gpbR_bar.Location = new System.Drawing.Point(44, 480);
            this.gpbR_bar.Margin = new System.Windows.Forms.Padding(4);
            this.gpbR_bar.Name = "gpbR_bar";
            this.gpbR_bar.Padding = new System.Windows.Forms.Padding(4);
            this.gpbR_bar.Size = new System.Drawing.Size(268, 188);
            this.gpbR_bar.TabIndex = 10;
            this.gpbR_bar.TabStop = false;
            this.gpbR_bar.Text = "Red";
            // 
            // hScrollBar_R
            // 
            this.hScrollBar_R.Location = new System.Drawing.Point(26, 114);
            this.hScrollBar_R.Maximum = 350;
            this.hScrollBar_R.Name = "hScrollBar_R";
            this.hScrollBar_R.Size = new System.Drawing.Size(217, 40);
            this.hScrollBar_R.TabIndex = 5;
            this.hScrollBar_R.ValueChanged += new System.EventHandler(this.bar_ColorChanged);
            // 
            // gpbG_bar
            // 
            this.gpbG_bar.BackColor = System.Drawing.Color.LightSalmon;
            this.gpbG_bar.Controls.Add(this.tb_G);
            this.gpbG_bar.Controls.Add(this.hScrollBar_G);
            this.gpbG_bar.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbG_bar.ForeColor = System.Drawing.Color.Green;
            this.gpbG_bar.Location = new System.Drawing.Point(377, 480);
            this.gpbG_bar.Margin = new System.Windows.Forms.Padding(4);
            this.gpbG_bar.Name = "gpbG_bar";
            this.gpbG_bar.Padding = new System.Windows.Forms.Padding(4);
            this.gpbG_bar.Size = new System.Drawing.Size(268, 188);
            this.gpbG_bar.TabIndex = 11;
            this.gpbG_bar.TabStop = false;
            this.gpbG_bar.Text = "Green";
            // 
            // hScrollBar_G
            // 
            this.hScrollBar_G.Location = new System.Drawing.Point(26, 114);
            this.hScrollBar_G.Maximum = 350;
            this.hScrollBar_G.Name = "hScrollBar_G";
            this.hScrollBar_G.Size = new System.Drawing.Size(217, 40);
            this.hScrollBar_G.TabIndex = 5;
            this.hScrollBar_G.ValueChanged += new System.EventHandler(this.bar_ColorChanged);
            // 
            // gpbB_bar
            // 
            this.gpbB_bar.BackColor = System.Drawing.Color.LightSalmon;
            this.gpbB_bar.Controls.Add(this.tb_B);
            this.gpbB_bar.Controls.Add(this.hScrollBar_B);
            this.gpbB_bar.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbB_bar.ForeColor = System.Drawing.Color.Blue;
            this.gpbB_bar.Location = new System.Drawing.Point(710, 480);
            this.gpbB_bar.Margin = new System.Windows.Forms.Padding(4);
            this.gpbB_bar.Name = "gpbB_bar";
            this.gpbB_bar.Padding = new System.Windows.Forms.Padding(4);
            this.gpbB_bar.Size = new System.Drawing.Size(268, 188);
            this.gpbB_bar.TabIndex = 12;
            this.gpbB_bar.TabStop = false;
            this.gpbB_bar.Text = "Blue";
            // 
            // hScrollBar_B
            // 
            this.hScrollBar_B.Location = new System.Drawing.Point(26, 114);
            this.hScrollBar_B.Maximum = 350;
            this.hScrollBar_B.Name = "hScrollBar_B";
            this.hScrollBar_B.Size = new System.Drawing.Size(217, 40);
            this.hScrollBar_B.TabIndex = 5;
            this.hScrollBar_B.ValueChanged += new System.EventHandler(this.bar_ColorChanged);
            // 
            // gpb_alpha
            // 
            this.gpb_alpha.BackColor = System.Drawing.Color.LightCoral;
            this.gpb_alpha.Controls.Add(this.tb_Alpha);
            this.gpb_alpha.Controls.Add(this.hScrollBar_Alpha);
            this.gpb_alpha.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpb_alpha.ForeColor = System.Drawing.Color.Black;
            this.gpb_alpha.Location = new System.Drawing.Point(377, 704);
            this.gpb_alpha.Margin = new System.Windows.Forms.Padding(4);
            this.gpb_alpha.Name = "gpb_alpha";
            this.gpb_alpha.Padding = new System.Windows.Forms.Padding(4);
            this.gpb_alpha.Size = new System.Drawing.Size(268, 188);
            this.gpb_alpha.TabIndex = 13;
            this.gpb_alpha.TabStop = false;
            this.gpb_alpha.Text = "Alpha";
            // 
            // hScrollBar_Alpha
            // 
            this.hScrollBar_Alpha.Location = new System.Drawing.Point(26, 114);
            this.hScrollBar_Alpha.Maximum = 350;
            this.hScrollBar_Alpha.Name = "hScrollBar_Alpha";
            this.hScrollBar_Alpha.Size = new System.Drawing.Size(217, 40);
            this.hScrollBar_Alpha.TabIndex = 5;
            this.hScrollBar_Alpha.ValueChanged += new System.EventHandler(this.bar_ColorChanged);
            // 
            // BtnColorMix
            // 
            this.BtnColorMix.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnColorMix.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnColorMix.Location = new System.Drawing.Point(396, 945);
            this.BtnColorMix.Margin = new System.Windows.Forms.Padding(4);
            this.BtnColorMix.Name = "BtnColorMix";
            this.BtnColorMix.Size = new System.Drawing.Size(240, 57);
            this.BtnColorMix.TabIndex = 14;
            this.BtnColorMix.Text = "執行色彩混合";
            this.BtnColorMix.UseVisualStyleBackColor = false;
            this.BtnColorMix.Click += new System.EventHandler(this.BtnColorMix_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnClose.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnClose.Location = new System.Drawing.Point(32, 963);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(108, 39);
            this.BtnClose.TabIndex = 15;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tb_R
            // 
            this.tb_R.BackColor = System.Drawing.SystemColors.Control;
            this.tb_R.Location = new System.Drawing.Point(51, 53);
            this.tb_R.Name = "tb_R";
            this.tb_R.Size = new System.Drawing.Size(170, 37);
            this.tb_R.TabIndex = 16;
            // 
            // tb_G
            // 
            this.tb_G.Location = new System.Drawing.Point(56, 53);
            this.tb_G.Name = "tb_G";
            this.tb_G.Size = new System.Drawing.Size(170, 37);
            this.tb_G.TabIndex = 17;
            // 
            // tb_B
            // 
            this.tb_B.Location = new System.Drawing.Point(45, 53);
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(170, 37);
            this.tb_B.TabIndex = 17;
            // 
            // tb_Alpha
            // 
            this.tb_Alpha.Location = new System.Drawing.Point(56, 52);
            this.tb_Alpha.Name = "tb_Alpha";
            this.tb_Alpha.Size = new System.Drawing.Size(170, 37);
            this.tb_Alpha.TabIndex = 17;
            // 
            // FrmSimpleColorMixture_Cheng3001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 1050);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnColorMix);
            this.Controls.Add(this.gpb_alpha);
            this.Controls.Add(this.gpbB_bar);
            this.Controls.Add(this.gpbG_bar);
            this.Controls.Add(this.gpbR_bar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.btnChangeBC);
            this.Controls.Add(this.ckBoxBlue);
            this.Controls.Add(this.ckBoxGreen);
            this.Controls.Add(this.ckBoxRed);
            this.Controls.Add(this.gpbGreen);
            this.Controls.Add(this.gpbBlue);
            this.Controls.Add(this.gpbRed);
            this.Controls.Add(this.gpbapproach);
            this.Controls.Add(this.gpbMethod);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSimpleColorMixture_Cheng3001";
            this.Text = "ColorTheme";
            this.gpbMethod.ResumeLayout(false);
            this.gpbMethod.PerformLayout();
            this.gpbapproach.ResumeLayout(false);
            this.gpbapproach.PerformLayout();
            this.gpbRed.ResumeLayout(false);
            this.gpbGreen.ResumeLayout(false);
            this.gpbBlue.ResumeLayout(false);
            this.gpbBlue.PerformLayout();
            this.gpbR_bar.ResumeLayout(false);
            this.gpbR_bar.PerformLayout();
            this.gpbG_bar.ResumeLayout(false);
            this.gpbG_bar.PerformLayout();
            this.gpbB_bar.ResumeLayout(false);
            this.gpbB_bar.PerformLayout();
            this.gpb_alpha.ResumeLayout(false);
            this.gpb_alpha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox gpbMethod;
        public System.Windows.Forms.RadioButton rdbswitch;
        public System.Windows.Forms.RadioButton rdbIfElse;
        public System.Windows.Forms.RadioButton rdbsame;
        public System.Windows.Forms.RadioButton rdbDifferent;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        public System.Windows.Forms.GroupBox gpbapproach;
        public System.Windows.Forms.GroupBox gpbRed;
        public System.Windows.Forms.GroupBox gpbGreen;
        public System.Windows.Forms.GroupBox gpbBlue;
        private System.Windows.Forms.CheckBox ckBoxRed;
        private System.Windows.Forms.CheckBox ckBoxGreen;
        private System.Windows.Forms.CheckBox ckBoxBlue;
        private System.Windows.Forms.Button btnChangeBC;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gpbR_bar;
        private System.Windows.Forms.HScrollBar hScrollBar_R;
        public System.Windows.Forms.GroupBox gpbG_bar;
        private System.Windows.Forms.HScrollBar hScrollBar_G;
        public System.Windows.Forms.GroupBox gpbB_bar;
        private System.Windows.Forms.HScrollBar hScrollBar_B;
        public System.Windows.Forms.GroupBox gpb_alpha;
        private System.Windows.Forms.HScrollBar hScrollBar_Alpha;
        private System.Windows.Forms.Button BtnColorMix;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox tb_R;
        private System.Windows.Forms.TextBox tb_G;
        private System.Windows.Forms.TextBox tb_B;
        private System.Windows.Forms.TextBox tb_Alpha;
    }
}

