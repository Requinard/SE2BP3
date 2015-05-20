namespace SE2Tentamen
{
    using System;
    using System.Windows.Forms;

    public partial class Main : Form
    {
        private readonly Voorraad interneVoorraad;

        private decimal CashsoFar;

        /// <summary>
        ///     Initializes main form
        /// </summary>
        public Main()
        {
            this.InitializeComponent();
            this.interneVoorraad = new Voorraad();
            this.interneVoorraad.OnVoorraadUpdate += this.InterneVoorraadOnVoorraadUpdate;

            this.btnEuro020.Click += this.MoneyClick;
            this.btnEuro050.Click += this.MoneyClick;
            this.btnEuro100.Click += this.MoneyClick;
            this.btnEuro200.Click += this.MoneyClick;

            this.cbDrankSoort.SelectedIndex = 0;
        }

        /// <summary>
        ///     behandelt een druk op een money toevoeg knop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoneyClick(object sender, EventArgs e)
        {
            var send = (Button)sender;
            // Neem het geld gedeelte van de naam
            var text = send.Name.Substring(7, 3);

            // Converter het geldgedeelte naar decimaal en deel het door honderd. Dit is omdat er geen punten in de naam mogen zitten
            var amount = decimal.Parse(text) / 100;

            this.AddCash(amount);
        }

        /// <summary>
        ///     Event Handler voor als de voorraad geupdated is
        /// </summary>
        /// <param name="sender">Voorraad die het verstuurde</param>
        /// <param name="newItem">Nieuwe object wat toegevoegd is</param>
        private void InterneVoorraadOnVoorraadUpdate(object sender, object newItem)
        {
            this.PaintUI();
        }

        /// <summary>
        ///     Populeert de textboxes
        /// </summary>
        private void PaintUI()
        {
            this.lbVoorraad.Items.Clear();

            foreach (var drank in this.interneVoorraad.BeschikbareProducten())
            {
                this.lbVoorraad.Items.Add(drank);
            }

            this.lbDranken.Items.Clear();

            foreach (IVoorraad vooraad in this.interneVoorraad.VoorradigeDranken())
            {
                this.lbDranken.Items.Add(vooraad);
            }
        }

        /// <summary>
        ///     Handelt het toevoegen van een knop af
        /// </summary>
        /// <param name="sender">Knop die is ingedrukt</param>
        /// <param name="e">Verstuurde argumenten</param>
        private void btnDrankToevoegen_Click(object sender, EventArgs e)
        {
            //Initialiseer een leeg drankje omde volgende aan toe te voegen
            Drank drank = null;

            // Kijken of er wel text is ingevuld
            if (this.tbDrankNaam.Text == "")
            {
                MessageBox.Show("Je hebt geen naam van de drank ingevuld");
                return;
            }

            // als frisdrank is geselecteed
            if (this.cbDrankSoort.SelectedIndex == 0)
            {
                var frisdrank = new Frisdrank(
                    this.nudDrankPrijs.Value,
                    (int)this.nudDrankMilliliter.Value,
                    false,
                    (int)this.nudDrankVoedingswaarde.Value);
                drank = frisdrank;
            }
            //Als Koffie is geselecteerd
            else if (this.cbDrankSoort.SelectedIndex == 1)
            {
                var koffie = new Koffie(
                    this.nudDrankPrijs.Value,
                    (int)this.nudDrankMilliliter.Value,
                    true,
                    (int)this.nudDrankVoedingswaarde.Value);
                drank = koffie;
            }
            //Als er geen van beide is geselecteerd hebben we soep
            else
            {
                var soep = new Soep(this.nudDrankPrijs.Value, (int)this.nudDrankMilliliter.Value, true);
                drank = soep;
            }

            //Stel de naam in
            drank.Naam = this.tbDrankNaam.Text;

            //Voeg het toe aan de interne voorraad
            this.interneVoorraad.NieuwProduct(drank);
        }

        /// <summary>
        ///     Handelt het toevoegen van een beker af
        /// </summary>
        /// <param name="sender">Knop die is ingedrukt</param>
        /// <param name="e">Argumenten</param>
        private void btnBekerToevoegen_Click(object sender, EventArgs e)
        {
            // Als er geen naam is zijn we al klaar
            if (this.tbBekerNaam.Text == "")
            {
                MessageBox.Show("Je hebt geen bekernaam ingevuld");
                return;
            }

            // Initialiseer de beker
            var beker = new Beker(
                this.tbBekerNaam.Text,
                (int)this.nudBekerMilliliter.Value,
                this.chkBekerWarmeDrank.Checked);
            beker.Naam = this.tbBekerNaam.Text;

            // voegt de beker toe
            this.interneVoorraad.NieuwProduct(beker);
        }

        // Voegt een voorraad toe
        private void btnVoorraadToevoegen_Click(object sender, EventArgs e)
        {
            // Kijken of er iets is geselecteerd
            if (this.lbVoorraad.SelectedIndex == -1)
            {
                return;
            }

            //Voorraad uitlezen
            var voorraad = (IVoorraad)this.lbVoorraad.Items[this.lbVoorraad.SelectedIndex];

            //Bijvullen met de waarde van de NUD
            this.interneVoorraad.VulBij(voorraad, (int)this.nudVoorraadAantal.Value);
        }

        // We voegen geld toe aan ons register
        private void AddCash(decimal Howmuch)
        {
            this.CashsoFar += Howmuch;

            // Geef dit terug aan de form
            this.lblInworp.Text = string.Format("{0:0.00}", this.CashsoFar);
        }

        /// <summary>
        ///     Koopt een drankje
        /// </summary>
        /// <param name="sender">Knop die ingedrukt is</param>
        /// <param name="e">events args</param>
        private void btnKoopDrank_Click(object sender, EventArgs e)
        {
            // Kijken of er iets geselcteerd is
            if (this.lbDranken.SelectedIndex == -1)
            {
                return;
            }

            // We doen try/catch om te zien of er voldoende bekers zijn
            try
            {
                // cash van tevoren oplaan, aangezien hij verdwijnt na een aankoop
                var cash = ((Drank)this.lbDranken.SelectedItem).Prijs;

                //Aankoop proberen. Bij false is er niet genoeg geld
                if (this.interneVoorraad.KoopDrank((Drank)this.lbDranken.SelectedItem, this.CashsoFar))
                {
                    MessageBox.Show("Succes!");

                    // Globaal geld updaten
                    this.AddCash(-1 * cash);
                }
                else
                {
                    MessageBox.Show("niet genoeg geld");
                }
            }
            catch (OnVoldoendeBekersException)
            {
                MessageBox.Show("Niet genoeg bekers, of alleen maar verkeerde bekers");
            }
        }

        /// <summary>
        ///     Exporteert de log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExporteerLogbestand_Click(object sender, EventArgs e)
        {
            // Nieuwe dialog maken
            FileDialog fileDialog = new SaveFileDialog();
            //Deze laten zien
            fileDialog.ShowDialog();
            // Log exporteren
            this.interneVoorraad.ExporteerLog(fileDialog.FileName);
        }
    }
}