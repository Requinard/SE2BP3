namespace SE2Tentamen
{
    partial class Main
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
            this.btnKoopDrank = new System.Windows.Forms.Button();
            this.lbDranken = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEuro200 = new System.Windows.Forms.Button();
            this.btnEuro100 = new System.Windows.Forms.Button();
            this.btnEuro050 = new System.Windows.Forms.Button();
            this.btnEuro020 = new System.Windows.Forms.Button();
            this.lblInworp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudDrankPrijs = new System.Windows.Forms.NumericUpDown();
            this.btnDrankToevoegen = new System.Windows.Forms.Button();
            this.nudDrankVoedingswaarde = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDrankMilliliter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDrankNaam = new System.Windows.Forms.TextBox();
            this.cbDrankSoort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVoorraadToevoegen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nudVoorraadAantal = new System.Windows.Forms.NumericUpDown();
            this.lbVoorraad = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBekerToevoegen = new System.Windows.Forms.Button();
            this.chkBekerWarmeDrank = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudBekerMilliliter = new System.Windows.Forms.NumericUpDown();
            this.tbBekerNaam = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExporteerLogbestand = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrankPrijs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrankVoedingswaarde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrankMilliliter)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoorraadAantal)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBekerMilliliter)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKoopDrank
            // 
            this.btnKoopDrank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKoopDrank.Location = new System.Drawing.Point(120, 154);
            this.btnKoopDrank.Name = "btnKoopDrank";
            this.btnKoopDrank.Size = new System.Drawing.Size(95, 23);
            this.btnKoopDrank.TabIndex = 16;
            this.btnKoopDrank.Text = "Koop drank";
            this.btnKoopDrank.UseVisualStyleBackColor = true;
            this.btnKoopDrank.Click += new System.EventHandler(this.btnKoopDrank_Click);
            // 
            // lbDranken
            // 
            this.lbDranken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDranken.FormattingEnabled = true;
            this.lbDranken.Location = new System.Drawing.Point(15, 20);
            this.lbDranken.Name = "lbDranken";
            this.lbDranken.Size = new System.Drawing.Size(200, 95);
            this.lbDranken.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnEuro200);
            this.groupBox1.Controls.Add(this.btnEuro100);
            this.groupBox1.Controls.Add(this.btnEuro050);
            this.groupBox1.Controls.Add(this.btnEuro020);
            this.groupBox1.Controls.Add(this.lblInworp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbDranken);
            this.groupBox1.Controls.Add(this.btnKoopDrank);
            this.groupBox1.Location = new System.Drawing.Point(284, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 187);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drank kopen";
            // 
            // btnEuro200
            // 
            this.btnEuro200.Location = new System.Drawing.Point(66, 154);
            this.btnEuro200.Name = "btnEuro200";
            this.btnEuro200.Size = new System.Drawing.Size(45, 23);
            this.btnEuro200.TabIndex = 20;
            this.btnEuro200.Text = "€ 2,00";
            this.btnEuro200.UseVisualStyleBackColor = true;

            // 
            // btnEuro100
            // 
            this.btnEuro100.Location = new System.Drawing.Point(15, 154);
            this.btnEuro100.Name = "btnEuro100";
            this.btnEuro100.Size = new System.Drawing.Size(45, 23);
            this.btnEuro100.TabIndex = 19;
            this.btnEuro100.Text = "€ 1,00";
            this.btnEuro100.UseVisualStyleBackColor = true;

            // 
            // btnEuro050
            // 
            this.btnEuro050.Location = new System.Drawing.Point(66, 125);
            this.btnEuro050.Name = "btnEuro050";
            this.btnEuro050.Size = new System.Drawing.Size(45, 23);
            this.btnEuro050.TabIndex = 18;
            this.btnEuro050.Text = "€ 0,50";
            this.btnEuro050.UseVisualStyleBackColor = true;
 
            // 
            // btnEuro020
            // 
            this.btnEuro020.Location = new System.Drawing.Point(15, 125);
            this.btnEuro020.Name = "btnEuro020";
            this.btnEuro020.Size = new System.Drawing.Size(45, 23);
            this.btnEuro020.TabIndex = 17;
            this.btnEuro020.Text = "€ 0,20";
            this.btnEuro020.UseVisualStyleBackColor = true;
            // 
            // lblInworp
            // 
            this.lblInworp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInworp.AutoSize = true;
            this.lblInworp.Location = new System.Drawing.Point(187, 130);
            this.lblInworp.Name = "lblInworp";
            this.lblInworp.Size = new System.Drawing.Size(28, 13);
            this.lblInworp.TabIndex = 7;
            this.lblInworp.Text = "0,00";
            this.lblInworp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inworp:       €";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nudDrankPrijs);
            this.groupBox2.Controls.Add(this.btnDrankToevoegen);
            this.groupBox2.Controls.Add(this.nudDrankVoedingswaarde);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudDrankMilliliter);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbDrankNaam);
            this.groupBox2.Controls.Add(this.cbDrankSoort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 187);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nieuwe drank toevoegen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Verkoopprijs in €";
            // 
            // nudDrankPrijs
            // 
            this.nudDrankPrijs.DecimalPlaces = 2;
            this.nudDrankPrijs.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nudDrankPrijs.Location = new System.Drawing.Point(151, 73);
            this.nudDrankPrijs.Maximum = new decimal(new int[] {
            950,
            0,
            0,
            131072});
            this.nudDrankPrijs.Name = "nudDrankPrijs";
            this.nudDrankPrijs.Size = new System.Drawing.Size(95, 20);
            this.nudDrankPrijs.TabIndex = 3;
            this.nudDrankPrijs.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnDrankToevoegen
            // 
            this.btnDrankToevoegen.Location = new System.Drawing.Point(151, 152);
            this.btnDrankToevoegen.Name = "btnDrankToevoegen";
            this.btnDrankToevoegen.Size = new System.Drawing.Size(95, 23);
            this.btnDrankToevoegen.TabIndex = 6;
            this.btnDrankToevoegen.Text = "Toevoegen";
            this.btnDrankToevoegen.UseVisualStyleBackColor = true;
            this.btnDrankToevoegen.Click += new System.EventHandler(this.btnDrankToevoegen_Click);
            // 
            // nudDrankVoedingswaarde
            // 
            this.nudDrankVoedingswaarde.Location = new System.Drawing.Point(151, 126);
            this.nudDrankVoedingswaarde.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudDrankVoedingswaarde.Name = "nudDrankVoedingswaarde";
            this.nudDrankVoedingswaarde.Size = new System.Drawing.Size(95, 20);
            this.nudDrankVoedingswaarde.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "(Milli)gram suiker/cafeïne";
            // 
            // nudDrankMilliliter
            // 
            this.nudDrankMilliliter.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudDrankMilliliter.Location = new System.Drawing.Point(151, 99);
            this.nudDrankMilliliter.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudDrankMilliliter.Name = "nudDrankMilliliter";
            this.nudDrankMilliliter.Size = new System.Drawing.Size(95, 20);
            this.nudDrankMilliliter.TabIndex = 4;
            this.nudDrankMilliliter.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Milliliter per portie";
            // 
            // tbDrankNaam
            // 
            this.tbDrankNaam.Location = new System.Drawing.Point(151, 47);
            this.tbDrankNaam.Name = "tbDrankNaam";
            this.tbDrankNaam.Size = new System.Drawing.Size(95, 20);
            this.tbDrankNaam.TabIndex = 2;
            // 
            // cbDrankSoort
            // 
            this.cbDrankSoort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrankSoort.FormattingEnabled = true;
            this.cbDrankSoort.Items.AddRange(new object[] {
            "Frisdrank",
            "Koffie",
            "Soep"});
            this.cbDrankSoort.Location = new System.Drawing.Point(151, 20);
            this.cbDrankSoort.Name = "cbDrankSoort";
            this.cbDrankSoort.Size = new System.Drawing.Size(95, 21);
            this.cbDrankSoort.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Naam drank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soort drank";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnVoorraadToevoegen);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.nudVoorraadAantal);
            this.groupBox3.Controls.Add(this.lbVoorraad);
            this.groupBox3.Location = new System.Drawing.Point(284, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 187);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Voorraad";
            // 
            // btnVoorraadToevoegen
            // 
            this.btnVoorraadToevoegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoorraadToevoegen.Location = new System.Drawing.Point(120, 152);
            this.btnVoorraadToevoegen.Name = "btnVoorraadToevoegen";
            this.btnVoorraadToevoegen.Size = new System.Drawing.Size(95, 23);
            this.btnVoorraadToevoegen.TabIndex = 13;
            this.btnVoorraadToevoegen.Text = "Toevoegen";
            this.btnVoorraadToevoegen.UseVisualStyleBackColor = true;
            this.btnVoorraadToevoegen.Click += new System.EventHandler(this.btnVoorraadToevoegen_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Aantal";
            // 
            // nudVoorraadAantal
            // 
            this.nudVoorraadAantal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudVoorraadAantal.Location = new System.Drawing.Point(165, 126);
            this.nudVoorraadAantal.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudVoorraadAantal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVoorraadAantal.Name = "nudVoorraadAantal";
            this.nudVoorraadAantal.Size = new System.Drawing.Size(50, 20);
            this.nudVoorraadAantal.TabIndex = 12;
            this.nudVoorraadAantal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbVoorraad
            // 
            this.lbVoorraad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVoorraad.FormattingEnabled = true;
            this.lbVoorraad.Location = new System.Drawing.Point(15, 20);
            this.lbVoorraad.Name = "lbVoorraad";
            this.lbVoorraad.Size = new System.Drawing.Size(200, 95);
            this.lbVoorraad.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox4.Controls.Add(this.btnBekerToevoegen);
            this.groupBox4.Controls.Add(this.chkBekerWarmeDrank);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.nudBekerMilliliter);
            this.groupBox4.Controls.Add(this.tbBekerNaam);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 205);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 128);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nieuwe beker toevoegen";
            // 
            // btnBekerToevoegen
            // 
            this.btnBekerToevoegen.Location = new System.Drawing.Point(151, 93);
            this.btnBekerToevoegen.Name = "btnBekerToevoegen";
            this.btnBekerToevoegen.Size = new System.Drawing.Size(95, 23);
            this.btnBekerToevoegen.TabIndex = 10;
            this.btnBekerToevoegen.Text = "Toevoegen";
            this.btnBekerToevoegen.UseVisualStyleBackColor = true;
            this.btnBekerToevoegen.Click += new System.EventHandler(this.btnBekerToevoegen_Click);
            // 
            // chkBekerWarmeDrank
            // 
            this.chkBekerWarmeDrank.AutoSize = true;
            this.chkBekerWarmeDrank.Location = new System.Drawing.Point(151, 73);
            this.chkBekerWarmeDrank.Name = "chkBekerWarmeDrank";
            this.chkBekerWarmeDrank.Size = new System.Drawing.Size(15, 14);
            this.chkBekerWarmeDrank.TabIndex = 9;
            this.chkBekerWarmeDrank.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Warme drank mogelijk";
            // 
            // nudBekerMilliliter
            // 
            this.nudBekerMilliliter.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudBekerMilliliter.Location = new System.Drawing.Point(151, 46);
            this.nudBekerMilliliter.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudBekerMilliliter.Name = "nudBekerMilliliter";
            this.nudBekerMilliliter.Size = new System.Drawing.Size(95, 20);
            this.nudBekerMilliliter.TabIndex = 8;
            this.nudBekerMilliliter.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // tbBekerNaam
            // 
            this.tbBekerNaam.Location = new System.Drawing.Point(151, 20);
            this.tbBekerNaam.Name = "tbBekerNaam";
            this.tbBekerNaam.Size = new System.Drawing.Size(95, 20);
            this.tbBekerNaam.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Capacitieit in milliliters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Naam beker";
            // 
            // btnExporteerLogbestand
            // 
            this.btnExporteerLogbestand.Location = new System.Drawing.Point(15, 20);
            this.btnExporteerLogbestand.Name = "btnExporteerLogbestand";
            this.btnExporteerLogbestand.Size = new System.Drawing.Size(231, 23);
            this.btnExporteerLogbestand.TabIndex = 17;
            this.btnExporteerLogbestand.Text = "Exporteer logbestand";
            this.btnExporteerLogbestand.UseVisualStyleBackColor = true;
            this.btnExporteerLogbestand.Click += new System.EventHandler(this.btnExporteerLogbestand_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.btnExporteerLogbestand);
            this.groupBox5.Location = new System.Drawing.Point(12, 339);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(257, 53);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Overig";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 402);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(543, 440);
            this.Name = "Main";
            this.Text = "NAAM STUDENT - Drankautomaat Proof of Concept";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrankPrijs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrankVoedingswaarde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrankMilliliter)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoorraadAantal)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBekerMilliliter)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKoopDrank;
        private System.Windows.Forms.ListBox lbDranken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudDrankVoedingswaarde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDrankMilliliter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDrankNaam;
        private System.Windows.Forms.ComboBox cbDrankSoort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudDrankPrijs;
        private System.Windows.Forms.Button btnDrankToevoegen;
        private System.Windows.Forms.Button btnVoorraadToevoegen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudVoorraadAantal;
        private System.Windows.Forms.ListBox lbVoorraad;
        private System.Windows.Forms.Label lblInworp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbBekerNaam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudBekerMilliliter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBekerToevoegen;
        private System.Windows.Forms.CheckBox chkBekerWarmeDrank;
        private System.Windows.Forms.Button btnExporteerLogbestand;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnEuro200;
        private System.Windows.Forms.Button btnEuro100;
        private System.Windows.Forms.Button btnEuro050;
        private System.Windows.Forms.Button btnEuro020;


    }
}

