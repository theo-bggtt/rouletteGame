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
            flpTableDeJeu = new FlowLayoutPanel();
            pnlNum = new Panel();
            lblNum = new Label();
            flpTableDeJeu.SuspendLayout();
            pnlNum.SuspendLayout();
            SuspendLayout();
            // 
            // flpTableDeJeu
            // 
            flpTableDeJeu.Controls.Add(pnlNum);
            flpTableDeJeu.Location = new Point(462, 62);
            flpTableDeJeu.Name = "flpTableDeJeu";
            flpTableDeJeu.Size = new Size(270, 420);
            flpTableDeJeu.TabIndex = 0;
            flpTableDeJeu.Paint += flpTableDeJeu_Paint;
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
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new Point(29, 9);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(36, 15);
            lblNum.TabIndex = 1;
            lblNum.Text = "NULL";
            lblNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 569);
            Controls.Add(flpTableDeJeu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            flpTableDeJeu.ResumeLayout(false);
            pnlNum.ResumeLayout(false);
            pnlNum.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpTableDeJeu;
        private Panel pnlNum;
        private Label lblNum;
    }
}
