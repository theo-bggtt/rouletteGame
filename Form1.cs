namespace jeuRoulette
{
    public partial class Form1 : Form
    {
        List<int> nbRouge = new List<int> { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 32, 34, 36 };
        public Form1()
        {
            InitializeComponent();
        }

        private void flpTableDeJeu_Paint(object sender, PaintEventArgs e)
        {

        }

        private Panel creeerPanel(int num)
        {
            Label lblNum = new Label();
            Panel pnlNum = new Panel();
            //
            // lblNum
            //
            lblNum.AutoSize = true;
            lblNum.Location = new Point(29, 0);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(36, 15);
            lblNum.TabIndex = 1;
            lblNum.Text = $"{num}";
            lblNum.TextAlign = ContentAlignment.TopCenter;
            lblNum.ForeColor = Color.White;
            // 
            // pnlNum
            // 
            pnlNum.Controls.Add(lblNum);
            pnlNum.Location = new Point(0, 0);
            pnlNum.Margin = new Padding(0);
            pnlNum.Name = "pnlNum";
            pnlNum.Size = new Size(90, 35);
            pnlNum.TabIndex = 0;
            pnlNum.BorderStyle = BorderStyle.FixedSingle;
            pnlNum.Padding = new Padding(10);
            if (nbRouge.Contains(num))
            {
                pnlNum.BackColor = Color.Red;
            }
            else
            {
                pnlNum.BackColor = Color.Black;
            }
            
            return pnlNum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 37; i++)
            {
                flpTableDeJeu.Controls.Add(creeerPanel(i));
            }
        }
    }
}
