namespace jeuRoulette
{
    public partial class Form1 : Form
    {
        Random rndr = new Random();
        int compte = 1000;
        List<int> nbRouge = new List<int> { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 32, 34, 36 };
        Dictionary<int, int> paris = new Dictionary<int, int>();
        int montant = 0;
        int num = 0;
        bool tourne = false;
        int rouge, noir, pair, impair, douzaine1, douzaine2, douzaine3, colonne1, colonne2, colonne3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 37; i++)
            {
                flpTableDeJeu.Controls.Add(CreerPanel(i));
            }
            lblBalance.Text = $"Compte : {compte} $";
        }

        /// <summary>
        /// Crée un panel pour chaque numéro de la roulette.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private Panel CreerPanel(int num)
        {
            Label lblNum = new Label();
            Panel pnlNum = new Panel();

            lblNum.AutoSize = true;
            lblNum.Location = new Point(27, 1);
            lblNum.Name = num.ToString();
            lblNum.Font = new Font("Segoe UI", 11F);
            lblNum.Text = $"{num}";
            lblNum.ForeColor = Color.White;
            lblNum.Click += lblNum_Click;

            pnlNum.Controls.Add(lblNum);
            pnlNum.Location = new Point(0, 0);
            pnlNum.Margin = new Padding(0);
            pnlNum.Name = num.ToString();
            pnlNum.Size = new Size(90, 35);
            pnlNum.BorderStyle = BorderStyle.FixedSingle;
            pnlNum.Padding = new Padding(5);
            pnlNum.BackColor = nbRouge.Contains(num) ? Color.Red : Color.Black;
            pnlNum.Click += pnlNum_Click;

            return pnlNum;
        }

        /// <summary>
        /// Enéève le montant du compte si suffisant pour le pari.
        /// </summary>
        /// <returns></returns>
        private bool DebiterMontant()
        {
            if (compte < montant)
            {
                MessageBox.Show("Montant insuffisant pour placer ce pari.");
                return false;
            }
            compte -= montant;
            lblBalance.Text = $"Compte : {compte} $";
            return true;
        }

        /// <summary>
        /// Affiche un jeton
        /// </summary>
        /// <param name="control"></param>
        /// <param name="montant"></param>
        private void AjouterJeton(Control control, int montant)
        {
            Panel pnl = control is Panel ? (Panel)control : (Panel)control.Parent;
            PictureBox jeton = new PictureBox();

            jeton.Image = montant switch
            {
                10 => Properties.Resources.jeton10,
                50 => Properties.Resources.jeton50,
                100 => Properties.Resources.jeton100,
                _ => null
            };

            if (jeton.Image == null)
            {
                MessageBox.Show("Montant de pari non reconnu.");
                return;
            }

            jeton.SizeMode = PictureBoxSizeMode.StretchImage;
            jeton.Size = new Size(15, 15);
            jeton.Location = new Point(2, 2);
            jeton.BackColor = Color.Transparent;
            pnl.Controls.Add(jeton);
        }

        private void pictureBox1_Click(object sender, EventArgs e) => montant = 10;
        private void pictureBox3_Click(object sender, EventArgs e) => montant = 50;
        private void pictureBox2_Click(object sender, EventArgs e) => montant = 100;

        private void lblNum_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl == null) return;
            int num = int.Parse(lbl.Name);

            if (!DebiterMontant()) return;

            if (paris.ContainsKey(num))
                paris[num] += montant;
            else
                paris[num] = montant;

            tbxLog.AppendText($"Pari sur {num} - Total : {paris[num]}" + Environment.NewLine);
            AjouterJeton(lbl, montant);
        }

        private void pnlNum_Click(object sender, EventArgs e)
        {
            Panel pnl = sender as Panel;
            if (pnl == null) return;
            int num = int.Parse(pnl.Name);

            if (!DebiterMontant()) return;

            if (paris.ContainsKey(num))
                paris[num] += montant;
            else
                paris[num] = montant;

            tbxLog.AppendText($"Pari sur {num} - Total : {paris[num]}" + Environment.NewLine);
            AjouterJeton(pnl, montant);
        }

        /// <summary>
        /// Miser sur un type de pari spécifique (rouge, noir, pair, impair, douzaine, colonne).
        /// </summary>
        /// <param name="typePari"></param>
        private void MiserSur(string typePari)
        {
            if (!DebiterMontant()) return;

            switch (typePari)
            {
                case "rouge": rouge += montant; break;
                case "noir": noir += montant; break;
                case "pair": pair += montant; break;
                case "impair": impair += montant; break;
                case "douzaine1": douzaine1 += montant; break;
                case "douzaine2": douzaine2 += montant; break;
                case "douzaine3": douzaine3 += montant; break;
                case "colonne1": colonne1 += montant; break;
                case "colonne2": colonne2 += montant; break;
                case "colonne3": colonne3 += montant; break;
                default: MessageBox.Show("Type de pari non reconnu."); return;
            }
            tbxLog.AppendText($"Pari mis : {montant} sur {typePari}"+Environment.NewLine);
        }

        private void miserLbl_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl == null) return;
            MiserSur(lbl.Name.Replace("lbl", ""));
            AjouterJeton(lbl, montant);
        }

        private void miserPnl_Click(object sender, EventArgs e)
        {
            Panel pnl = sender as Panel;
            if (pnl == null) return;
            MiserSur(pnl.Name.Replace("pnl", ""));
            AjouterJeton(pnl, montant);
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
            // Retour à la ligne

            tbxLog.AppendText($"Numéro tiré : {num}" + Environment.NewLine);
            int gain = CheckForWin(num);

            if (paris.Count > 0 || rouge + noir + pair + impair + douzaine1 + douzaine2 + douzaine3 + colonne1 + colonne2 + colonne3 > 0)
            {
                if (gain > 0)
                {
                    compte += gain;
                    MessageBox.Show($"Vous avez gagné {gain} !");
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

        /// <summary>
        /// Reset les paris et les jetons placés sur la table.
        /// </summary>
        private void ResetBets()
        {
            foreach (Control ctrl in flpTableDeJeu.Controls)
            {
                if (ctrl is Panel pnl)
                {
                    var jetons = pnl.Controls.OfType<PictureBox>().ToList();
                    foreach (var jeton in jetons)
                    {
                        pnl.Controls.Remove(jeton);
                        jeton.Dispose();
                    }
                }
            }
            var zonesPari = this.Controls.Find("lblrouge", true).Concat(
                            this.Controls.Find("lblnoir", true)).Concat(
                            this.Controls.Find("lblpair", true)).Concat(
                            this.Controls.Find("lblimpair", true)).Concat(
                            this.Controls.Find("lbldouzaine1", true)).Concat(
                            this.Controls.Find("lbldouzaine2", true)).Concat(
                            this.Controls.Find("lbldouzaine3", true)).Concat(
                            this.Controls.Find("lblcolonne1", true)).Concat(
                            this.Controls.Find("lblcolonne2", true)).Concat(
                            this.Controls.Find("lblcolonne3", true)).Concat(
                            this.Controls.Find("pnlrouge", true)).Concat(
                            this.Controls.Find("pnlnoir", true)).Concat(
                            this.Controls.Find("pnlpair", true)).Concat(
                            this.Controls.Find("pnlimpair", true)).Concat(
                            this.Controls.Find("pnldouzaine1", true)).Concat(
                            this.Controls.Find("pnldouzaine2", true)).Concat(
                            this.Controls.Find("pnldouzaine3", true)).Concat(
                            this.Controls.Find("pnlcolonne1", true)).Concat(
                            this.Controls.Find("pnlcolonne2", true)).Concat(
                            this.Controls.Find("pnlcolonne3", true));

            foreach (var zone in zonesPari)
            {
                if (zone is Control parent)
                {
                    var jetons = parent.Controls.OfType<PictureBox>().ToList();
                    foreach (var jeton in jetons)
                    {
                        parent.Controls.Remove(jeton);
                        jeton.Dispose();
                    }
                }
            }

            paris.Clear();
            montant = 0;
            rouge = noir = pair = impair = douzaine1 = douzaine2 = douzaine3 = colonne1 = colonne2 = colonne3 = 0;
            lblBalance.Text = $"Compte : {compte} $";
        }

        /// <summary>
        /// Vérifie les gains en fonction du numéro tiré et des paris placés.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private int CheckForWin(int num)
        {
            int gains = 0;

            if (paris.ContainsKey(num)) gains += paris[num] * 35;
            if (rouge > 0 && nbRouge.Contains(num)) gains += rouge * 2;
            if (noir > 0 && !nbRouge.Contains(num) && num != 0) gains += noir * 2;
            if (pair > 0 && num != 0 && num % 2 == 0) gains += pair * 2;
            if (impair > 0 && num % 2 != 0) gains += impair * 2;
            if (douzaine1 > 0 && num >= 1 && num <= 12) gains += douzaine1 * 2;
            if (douzaine2 > 0 && num >= 13 && num <= 24) gains += douzaine2 * 2;
            if (douzaine3 > 0 && num >= 25 && num <= 36) gains += douzaine3 * 2;

            var colonne1Nums = Enumerable.Range(1, 36).Where(n => (n - 1) % 3 == 0);
            var colonne2Nums = Enumerable.Range(1, 36).Where(n => (n - 1) % 3 == 1);
            var colonne3Nums = Enumerable.Range(1, 36).Where(n => (n - 1) % 3 == 2);

            if (colonne1 > 0 && colonne1Nums.Contains(num)) gains += colonne1 * 2;
            if (colonne2 > 0 && colonne2Nums.Contains(num)) gains += colonne2 * 2;
            if (colonne3 > 0 && colonne3Nums.Contains(num)) gains += colonne3 * 2;

            return gains;
        }
    }
}
