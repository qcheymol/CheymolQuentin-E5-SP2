
namespace GSB_Appli
{
    partial class ListedesRapport
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
            this.btQuitter = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDateRapport = new System.Windows.Forms.DateTimePicker();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lvMedicaments = new System.Windows.Forms.ListView();
            this.colMedicament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNomMedecin = new System.Windows.Forms.TextBox();
            this.txtPrenomMedecin = new System.Windows.Forms.TextBox();
            this.txtAdresseMedecin = new System.Windows.Forms.TextBox();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.lbPrenomM = new System.Windows.Forms.Label();
            this.lbNomM = new System.Windows.Forms.Label();
            this.lb2Medecins = new System.Windows.Forms.Label();
            this.txtPrenomVisiteur = new System.Windows.Forms.TextBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.txtNomVisiteur = new System.Windows.Forms.TextBox();
            this.lbBilan = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbMotif = new System.Windows.Forms.Label();
            this.lbPrenomV = new System.Windows.Forms.Label();
            this.lbNomV = new System.Windows.Forms.Label();
            this.lb2Visiteurs = new System.Windows.Forms.Label();
            this.lbRapports = new System.Windows.Forms.Label();
            this.listRapports = new System.Windows.Forms.ListBox();
            this.lbMedecins = new System.Windows.Forms.Label();
            this.btRechercherMedecin = new System.Windows.Forms.Button();
            this.comboBoxMedecin = new System.Windows.Forms.ComboBox();
            this.lbVisiteurs = new System.Windows.Forms.Label();
            this.btRechercherVisiteur = new System.Windows.Forms.Button();
            this.comboBoxVisiteur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(680, 516);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(104, 39);
            this.btQuitter.TabIndex = 140;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btModifier
            // 
            this.btModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModifier.Location = new System.Drawing.Point(541, 516);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(102, 39);
            this.btModifier.TabIndex = 139;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.label1.Location = new System.Drawing.Point(52, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 138;
            this.label1.Text = "Echantillons offerts";
            // 
            // dtDateRapport
            // 
            this.dtDateRapport.Location = new System.Drawing.Point(188, 362);
            this.dtDateRapport.Name = "dtDateRapport";
            this.dtDateRapport.Size = new System.Drawing.Size(237, 20);
            this.dtDateRapport.TabIndex = 137;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(670, 51);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(102, 39);
            this.btn_Clear.TabIndex = 136;
            this.btn_Clear.Text = "Effacer";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lvMedicaments
            // 
            this.lvMedicaments.BackColor = System.Drawing.SystemColors.Control;
            this.lvMedicaments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMedicament,
            this.colQuantite});
            this.lvMedicaments.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lvMedicaments.FullRowSelect = true;
            this.lvMedicaments.GridLines = true;
            this.lvMedicaments.HideSelection = false;
            this.lvMedicaments.Location = new System.Drawing.Point(188, 446);
            this.lvMedicaments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvMedicaments.Name = "lvMedicaments";
            this.lvMedicaments.Scrollable = false;
            this.lvMedicaments.Size = new System.Drawing.Size(237, 109);
            this.lvMedicaments.TabIndex = 135;
            this.lvMedicaments.UseCompatibleStateImageBehavior = false;
            this.lvMedicaments.View = System.Windows.Forms.View.Details;
            // 
            // colMedicament
            // 
            this.colMedicament.Text = "Médicaments offerts";
            this.colMedicament.Width = 150;
            // 
            // colQuantite
            // 
            this.colQuantite.Text = "Quantité";
            this.colQuantite.Width = 80;
            // 
            // txtNomMedecin
            // 
            this.txtNomMedecin.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomMedecin.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtNomMedecin.Location = new System.Drawing.Point(541, 270);
            this.txtNomMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomMedecin.Name = "txtNomMedecin";
            this.txtNomMedecin.Size = new System.Drawing.Size(231, 25);
            this.txtNomMedecin.TabIndex = 134;
            // 
            // txtPrenomMedecin
            // 
            this.txtPrenomMedecin.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrenomMedecin.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtPrenomMedecin.Location = new System.Drawing.Point(541, 312);
            this.txtPrenomMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrenomMedecin.Name = "txtPrenomMedecin";
            this.txtPrenomMedecin.Size = new System.Drawing.Size(231, 25);
            this.txtPrenomMedecin.TabIndex = 133;
            // 
            // txtAdresseMedecin
            // 
            this.txtAdresseMedecin.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdresseMedecin.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtAdresseMedecin.Location = new System.Drawing.Point(541, 354);
            this.txtAdresseMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdresseMedecin.Name = "txtAdresseMedecin";
            this.txtAdresseMedecin.Size = new System.Drawing.Size(231, 25);
            this.txtAdresseMedecin.TabIndex = 132;
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbAdresse.Location = new System.Drawing.Point(476, 357);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(58, 18);
            this.lbAdresse.TabIndex = 131;
            this.lbAdresse.Text = "Adresse";
            // 
            // lbPrenomM
            // 
            this.lbPrenomM.AutoSize = true;
            this.lbPrenomM.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbPrenomM.Location = new System.Drawing.Point(476, 316);
            this.lbPrenomM.Name = "lbPrenomM";
            this.lbPrenomM.Size = new System.Drawing.Size(57, 18);
            this.lbPrenomM.TabIndex = 130;
            this.lbPrenomM.Text = "Prénom";
            // 
            // lbNomM
            // 
            this.lbNomM.AutoSize = true;
            this.lbNomM.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbNomM.Location = new System.Drawing.Point(476, 279);
            this.lbNomM.Name = "lbNomM";
            this.lbNomM.Size = new System.Drawing.Size(38, 18);
            this.lbNomM.TabIndex = 129;
            this.lbNomM.Text = "Nom";
            // 
            // lb2Medecins
            // 
            this.lb2Medecins.AutoSize = true;
            this.lb2Medecins.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lb2Medecins.Location = new System.Drawing.Point(453, 240);
            this.lb2Medecins.Name = "lb2Medecins";
            this.lb2Medecins.Size = new System.Drawing.Size(62, 18);
            this.lb2Medecins.TabIndex = 128;
            this.lb2Medecins.Text = "Médecin";
            // 
            // txtPrenomVisiteur
            // 
            this.txtPrenomVisiteur.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrenomVisiteur.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtPrenomVisiteur.Location = new System.Drawing.Point(188, 293);
            this.txtPrenomVisiteur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrenomVisiteur.Name = "txtPrenomVisiteur";
            this.txtPrenomVisiteur.Size = new System.Drawing.Size(237, 25);
            this.txtPrenomVisiteur.TabIndex = 127;
            // 
            // txtMotif
            // 
            this.txtMotif.BackColor = System.Drawing.SystemColors.Control;
            this.txtMotif.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtMotif.Location = new System.Drawing.Point(188, 330);
            this.txtMotif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(237, 25);
            this.txtMotif.TabIndex = 126;
            // 
            // txtBilan
            // 
            this.txtBilan.BackColor = System.Drawing.SystemColors.Control;
            this.txtBilan.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtBilan.Location = new System.Drawing.Point(188, 400);
            this.txtBilan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(237, 25);
            this.txtBilan.TabIndex = 125;
            // 
            // txtNomVisiteur
            // 
            this.txtNomVisiteur.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomVisiteur.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtNomVisiteur.Location = new System.Drawing.Point(188, 256);
            this.txtNomVisiteur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomVisiteur.Name = "txtNomVisiteur";
            this.txtNomVisiteur.Size = new System.Drawing.Size(237, 25);
            this.txtNomVisiteur.TabIndex = 124;
            // 
            // lbBilan
            // 
            this.lbBilan.AutoSize = true;
            this.lbBilan.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbBilan.Location = new System.Drawing.Point(74, 404);
            this.lbBilan.Name = "lbBilan";
            this.lbBilan.Size = new System.Drawing.Size(39, 18);
            this.lbBilan.TabIndex = 123;
            this.lbBilan.Text = "Bilan";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbDate.Location = new System.Drawing.Point(74, 368);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(107, 18);
            this.lbDate.TabIndex = 122;
            this.lbDate.Text = "Date de la visite";
            // 
            // lbMotif
            // 
            this.lbMotif.AutoSize = true;
            this.lbMotif.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbMotif.Location = new System.Drawing.Point(74, 334);
            this.lbMotif.Name = "lbMotif";
            this.lbMotif.Size = new System.Drawing.Size(111, 18);
            this.lbMotif.TabIndex = 121;
            this.lbMotif.Text = "Motif de la visite";
            // 
            // lbPrenomV
            // 
            this.lbPrenomV.AutoSize = true;
            this.lbPrenomV.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbPrenomV.Location = new System.Drawing.Point(74, 297);
            this.lbPrenomV.Name = "lbPrenomV";
            this.lbPrenomV.Size = new System.Drawing.Size(57, 18);
            this.lbPrenomV.TabIndex = 120;
            this.lbPrenomV.Text = "Prénom";
            // 
            // lbNomV
            // 
            this.lbNomV.AutoSize = true;
            this.lbNomV.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbNomV.Location = new System.Drawing.Point(74, 260);
            this.lbNomV.Name = "lbNomV";
            this.lbNomV.Size = new System.Drawing.Size(38, 18);
            this.lbNomV.TabIndex = 119;
            this.lbNomV.Text = "Nom";
            // 
            // lb2Visiteurs
            // 
            this.lb2Visiteurs.AutoSize = true;
            this.lb2Visiteurs.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lb2Visiteurs.Location = new System.Drawing.Point(52, 226);
            this.lb2Visiteurs.Name = "lb2Visiteurs";
            this.lb2Visiteurs.Size = new System.Drawing.Size(57, 18);
            this.lb2Visiteurs.TabIndex = 118;
            this.lb2Visiteurs.Text = "Visiteur";
            // 
            // lbRapports
            // 
            this.lbRapports.AutoSize = true;
            this.lbRapports.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbRapports.Location = new System.Drawing.Point(52, 163);
            this.lbRapports.Name = "lbRapports";
            this.lbRapports.Size = new System.Drawing.Size(119, 18);
            this.lbRapports.TabIndex = 117;
            this.lbRapports.Text = "Rapports de visite";
            // 
            // listRapports
            // 
            this.listRapports.BackColor = System.Drawing.SystemColors.Control;
            this.listRapports.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.listRapports.FormattingEnabled = true;
            this.listRapports.ItemHeight = 17;
            this.listRapports.Location = new System.Drawing.Point(188, 128);
            this.listRapports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listRapports.Name = "listRapports";
            this.listRapports.Size = new System.Drawing.Size(217, 89);
            this.listRapports.TabIndex = 116;
            this.listRapports.SelectedIndexChanged += new System.EventHandler(this.listRapports_SelectedIndexChanged);
            // 
            // lbMedecins
            // 
            this.lbMedecins.AutoSize = true;
            this.lbMedecins.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbMedecins.Location = new System.Drawing.Point(52, 85);
            this.lbMedecins.Name = "lbMedecins";
            this.lbMedecins.Size = new System.Drawing.Size(62, 18);
            this.lbMedecins.TabIndex = 115;
            this.lbMedecins.Text = "Médecin";
            // 
            // btRechercherMedecin
            // 
            this.btRechercherMedecin.Location = new System.Drawing.Point(440, 78);
            this.btRechercherMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRechercherMedecin.Name = "btRechercherMedecin";
            this.btRechercherMedecin.Size = new System.Drawing.Size(87, 30);
            this.btRechercherMedecin.TabIndex = 114;
            this.btRechercherMedecin.Text = "Rechercher";
            this.btRechercherMedecin.UseVisualStyleBackColor = true;
            this.btRechercherMedecin.Click += new System.EventHandler(this.btRechercherMedecin_Click);
            // 
            // comboBoxMedecin
            // 
            this.comboBoxMedecin.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxMedecin.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.comboBoxMedecin.FormattingEnabled = true;
            this.comboBoxMedecin.Location = new System.Drawing.Point(188, 78);
            this.comboBoxMedecin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMedecin.Name = "comboBoxMedecin";
            this.comboBoxMedecin.Size = new System.Drawing.Size(217, 25);
            this.comboBoxMedecin.TabIndex = 113;
            // 
            // lbVisiteurs
            // 
            this.lbVisiteurs.AutoSize = true;
            this.lbVisiteurs.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.lbVisiteurs.Location = new System.Drawing.Point(52, 35);
            this.lbVisiteurs.Name = "lbVisiteurs";
            this.lbVisiteurs.Size = new System.Drawing.Size(57, 18);
            this.lbVisiteurs.TabIndex = 143;
            this.lbVisiteurs.Text = "Visiteur";
            // 
            // btRechercherVisiteur
            // 
            this.btRechercherVisiteur.Location = new System.Drawing.Point(440, 31);
            this.btRechercherVisiteur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRechercherVisiteur.Name = "btRechercherVisiteur";
            this.btRechercherVisiteur.Size = new System.Drawing.Size(87, 30);
            this.btRechercherVisiteur.TabIndex = 142;
            this.btRechercherVisiteur.Text = "Rechercher";
            this.btRechercherVisiteur.UseVisualStyleBackColor = true;
            this.btRechercherVisiteur.Click += new System.EventHandler(this.btRechercherVisiteur_Click);
            // 
            // comboBoxVisiteur
            // 
            this.comboBoxVisiteur.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxVisiteur.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.comboBoxVisiteur.FormattingEnabled = true;
            this.comboBoxVisiteur.Location = new System.Drawing.Point(188, 31);
            this.comboBoxVisiteur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxVisiteur.Name = "comboBoxVisiteur";
            this.comboBoxVisiteur.Size = new System.Drawing.Size(217, 25);
            this.comboBoxVisiteur.TabIndex = 141;
            // 
            // ListedesRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 580);
            this.Controls.Add(this.lbVisiteurs);
            this.Controls.Add(this.btRechercherVisiteur);
            this.Controls.Add(this.comboBoxVisiteur);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDateRapport);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lvMedicaments);
            this.Controls.Add(this.txtNomMedecin);
            this.Controls.Add(this.txtPrenomMedecin);
            this.Controls.Add(this.txtAdresseMedecin);
            this.Controls.Add(this.lbAdresse);
            this.Controls.Add(this.lbPrenomM);
            this.Controls.Add(this.lbNomM);
            this.Controls.Add(this.lb2Medecins);
            this.Controls.Add(this.txtPrenomVisiteur);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.txtNomVisiteur);
            this.Controls.Add(this.lbBilan);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbMotif);
            this.Controls.Add(this.lbPrenomV);
            this.Controls.Add(this.lbNomV);
            this.Controls.Add(this.lb2Visiteurs);
            this.Controls.Add(this.lbRapports);
            this.Controls.Add(this.listRapports);
            this.Controls.Add(this.lbMedecins);
            this.Controls.Add(this.btRechercherMedecin);
            this.Controls.Add(this.comboBoxMedecin);
            this.Name = "ListedesRapport";
            this.Text = "ListedesRapport";
            this.Load += new System.EventHandler(this.ListedesRapport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDateRapport;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ListView lvMedicaments;
        private System.Windows.Forms.ColumnHeader colMedicament;
        private System.Windows.Forms.ColumnHeader colQuantite;
        private System.Windows.Forms.TextBox txtNomMedecin;
        private System.Windows.Forms.TextBox txtPrenomMedecin;
        private System.Windows.Forms.TextBox txtAdresseMedecin;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.Label lbPrenomM;
        private System.Windows.Forms.Label lbNomM;
        private System.Windows.Forms.Label lb2Medecins;
        private System.Windows.Forms.TextBox txtPrenomVisiteur;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.TextBox txtNomVisiteur;
        private System.Windows.Forms.Label lbBilan;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbMotif;
        private System.Windows.Forms.Label lbPrenomV;
        private System.Windows.Forms.Label lbNomV;
        private System.Windows.Forms.Label lb2Visiteurs;
        private System.Windows.Forms.Label lbRapports;
        private System.Windows.Forms.ListBox listRapports;
        private System.Windows.Forms.Label lbMedecins;
        private System.Windows.Forms.Button btRechercherMedecin;
        private System.Windows.Forms.ComboBox comboBoxMedecin;
        private System.Windows.Forms.Label lbVisiteurs;
        private System.Windows.Forms.Button btRechercherVisiteur;
        private System.Windows.Forms.ComboBox comboBoxVisiteur;
    }
}