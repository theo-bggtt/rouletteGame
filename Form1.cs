namespace jeuRoulette
{
    public partial class Form1 : Form
    {
        Random rndr = new Random();
        List<int> nbRouge = new List<int> { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 32, 34, 36 };
        Dictionary<int, int> paris = new Dictionary<int, int>() { };
        int montant = 0;
        int num = 0;
        bool tourne = false;
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
            lblNum.Location = new Point(27, 1);
            lblNum.Name = num.ToString();
            lblNum.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNum.Size = new Size(36, 15);
            lblNum.TabIndex = 1;
            lblNum.Text = $"{num}";
            lblNum.TextAlign = ContentAlignment.MiddleCenter;
            lblNum.ForeColor = Color.White;
            lblNum.Click += new EventHandler(lblNum_Click);
            // 
            // pnlNum
            // 
            pnlNum.Controls.Add(lblNum);
            pnlNum.Location = new Point(0, 0);
            pnlNum.Margin = new Padding(0);
            pnlNum.Name = num.ToString();
            pnlNum.Size = new Size(90, 35);
            pnlNum.TabIndex = 0;
            pnlNum.BorderStyle = BorderStyle.FixedSingle;
            pnlNum.Padding = new Padding(5);
            if (nbRouge.Contains(num))
            {
                pnlNum.BackColor = Color.Red;
            }
            else
            {
                pnlNum.BackColor = Color.Black;
            }
            pnlNum.Click += new EventHandler(pnlNum_Click);

            return pnlNum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 37; i++)
            {
                flpTableDeJeu.Controls.Add(creeerPanel(i));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            montant = 10;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            montant = 50;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            montant = 100;
        }

        private void lblNum_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            int num = int.Parse(lbl.Name);
            if (paris.ContainsKey(num))
            {
                paris[num] += montant;
                Console.WriteLine($"Pari mis à jour : {num} - Montant total : {paris[num]}");
            }
            else
            {
                paris.Add(num, montant);
                Console.WriteLine($"Pari ajouté : {num} - Montant : {montant}");
            }
        }

        private void pnlNum_Click(object sender, EventArgs e)
        {
            Panel pnl = (Panel)sender;
            int num = int.Parse(pnl.Name);
            if (paris.ContainsKey(num))
            {
                paris[num] += montant;
                Console.WriteLine($"Pari mis à jour : {num} - Montant total : {paris[num]}");
            }
            else
            {
                paris.Add(num, montant);
                Console.WriteLine($"Pari ajouté : {num} - Montant : {montant}");
            }

        }

        private void btnLancerBoule_Click(object sender, EventArgs e)
        {
            // Lancer le gif de pictureBox4
            if (tourne)
            {
                MessageBox.Show("La roulette est déjà en train de tourner !");
                return;
            } else
            {
                pictureBox4.Image = Properties.Resources.rouuuuulettteee;
                tourne = true;
                Task.Delay(3000).ContinueWith(t => { pictureBox4.Image = Properties.Resources.roulettebougepas; });
                LancerBoule();
            }
        }

        private void LancerBoule()
        {
            num = rndr.Next(0, 37);
            Console.WriteLine($"Numéro tiré : {num}");
            if (paris.ContainsKey(num))
            {
                montant = paris[num];
                MessageBox.Show($"Vous avez gagné {montant * 35} € !");
                paris.Remove(num);
            }
            else
            {
                MessageBox.Show("Désolé, vous avez perdu !");
            }
            tourne = false;
        }
    }
}
