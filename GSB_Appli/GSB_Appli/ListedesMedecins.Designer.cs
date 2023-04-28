namespace GSB_Appli
{
    partial class ListedesMedecins
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
            this.dtgMedecin = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.département = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spécialité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ajoutermedecin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mdf_Medecin = new System.Windows.Forms.Button();
            this.sup_med = new System.Windows.Forms.Button();
            this.Specialite = new System.Windows.Forms.Label();
            this.textBoxDepartement = new System.Windows.Forms.TextBox();
            this.Departement = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.Label();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.Label();
            this.comboBoxSpecialite = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMedecin
            // 
            this.dtgMedecin.AllowUserToAddRows = false;
            this.dtgMedecin.AllowUserToDeleteRows = false;
            this.dtgMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedecin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nom,
            this.Prénom,
            this.Adresse,
            this.tel,
            this.département,
            this.spécialité});
            this.dtgMedecin.Location = new System.Drawing.Point(554, 134);
            this.dtgMedecin.Name = "dtgMedecin";
            this.dtgMedecin.ReadOnly = true;
            this.dtgMedecin.Size = new System.Drawing.Size(642, 365);
            this.dtgMedecin.TabIndex = 1;
            this.dtgMedecin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMedecin_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Prénom
            // 
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.Name = "Prénom";
            this.Prénom.ReadOnly = true;
            this.Prénom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            this.Adresse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tel
            // 
            this.tel.HeaderText = "tel";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            this.tel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // département
            // 
            this.département.HeaderText = "département";
            this.département.Name = "département";
            this.département.ReadOnly = true;
            this.département.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // spécialité
            // 
            this.spécialité.HeaderText = "spécialité";
            this.spécialité.Name = "spécialité";
            this.spécialité.ReadOnly = true;
            this.spécialité.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btn_ajoutermedecin
            // 
            this.btn_ajoutermedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutermedecin.Location = new System.Drawing.Point(17, 409);
            this.btn_ajoutermedecin.Name = "btn_ajoutermedecin";
            this.btn_ajoutermedecin.Size = new System.Drawing.Size(139, 60);
            this.btn_ajoutermedecin.TabIndex = 2;
            this.btn_ajoutermedecin.Text = "Ajouter";
            this.btn_ajoutermedecin.UseVisualStyleBackColor = true;
            this.btn_ajoutermedecin.Click += new System.EventHandler(this.btn_ajoutermedecin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste des Médecins";
            // 
            // mdf_Medecin
            // 
            this.mdf_Medecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdf_Medecin.Location = new System.Drawing.Point(162, 409);
            this.mdf_Medecin.Name = "mdf_Medecin";
            this.mdf_Medecin.Size = new System.Drawing.Size(146, 60);
            this.mdf_Medecin.TabIndex = 4;
            this.mdf_Medecin.Text = "Modifier";
            this.mdf_Medecin.UseVisualStyleBackColor = true;
            this.mdf_Medecin.Click += new System.EventHandler(this.mdf_Medecin_Click);
            // 
            // sup_med
            // 
            this.sup_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sup_med.Location = new System.Drawing.Point(314, 409);
            this.sup_med.Name = "sup_med";
            this.sup_med.Size = new System.Drawing.Size(147, 60);
            this.sup_med.TabIndex = 5;
            this.sup_med.Text = "Supprimer";
            this.sup_med.UseVisualStyleBackColor = true;
            this.sup_med.Click += new System.EventHandler(this.sup_med_Click);
            // 
            // Specialite
            // 
            this.Specialite.AutoSize = true;
            this.Specialite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specialite.Location = new System.Drawing.Point(6, 328);
            this.Specialite.Name = "Specialite";
            this.Specialite.Size = new System.Drawing.Size(91, 24);
            this.Specialite.TabIndex = 22;
            this.Specialite.Text = "Specialité";
            // 
            // textBoxDepartement
            // 
            this.textBoxDepartement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDepartement.Location = new System.Drawing.Point(131, 286);
            this.textBoxDepartement.Name = "textBoxDepartement";
            this.textBoxDepartement.Size = new System.Drawing.Size(282, 31);
            this.textBoxDepartement.TabIndex = 21;
            // 
            // Departement
            // 
            this.Departement.AutoSize = true;
            this.Departement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departement.Location = new System.Drawing.Point(6, 286);
            this.Departement.Name = "Departement";
            this.Departement.Size = new System.Drawing.Size(118, 24);
            this.Departement.TabIndex = 20;
            this.Departement.Text = "Département";
            // 
            // Telephone
            // 
            this.Telephone.AutoSize = true;
            this.Telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telephone.Location = new System.Drawing.Point(0, 238);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(114, 25);
            this.Telephone.TabIndex = 19;
            this.Telephone.Text = "Téléphone";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelephone.Location = new System.Drawing.Point(130, 236);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(283, 29);
            this.textBoxTelephone.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Adresse";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdresse.Location = new System.Drawing.Point(102, 183);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(283, 31);
            this.textBoxAdresse.TabIndex = 16;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(347, 134);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(181, 31);
            this.textBoxNom.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nom";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenom.Location = new System.Drawing.Point(123, 134);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(156, 31);
            this.textBoxPrenom.TabIndex = 13;
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prenom.Location = new System.Drawing.Point(31, 137);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(86, 25);
            this.Prenom.TabIndex = 12;
            this.Prenom.Text = "Prénom";
            // 
            // comboBoxSpecialite
            // 
            this.comboBoxSpecialite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSpecialite.FormattingEnabled = true;
            this.comboBoxSpecialite.Location = new System.Drawing.Point(103, 328);
            this.comboBoxSpecialite.Name = "comboBoxSpecialite";
            this.comboBoxSpecialite.Size = new System.Drawing.Size(283, 33);
            this.comboBoxSpecialite.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(36, 92);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Effacer";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(440, 328);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(70, 31);
            this.textBoxId.TabIndex = 25;
            this.textBoxId.Visible = false;
            // 
            // ListedesMedecins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 535);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.comboBoxSpecialite);
            this.Controls.Add(this.Specialite);
            this.Controls.Add(this.textBoxDepartement);
            this.Controls.Add(this.Departement);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.sup_med);
            this.Controls.Add(this.mdf_Medecin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ajoutermedecin);
            this.Controls.Add(this.dtgMedecin);
            this.Name = "ListedesMedecins";
            this.Text = "ListedesMedecins";
            this.Load += new System.EventHandler(this.ListedesMedecins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedecin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMedecin;
        private System.Windows.Forms.Button btn_ajoutermedecin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mdf_Medecin;
        private System.Windows.Forms.Button sup_med;
        private System.Windows.Forms.Label Specialite;
        private System.Windows.Forms.TextBox textBoxDepartement;
        private System.Windows.Forms.Label Departement;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.ComboBox comboBoxSpecialite;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn département;
        private System.Windows.Forms.DataGridViewTextBoxColumn spécialité;
        private System.Windows.Forms.TextBox textBoxId;
    }
}