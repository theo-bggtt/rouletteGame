namespace jeuRoulette
{
    public partial class Form1 : Form
    {
        Random rndr = new Random();
        int compte = 1000;
        List<int> nbRouge = new List<int> { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 32, 34, 36 };
        Dictionary<int, int> paris = new Dictionary<int, int>() { };
        int montant = 0;
        int num = 0;
        bool tourne = false;
        int rouge, noir, firsthalf, scdhalf, pair, impair, douzaine1, douzaine2, douzaine3, colonne1, colonne2, colonne3;
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
            lblBalance.Text = $"Compte : {compte} $";
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
            int num;
            Label lbl = (Label)sender;
            if (compte < montant)
            {
                MessageBox.Show("Montant insuffisant pour placer ce pari.");
                return;
            }
            compte -= montant;
            lblBalance.Text = $"Compte : {compte} $";
            if (lbl.Name == "lbl0")
            {
                num = 0;
            }
            else
            {
                num = int.Parse(lbl.Name);
                
            }
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
            AjouterJetonlbl(sender, montant);
        }

        private void pnlNum_Click(object sender, EventArgs e)
        {
            int num;
            Panel pnl = (Panel)sender;
            if (compte < montant)
            {
                MessageBox.Show("Montant insuffisant pour placer ce pari.");
                return;
            }
            compte -= montant;
            lblBalance.Text = $"Compte : {compte} $";
            if (pnl.Name == "pnl0")
            {
                num = 0;
            } else
            {
                num = int.Parse(pnl.Name);
            }
            if (paris.ContainsKey(num))
            {
                if (compte < montant)
                {
                    MessageBox.Show("Montant insuffisant pour placer ce pari.");
                    return;
                }
                paris[num] += montant;
                Console.WriteLine($"Pari mis à jour : {num} - Montant total : {paris[num]}");
            }
            else
            {
                if (compte < montant)
                {
                    MessageBox.Show("Montant insuffisant pour placer ce pari.");
                    return;
                }
                paris.Add(num, montant);
                Console.WriteLine($"Pari ajouté : {num} - Montant : {montant}");
                AjouterJeton(sender, montant);
            }
        }


        private void AjouterJeton(object sender, int montant)
        {
            Panel pnl = (Panel)sender;
            PictureBox jeton = new PictureBox();
            int nbparie = paris[Convert.ToInt32(pnl.Name)];

            switch (montant)
            {
                case 10:
                    jeton.Image = Properties.Resources.jeton10;
                    break;
                case 50:
                    jeton.Image = Properties.Resources.jeton50;
                    break;
                case 100:
                    jeton.Image = Properties.Resources.jeton100;
                    break;
                default:
                    MessageBox.Show("Montant de pari non reconnu.");
                    return;
            }
            jeton.SizeMode = PictureBoxSizeMode.StretchImage;
            jeton.Size = new Size(15, 15);
            jeton.Location = new Point(2*nbparie, 2*nbparie);
            jeton.BackColor = Color.Transparent;
            pnl.Controls.Add(jeton);
        }


        private void AjouterJetonlbl(object sender, int montant)
        {
            Label lbl = (Label)sender;
            Panel pnl = (Panel)lbl.Parent;

            PictureBox jeton = new PictureBox();
            switch (montant)
            {
                case 10:
                    jeton.Image = Properties.Resources.jeton10;
                    break;
                case 50:
                    jeton.Image = Properties.Resources.jeton50;
                    break;
                case 100:
                    jeton.Image = Properties.Resources.jeton100;
                    break;
                default:
                    MessageBox.Show("Montant de pari non reconnu.");
                    return;
            }
            jeton.SizeMode = PictureBoxSizeMode.StretchImage;
            jeton.Size = new Size(15, 15);
            jeton.Location = new Point(2, 2);
            jeton.BackColor = Color.Transparent;
            pnl.Controls.Add(jeton);
        }

        private void miserLbl_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if (compte < montant)
            {
                MessageBox.Show("Montant insuffisant pour placer ce pari.");
                return;
            }
            compte -= montant;
            lblBalance.Text = $"Compte : {compte} $";
            switch (lbl.Name)
            {
                case "lblrouge":
                    rouge += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Rouge");
                    break;
                case "lblnoir":
                    noir += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Noir");
                    break;
                case "lblpair":
                    pair += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Pair");
                    break;
                case "lblimpair":
                    impair += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Impair");
                    break;
                case "lbldouzaine1":
                    douzaine1 += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Douzaine 1");
                    break;
                case "lbldouzaine2":
                    douzaine2 += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Douzaine 2");
                    break;
                case "lbldouzaine3":
                    douzaine3 += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Douzaine 3");
                    break;
                case "lblcolonne1":
                    colonne1 += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Colonne 1");
                    break;
                case "lblcolonne2":
                    colonne2 += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Colonne 2");
                    break;
                case "lblcolonne3":
                    colonne3 += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Colonne 3");
                    break;
            }
            AjouterJetonlbl(sender, montant);
        }

        private void miserPnl_Click(object sender, EventArgs e)
        {
            Panel pnl = (Panel)sender;
            if (compte < montant)
            {
                MessageBox.Show("Montant insuffisant pour placer ce pari.");
                return;
            }
            compte -= montant;
            lblBalance.Text = $"Compte : {compte} $";
            switch (pnl.Name)
            {
                case "pnlrouge":
                    rouge += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Rouge");
                    break;
                case "pnlnoir":
                    noir += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Noir");
                    break;
                case "pnlpair":
                    pair += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Pair");
                    break;
                case "pnlimpair":
                    impair += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Impair");
                    break;
                case "pnldouzaine1":
                    douzaine1 += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Douzaine 1");
                    break;
                case "pnldouzaine2":
                    douzaine2 += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Douzaine 2");
                    break;
                case "pnldouzaine3":
                    douzaine3 += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Douzaine 3");
                    break;
                case "pnlcolonne1":
                    colonne1 += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Colonne 1");
                    break;
                case "pnlcolonne2":
                    colonne2 += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Colonne 2");
                    break;
                case "pnlcolonne3":
                    colonne3 += montant;
                    Console.WriteLine($"Pari mis : {montant} sur Colonne 3");
                    break;
            }
            AjouterJeton(sender, montant);
        }

        private async void btnLancerBoule_Click(object sender, EventArgs e)
        {
            if (tourne)
            {
                MessageBox.Show("La roulette est déjà en train de tourner !");
                return;
            }

            tourne = true;
            pictureBox4.Image = Properties.Resources.rouuuuulettteee;
            btnLancerBoule.Enabled = false;

            await Task.Delay(3000);

            pictureBox4.Image = Properties.Resources.roulettebougepas;
            num = rndr.Next(0, 37);
            Console.WriteLine($"Numéro tiré : {num}");
            int win = CheckForWin(num);

            if (paris.Count != 0)
            {
                if (win > 0)
                {
                    compte += win;
                    MessageBox.Show($"Vous avez gagné {win} !");
                }
                else
                {
                    MessageBox.Show("Désolé, vous n'avez rien gagné.");
                }
            }
            else
            {
                MessageBox.Show("Aucun pari n'a été placé.");
            }

            ResetBets();
            btnLancerBoule.Enabled = true;
            tourne = false;
        }

        private void ResetBets()
        {
                       paris.Clear();
            montant = 0;
            rouge = 0;
            noir = 0;
            firsthalf = 0;
            scdhalf = 0;
            pair = 0;
            impair = 0;
            douzaine1 = 0;
            douzaine2 = 0;
            douzaine3 = 0;
            colonne1 = 0;
            colonne2 = 0;
            colonne3 = 0;
            lblBalance.Text = $"Compte : {compte} $";
        }

        private int CheckForWin(int num)
        {
            int gains = 0;

            if (paris.ContainsKey(num))
            {
                gains += paris[num] * 35;
            }
            if (firsthalf > 0 && num >= 1 && num <= 18)
            {
                gains += firsthalf * 2;
            }
            if (scdhalf > 0 && num >= 19 && num <= 36)
            {
                gains += scdhalf * 2;
            }
            if (rouge > 0 && nbRouge.Contains(num))
            {
                gains += rouge * 2;
            }
            if (noir > 0 && !nbRouge.Contains(num) && num != 0)
            {
                gains += noir * 2;
            }
            if (pair > 0 && num != 0 && num % 2 == 0)
            {
                gains += pair * 2;
            }
            if (impair > 0 && num != 0 && num % 2 != 0)
            {
                gains += impair * 2;
            }
            if (douzaine1 > 0 && num >= 1 && num <= 12)
            {
                gains += douzaine1 * 2;
            }
            if (douzaine2 > 0 && num >= 13 && num <= 24)
            {
                gains += douzaine2 * 2;
            }
            if (douzaine3 > 0 && num >= 25 && num <= 36)
            {
                gains += douzaine3 * 2;
            }
            if (colonne1 > 0 && (num == 1 || num == 4 || num == 7 || num == 10 || num == 13 || num == 16 || num == 19 || num == 22 || num == 25 || num == 28 || num == 31 || num == 34))
            {
                gains += colonne1 * 2;
            }
            if (colonne2 > 0 && (num == 2 || num == 5 || num == 8 || num == 11 || num == 14 || num == 17 || num == 20 || num == 23 || num == 26 || num == 29 || num == 32 || num == 35))
            {
                gains += colonne2 * 2;
            }
            if (colonne3 > 0 && (num == 3 || num == 6 || num == 9 || num == 12 || num == 15 || num == 18 || num == 21 || num == 24 || num == 27 || num == 30 || num == 33 || num == 36))
            {
                gains += colonne3 * 2;
            }

            return gains;
        }


    }
}
