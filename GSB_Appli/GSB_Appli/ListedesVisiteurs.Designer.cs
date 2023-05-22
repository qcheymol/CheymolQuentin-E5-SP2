namespace GSB_Appli
{
    partial class ListedesVisiteurs
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
            this.dataGridVisiteur = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEmbauche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.Departement = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sup_Visiteur = new System.Windows.Forms.Button();
            this.mdf_Visiteur = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ajoutervisiteur = new System.Windows.Forms.Button();
            this.dateTimeVisiteur = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLoginVisiteur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxmdpVisiteur = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVisiteur
            // 
            this.dataGridVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVisiteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nom,
            this.Prenom,
            this.DateEmbauche,
            this.CodePostal,
            this.Ville});
            this.dataGridVisiteur.Location = new System.Drawing.Point(12, 12);
            this.dataGridVisiteur.Name = "dataGridVisiteur";
            this.dataGridVisiteur.Size = new System.Drawing.Size(642, 624);
            this.dataGridVisiteur.TabIndex = 4;
            this.dataGridVisiteur.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVisiteur_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // DateEmbauche
            // 
            this.DateEmbauche.HeaderText = "DateEmbauche";
            this.DateEmbauche.Name = "DateEmbauche";
            // 
            // CodePostal
            // 
            this.CodePostal.HeaderText = "CodePostal";
            this.CodePostal.Name = "CodePostal";
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(682, 106);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Effacer";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBoxVille
            // 
            this.textBoxVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVille.Location = new System.Drawing.Point(730, 364);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(282, 31);
            this.textBoxVille.TabIndex = 39;
            // 
            // Departement
            // 
            this.Departement.AutoSize = true;
            this.Departement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departement.Location = new System.Drawing.Point(678, 368);
            this.Departement.Name = "Departement";
            this.Departement.Size = new System.Drawing.Size(46, 24);
            this.Departement.TabIndex = 38;
            this.Departement.Text = "Ville";
            // 
            // Telephone
            // 
            this.Telephone.AutoSize = true;
            this.Telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telephone.Location = new System.Drawing.Point(674, 256);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(179, 25);
            this.Telephone.TabIndex = 37;
            this.Telephone.Text = "Date d\'embauche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(677, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Code Postal";
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodePostal.Location = new System.Drawing.Point(812, 200);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(283, 31);
            this.textBoxCodePostal.TabIndex = 34;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(993, 151);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(181, 31);
            this.textBoxNom.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(931, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nom";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenom.Location = new System.Drawing.Point(769, 151);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(156, 31);
            this.textBoxPrenom.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(677, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Prénom";
            // 
            // sup_Visiteur
            // 
            this.sup_Visiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sup_Visiteur.Location = new System.Drawing.Point(992, 475);
            this.sup_Visiteur.Name = "sup_Visiteur";
            this.sup_Visiteur.Size = new System.Drawing.Size(147, 60);
            this.sup_Visiteur.TabIndex = 29;
            this.sup_Visiteur.Text = "Supprimer";
            this.sup_Visiteur.UseVisualStyleBackColor = true;
            this.sup_Visiteur.Click += new System.EventHandler(this.sup_Visiteur_Click);
            // 
            // mdf_Visiteur
            // 
            this.mdf_Visiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdf_Visiteur.Location = new System.Drawing.Point(840, 475);
            this.mdf_Visiteur.Name = "mdf_Visiteur";
            this.mdf_Visiteur.Size = new System.Drawing.Size(146, 60);
            this.mdf_Visiteur.TabIndex = 28;
            this.mdf_Visiteur.Text = "Modifier";
            this.mdf_Visiteur.UseVisualStyleBackColor = true;
            this.mdf_Visiteur.Click += new System.EventHandler(this.mdf_Visiteur_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(762, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 42);
            this.label4.TabIndex = 27;
            this.label4.Text = "Liste des Visiteurs";
            // 
            // btn_ajoutervisiteur
            // 
            this.btn_ajoutervisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutervisiteur.Location = new System.Drawing.Point(695, 475);
            this.btn_ajoutervisiteur.Name = "btn_ajoutervisiteur";
            this.btn_ajoutervisiteur.Size = new System.Drawing.Size(139, 60);
            this.btn_ajoutervisiteur.TabIndex = 26;
            this.btn_ajoutervisiteur.Text = "Ajouter";
            this.btn_ajoutervisiteur.UseVisualStyleBackColor = true;
            this.btn_ajoutervisiteur.Click += new System.EventHandler(this.btn_ajoutervisiteur_Click);
            // 
            // dateTimeVisiteur
            // 
            this.dateTimeVisiteur.Location = new System.Drawing.Point(859, 259);
            this.dateTimeVisiteur.Name = "dateTimeVisiteur";
            this.dateTimeVisiteur.Size = new System.Drawing.Size(239, 20);
            this.dateTimeVisiteur.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(679, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Login";
            // 
            // textBoxLoginVisiteur
            // 
            this.textBoxLoginVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoginVisiteur.Location = new System.Drawing.Point(718, 424);
            this.textBoxLoginVisiteur.Name = "textBoxLoginVisiteur";
            this.textBoxLoginVisiteur.Size = new System.Drawing.Size(156, 31);
            this.textBoxLoginVisiteur.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(880, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Mot de passe";
            // 
            // textBoxmdpVisiteur
            // 
            this.textBoxmdpVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmdpVisiteur.Location = new System.Drawing.Point(957, 424);
            this.textBoxmdpVisiteur.Name = "textBoxmdpVisiteur";
            this.textBoxmdpVisiteur.Size = new System.Drawing.Size(156, 31);
            this.textBoxmdpVisiteur.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(678, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 49;
            this.label7.Text = "Adresse";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdresse.Location = new System.Drawing.Point(764, 310);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(282, 31);
            this.textBoxAdresse.TabIndex = 50;
            // 
            // ListedesVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 648);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxmdpVisiteur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLoginVisiteur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeVisiteur);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.Departement);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodePostal);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sup_Visiteur);
            this.Controls.Add(this.mdf_Visiteur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ajoutervisiteur);
            this.Controls.Add(this.dataGridVisiteur);
            this.Name = "ListedesVisiteurs";
            this.Text = "ListedesVisiteurs";
            this.Load += new System.EventHandler(this.ListedesVisiteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEmbauche;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.Label Departement;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sup_Visiteur;
        private System.Windows.Forms.Button mdf_Visiteur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ajoutervisiteur;
        private System.Windows.Forms.DateTimePicker dateTimeVisiteur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLoginVisiteur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxmdpVisiteur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}