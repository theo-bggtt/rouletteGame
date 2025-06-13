namespace jeuRoulette
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flpTableDeJeu = new FlowLayoutPanel();
            pnlNum = new Panel();
            lblNum = new Label();
            pnldouzaine1 = new Panel();
            lbldouzaine1 = new Label();
            pnldouzaine2 = new Panel();
            lbldouzaine2 = new Label();
            pnldouzaine3 = new Panel();
            lbldouzaine3 = new Label();
            pnl0 = new Panel();
            lbl0 = new Label();
            pnlcolonne1 = new Panel();
            lblcolonne1 = new Label();
            pnlcolonne3 = new Panel();
            lblcolonne3 = new Label();
            pnlcolonne2 = new Panel();
            lblcolonne2 = new Label();
            pnlimpair = new Panel();
            lblimpair = new Label();
            pnlnoir = new Panel();
            lblnoir = new Label();
            pnlpair = new Panel();
            lblpair = new Label();
            pnlrouge = new Panel();
            lblrouge = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            pictureBox4 = new PictureBox();
            btnLancerBoule = new Button();
            lblTir = new Label();
            lblBalance = new Label();
            tbxLog = new TextBox();
            flpTableDeJeu.SuspendLayout();
            pnlNum.SuspendLayout();
            pnldouzaine1.SuspendLayout();
            pnldouzaine2.SuspendLayout();
            pnldouzaine3.SuspendLayout();
            pnl0.SuspendLayout();
            pnlcolonne1.SuspendLayout();
            pnlcolonne3.SuspendLayout();
            pnlcolonne2.SuspendLayout();
            pnlimpair.SuspendLayout();
            pnlnoir.SuspendLayout();
            pnlpair.SuspendLayout();
            pnlrouge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // flpTableDeJeu
            // 
            flpTableDeJeu.Controls.Add(pnlNum);
            flpTableDeJeu.Location = new Point(696, 61);
            flpTableDeJeu.Name = "flpTableDeJeu";
            flpTableDeJeu.Size = new Size(270, 420);
            flpTableDeJeu.TabIndex = 0;
            // 
            // pnlNum
            // 
            pnlNum.Controls.Add(lblNum);
            pnlNum.Location = new Point(0, 0);
            pnlNum.Margin = new Padding(0);
            pnlNum.Name = "pnlNum";
            pnlNum.Size = new Size(90, 35);
            pnlNum.TabIndex = 0;
            pnlNum.Visible = false;
            pnlNum.Click += pnlNum_Click;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Font = new Font("Segoe UI", 11F);
            lblNum.Location = new Point(29, 9);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(44, 20);
            lblNum.TabIndex = 1;
            lblNum.Text = "NULL";
            lblNum.TextAlign = ContentAlignment.MiddleCenter;
            lblNum.Click += lblNum_Click;
            // 
            // pnldouzaine1
            // 
            pnldouzaine1.BorderStyle = BorderStyle.FixedSingle;
            pnldouzaine1.Controls.Add(lbldouzaine1);
            pnldouzaine1.Location = new Point(606, 61);
            pnldouzaine1.Name = "pnldouzaine1";
            pnldouzaine1.Size = new Size(90, 140);
            pnldouzaine1.TabIndex = 1;
            pnldouzaine1.Click += miserPnl_Click;
            // 
            // lbldouzaine1
            // 
            lbldouzaine1.AutoSize = true;
            lbldouzaine1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbldouzaine1.ForeColor = Color.White;
            lbldouzaine1.Location = new Point(10, 55);
            lbldouzaine1.Name = "lbldouzaine1";
            lbldouzaine1.Size = new Size(68, 25);
            lbldouzaine1.TabIndex = 3;
            lbldouzaine1.Text = "1er 12";
            lbldouzaine1.Click += miserLbl_Click;
            // 
            // pnldouzaine2
            // 
            pnldouzaine2.BorderStyle = BorderStyle.FixedSingle;
            pnldouzaine2.Controls.Add(lbldouzaine2);
            pnldouzaine2.Location = new Point(606, 201);
            pnldouzaine2.Name = "pnldouzaine2";
            pnldouzaine2.Size = new Size(90, 140);
            pnldouzaine2.TabIndex = 3;
            pnldouzaine2.Click += miserPnl_Click;
            // 
            // lbldouzaine2
            // 
            lbldouzaine2.AutoSize = true;
            lbldouzaine2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbldouzaine2.ForeColor = Color.White;
            lbldouzaine2.Location = new Point(14, 55);
            lbldouzaine2.Name = "lbldouzaine2";
            lbldouzaine2.Size = new Size(60, 25);
            lbldouzaine2.TabIndex = 4;
            lbldouzaine2.Text = "2e 12";
            lbldouzaine2.Click += miserLbl_Click;
            // 
            // pnldouzaine3
            // 
            pnldouzaine3.BorderStyle = BorderStyle.FixedSingle;
            pnldouzaine3.Controls.Add(lbldouzaine3);
            pnldouzaine3.Location = new Point(606, 341);
            pnldouzaine3.Name = "pnldouzaine3";
            pnldouzaine3.Size = new Size(90, 140);
            pnldouzaine3.TabIndex = 4;
            pnldouzaine3.Click += miserPnl_Click;
            // 
            // lbldouzaine3
            // 
            lbldouzaine3.AutoSize = true;
            lbldouzaine3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbldouzaine3.ForeColor = Color.White;
            lbldouzaine3.Location = new Point(14, 55);
            lbldouzaine3.Name = "lbldouzaine3";
            lbldouzaine3.Size = new Size(60, 25);
            lbldouzaine3.TabIndex = 5;
            lbldouzaine3.Text = "3e 12";
            lbldouzaine3.Click += miserLbl_Click;
            // 
            // pnl0
            // 
            pnl0.BackColor = Color.Green;
            pnl0.BorderStyle = BorderStyle.FixedSingle;
            pnl0.Controls.Add(lbl0);
            pnl0.Location = new Point(696, 26);
            pnl0.Margin = new Padding(0);
            pnl0.Name = "pnl0";
            pnl0.Size = new Size(270, 35);
            pnl0.TabIndex = 2;
            pnl0.Click += pnlNum_Click;
            // 
            // lbl0
            // 
            lbl0.AutoSize = true;
            lbl0.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl0.ForeColor = Color.White;
            lbl0.Location = new Point(124, 3);
            lbl0.Name = "lbl0";
            lbl0.Size = new Size(23, 25);
            lbl0.TabIndex = 1;
            lbl0.Text = "0";
            lbl0.TextAlign = ContentAlignment.MiddleCenter;
            lbl0.Click += lblNum_Click;
            // 
            // pnlcolonne1
            // 
            pnlcolonne1.BorderStyle = BorderStyle.FixedSingle;
            pnlcolonne1.Controls.Add(lblcolonne1);
            pnlcolonne1.Location = new Point(696, 480);
            pnlcolonne1.Margin = new Padding(0);
            pnlcolonne1.Name = "pnlcolonne1";
            pnlcolonne1.Size = new Size(90, 35);
            pnlcolonne1.TabIndex = 2;
            pnlcolonne1.Click += miserPnl_Click;
            // 
            // lblcolonne1
            // 
            lblcolonne1.AutoSize = true;
            lblcolonne1.Font = new Font("Segoe UI", 11F);
            lblcolonne1.ForeColor = Color.White;
            lblcolonne1.Location = new Point(30, 6);
            lblcolonne1.Name = "lblcolonne1";
            lblcolonne1.Size = new Size(28, 20);
            lblcolonne1.TabIndex = 1;
            lblcolonne1.Text = "2:1";
            lblcolonne1.TextAlign = ContentAlignment.MiddleCenter;
            lblcolonne1.Click += miserLbl_Click;
            // 
            // pnlcolonne3
            // 
            pnlcolonne3.BorderStyle = BorderStyle.FixedSingle;
            pnlcolonne3.Controls.Add(lblcolonne3);
            pnlcolonne3.Location = new Point(876, 480);
            pnlcolonne3.Margin = new Padding(0);
            pnlcolonne3.Name = "pnlcolonne3";
            pnlcolonne3.Size = new Size(90, 35);
            pnlcolonne3.TabIndex = 3;
            pnlcolonne3.Click += miserPnl_Click;
            // 
            // lblcolonne3
            // 
            lblcolonne3.AutoSize = true;
            lblcolonne3.Font = new Font("Segoe UI", 11F);
            lblcolonne3.ForeColor = Color.White;
            lblcolonne3.Location = new Point(30, 6);
            lblcolonne3.Name = "lblcolonne3";
            lblcolonne3.Size = new Size(28, 20);
            lblcolonne3.TabIndex = 1;
            lblcolonne3.Text = "2:1";
            lblcolonne3.TextAlign = ContentAlignment.MiddleCenter;
            lblcolonne3.Click += miserLbl_Click;
            // 
            // pnlcolonne2
            // 
            pnlcolonne2.BorderStyle = BorderStyle.FixedSingle;
            pnlcolonne2.Controls.Add(lblcolonne2);
            pnlcolonne2.Location = new Point(786, 480);
            pnlcolonne2.Margin = new Padding(0);
            pnlcolonne2.Name = "pnlcolonne2";
            pnlcolonne2.Size = new Size(90, 35);
            pnlcolonne2.TabIndex = 4;
            pnlcolonne2.Click += miserPnl_Click;
            // 
            // lblcolonne2
            // 
            lblcolonne2.AutoSize = true;
            lblcolonne2.Font = new Font("Segoe UI", 11F);
            lblcolonne2.ForeColor = Color.White;
            lblcolonne2.Location = new Point(30, 6);
            lblcolonne2.Name = "lblcolonne2";
            lblcolonne2.Size = new Size(28, 20);
            lblcolonne2.TabIndex = 1;
            lblcolonne2.Text = "2:1";
            lblcolonne2.TextAlign = ContentAlignment.MiddleCenter;
            lblcolonne2.Click += miserLbl_Click;
            // 
            // pnlimpair
            // 
            pnlimpair.BorderStyle = BorderStyle.FixedSingle;
            pnlimpair.Controls.Add(lblimpair);
            pnlimpair.Location = new Point(510, 341);
            pnlimpair.Name = "pnlimpair";
            pnlimpair.Size = new Size(90, 70);
            pnlimpair.TabIndex = 7;
            pnlimpair.Click += miserPnl_Click;
            // 
            // lblimpair
            // 
            lblimpair.AutoSize = true;
            lblimpair.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblimpair.ForeColor = Color.White;
            lblimpair.Location = new Point(9, 20);
            lblimpair.Name = "lblimpair";
            lblimpair.Size = new Size(70, 25);
            lblimpair.TabIndex = 13;
            lblimpair.Text = "Impair";
            lblimpair.Click += miserLbl_Click;
            // 
            // pnlnoir
            // 
            pnlnoir.BackColor = Color.Black;
            pnlnoir.BorderStyle = BorderStyle.FixedSingle;
            pnlnoir.Controls.Add(lblnoir);
            pnlnoir.Location = new Point(510, 271);
            pnlnoir.Name = "pnlnoir";
            pnlnoir.Size = new Size(90, 70);
            pnlnoir.TabIndex = 8;
            pnlnoir.Click += miserPnl_Click;
            // 
            // lblnoir
            // 
            lblnoir.AutoSize = true;
            lblnoir.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblnoir.ForeColor = Color.White;
            lblnoir.Location = new Point(18, 21);
            lblnoir.Name = "lblnoir";
            lblnoir.Size = new Size(52, 25);
            lblnoir.TabIndex = 15;
            lblnoir.Text = "Noir";
            lblnoir.Click += miserLbl_Click;
            // 
            // pnlpair
            // 
            pnlpair.BorderStyle = BorderStyle.FixedSingle;
            pnlpair.Controls.Add(lblpair);
            pnlpair.Location = new Point(510, 131);
            pnlpair.Name = "pnlpair";
            pnlpair.Size = new Size(90, 70);
            pnlpair.TabIndex = 8;
            pnlpair.Click += miserPnl_Click;
            // 
            // lblpair
            // 
            lblpair.AutoSize = true;
            lblpair.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblpair.ForeColor = Color.White;
            lblpair.Location = new Point(21, 20);
            lblpair.Name = "lblpair";
            lblpair.Size = new Size(47, 25);
            lblpair.TabIndex = 12;
            lblpair.Text = "Pair";
            lblpair.Click += miserLbl_Click;
            // 
            // pnlrouge
            // 
            pnlrouge.BackColor = Color.Red;
            pnlrouge.BorderStyle = BorderStyle.FixedSingle;
            pnlrouge.Controls.Add(lblrouge);
            pnlrouge.Location = new Point(510, 201);
            pnlrouge.Name = "pnlrouge";
            pnlrouge.Size = new Size(90, 70);
            pnlrouge.TabIndex = 8;
            pnlrouge.Click += miserPnl_Click;
            // 
            // lblrouge
            // 
            lblrouge.AutoSize = true;
            lblrouge.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblrouge.ForeColor = Color.White;
            lblrouge.Location = new Point(9, 20);
            lblrouge.Name = "lblrouge";
            lblrouge.Size = new Size(70, 25);
            lblrouge.TabIndex = 14;
            lblrouge.Text = "Rouge";
            lblrouge.Click += miserLbl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(147, 465);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(292, 465);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(222, 465);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.White;
            label15.Location = new Point(163, 518);
            label15.Name = "label15";
            label15.Size = new Size(19, 15);
            label15.TabIndex = 12;
            label15.Text = "10";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.White;
            label16.Location = new Point(237, 518);
            label16.Name = "label16";
            label16.Size = new Size(19, 15);
            label16.TabIndex = 13;
            label16.Text = "50";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.White;
            label17.Location = new Point(305, 518);
            label17.Name = "label17";
            label17.Size = new Size(25, 15);
            label17.TabIndex = 14;
            label17.Text = "100";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(123, 30);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(261, 271);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // btnLancerBoule
            // 
            btnLancerBoule.Location = new Point(192, 411);
            btnLancerBoule.Name = "btnLancerBoule";
            btnLancerBoule.Size = new Size(110, 23);
            btnLancerBoule.TabIndex = 16;
            btnLancerBoule.Text = "lance la boule";
            btnLancerBoule.UseVisualStyleBackColor = true;
            btnLancerBoule.Click += btnLancerBoule_Click;
            // 
            // lblTir
            // 
            lblTir.AutoSize = true;
            lblTir.ForeColor = Color.White;
            lblTir.Location = new Point(225, 326);
            lblTir.Name = "lblTir";
            lblTir.Size = new Size(0, 15);
            lblTir.TabIndex = 17;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBalance.ForeColor = Color.White;
            lblBalance.Location = new Point(405, 9);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(141, 25);
            lblBalance.TabIndex = 18;
            lblBalance.Text = "Compte : 1000";
            // 
            // tbxLog
            // 
            tbxLog.BackColor = Color.Black;
            tbxLog.BorderStyle = BorderStyle.None;
            tbxLog.ForeColor = Color.White;
            tbxLog.Location = new Point(123, 298);
            tbxLog.Multiline = true;
            tbxLog.Name = "tbxLog";
            tbxLog.Size = new Size(261, 107);
            tbxLog.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 58, 27);
            ClientSize = new Size(984, 561);
            ControlBox = false;
            Controls.Add(tbxLog);
            Controls.Add(lblBalance);
            Controls.Add(lblTir);
            Controls.Add(btnLancerBoule);
            Controls.Add(pictureBox4);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pnlrouge);
            Controls.Add(pnlpair);
            Controls.Add(pnlnoir);
            Controls.Add(pnlimpair);
            Controls.Add(pnlcolonne2);
            Controls.Add(pnlcolonne3);
            Controls.Add(pnlcolonne1);
            Controls.Add(pnl0);
            Controls.Add(pnldouzaine3);
            Controls.Add(pnldouzaine2);
            Controls.Add(pnldouzaine1);
            Controls.Add(flpTableDeJeu);
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Form1";
            Load += Form1_Load;
            flpTableDeJeu.ResumeLayout(false);
            pnlNum.ResumeLayout(false);
            pnlNum.PerformLayout();
            pnldouzaine1.ResumeLayout(false);
            pnldouzaine1.PerformLayout();
            pnldouzaine2.ResumeLayout(false);
            pnldouzaine2.PerformLayout();
            pnldouzaine3.ResumeLayout(false);
            pnldouzaine3.PerformLayout();
            pnl0.ResumeLayout(false);
            pnl0.PerformLayout();
            pnlcolonne1.ResumeLayout(false);
            pnlcolonne1.PerformLayout();
            pnlcolonne3.ResumeLayout(false);
            pnlcolonne3.PerformLayout();
            pnlcolonne2.ResumeLayout(false);
            pnlcolonne2.PerformLayout();
            pnlimpair.ResumeLayout(false);
            pnlimpair.PerformLayout();
            pnlnoir.ResumeLayout(false);
            pnlnoir.PerformLayout();
            pnlpair.ResumeLayout(false);
            pnlpair.PerformLayout();
            pnlrouge.ResumeLayout(false);
            pnlrouge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpTableDeJeu;
        private Panel pnlNum;
        private Label lblNum;
        private Panel pnldouzaine1;
        private Panel pnldouzaine2;
        private Panel pnldouzaine3;
        private Label lbldouzaine1;
        private Label lbldouzaine2;
        private Label lbldouzaine3;
        private Panel pnl0;
        private Label lbl0;
        private Panel pnlcolonne1;
        private Label lblcolonne1;
        private Panel pnlcolonne3;
        private Label lblcolonne3;
        private Panel pnlcolonne2;
        private Label lblcolonne2;
        private Panel pnlimpair;
        private Panel pnlnoir;
        private Panel pnlpair;
        private Panel pnlrouge;
        private Label lblimpair;
        private Label lblnoir;
        private Label lblpair;
        private Label lblrouge;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label15;
        private Label label16;
        private Label label17;
        private PictureBox pictureBox4;
        private Button btnLancerBoule;
        private Label lblTir;
        private Label lblBalance;
        private TextBox tbxLog;
    }
}
