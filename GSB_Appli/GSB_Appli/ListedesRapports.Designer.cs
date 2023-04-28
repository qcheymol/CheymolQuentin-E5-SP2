namespace GSB_Appli
{
    partial class ListedesRapports
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
            this.comboBox_Visiteur = new System.Windows.Forms.ComboBox();
            this.comboBox_Medecin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridRapport = new System.Windows.Forms.DataGridView();
            this.IdRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bilan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMotif = new System.Windows.Forms.TextBox();
            this.textBoxBilan = new System.Windows.Forms.TextBox();
            this.sup_Rapport = new System.Windows.Forms.Button();
            this.mdf_Rapport = new System.Windows.Forms.Button();
            this.btn_ajouterRapport = new System.Windows.Forms.Button();
            this.dateTimeDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Visiteur
            // 
            this.comboBox_Visiteur.FormattingEnabled = true;
            this.comboBox_Visiteur.Location = new System.Drawing.Point(1074, 65);
            this.comboBox_Visiteur.Name = "comboBox_Visiteur";
            this.comboBox_Visiteur.Size = new System.Drawing.Size(153, 21);
            this.comboBox_Visiteur.TabIndex = 1;
            // 
            // comboBox_Medecin
            // 
            this.comboBox_Medecin.FormattingEnabled = true;
            this.comboBox_Medecin.Location = new System.Drawing.Point(819, 65);
            this.comboBox_Medecin.Name = "comboBox_Medecin";
            this.comboBox_Medecin.Size = new System.Drawing.Size(170, 21);
            this.comboBox_Medecin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(816, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sélectionner un médecin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1071, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sélectionner un visiteur";
            // 
            // dataGridRapport
            // 
            this.dataGridRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRapport,
            this.Date,
            this.Motif,
            this.Bilan,
            this.Visiteur,
            this.Medecin});
            this.dataGridRapport.Location = new System.Drawing.Point(9, 12);
            this.dataGridRapport.Name = "dataGridRapport";
            this.dataGridRapport.Size = new System.Drawing.Size(792, 625);
            this.dataGridRapport.TabIndex = 5;
            this.dataGridRapport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRapport_CellDoubleClick_1);
            // 
            // IdRapport
            // 
            this.IdRapport.HeaderText = "IdRapport";
            this.IdRapport.Name = "IdRapport";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // Motif
            // 
            this.Motif.HeaderText = "Motif";
            this.Motif.Name = "Motif";
            this.Motif.Width = 150;
            // 
            // Bilan
            // 
            this.Bilan.HeaderText = "Bilan";
            this.Bilan.Name = "Bilan";
            this.Bilan.Width = 150;
            // 
            // Visiteur
            // 
            this.Visiteur.HeaderText = "Visiteur";
            this.Visiteur.Name = "Visiteur";
            this.Visiteur.Width = 150;
            // 
            // Medecin
            // 
            this.Medecin.HeaderText = "Médecin";
            this.Medecin.Name = "Medecin";
            this.Medecin.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(816, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Motif";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(816, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bilan";
            // 
            // textBoxMotif
            // 
            this.textBoxMotif.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxMotif.Location = new System.Drawing.Point(819, 204);
            this.textBoxMotif.Multiline = true;
            this.textBoxMotif.Name = "textBoxMotif";
            this.textBoxMotif.Size = new System.Drawing.Size(408, 107);
            this.textBoxMotif.TabIndex = 10;
            // 
            // textBoxBilan
            // 
            this.textBoxBilan.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxBilan.Location = new System.Drawing.Point(819, 330);
            this.textBoxBilan.Multiline = true;
            this.textBoxBilan.Name = "textBoxBilan";
            this.textBoxBilan.Size = new System.Drawing.Size(408, 104);
            this.textBoxBilan.TabIndex = 11;
            // 
            // sup_Rapport
            // 
            this.sup_Rapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sup_Rapport.Location = new System.Drawing.Point(1110, 510);
            this.sup_Rapport.Name = "sup_Rapport";
            this.sup_Rapport.Size = new System.Drawing.Size(117, 43);
            this.sup_Rapport.TabIndex = 14;
            this.sup_Rapport.Text = "Supprimer";
            this.sup_Rapport.UseVisualStyleBackColor = true;
            this.sup_Rapport.Click += new System.EventHandler(this.sup_Rapport_Click);
            // 
            // mdf_Rapport
            // 
            this.mdf_Rapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdf_Rapport.Location = new System.Drawing.Point(958, 510);
            this.mdf_Rapport.Name = "mdf_Rapport";
            this.mdf_Rapport.Size = new System.Drawing.Size(116, 43);
            this.mdf_Rapport.TabIndex = 13;
            this.mdf_Rapport.Text = "Modifier";
            this.mdf_Rapport.UseVisualStyleBackColor = true;
            this.mdf_Rapport.Click += new System.EventHandler(this.mdf_Rapport_Click);
            // 
            // btn_ajouterRapport
            // 
            this.btn_ajouterRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterRapport.Location = new System.Drawing.Point(813, 510);
            this.btn_ajouterRapport.Name = "btn_ajouterRapport";
            this.btn_ajouterRapport.Size = new System.Drawing.Size(109, 43);
            this.btn_ajouterRapport.TabIndex = 12;
            this.btn_ajouterRapport.Text = "Ajouter";
            this.btn_ajouterRapport.UseVisualStyleBackColor = true;
            this.btn_ajouterRapport.Click += new System.EventHandler(this.btn_ajouterRapport_Click);
            // 
            // dateTimeDate
            // 
            this.dateTimeDate.Location = new System.Drawing.Point(937, 130);
            this.dateTimeDate.Name = "dateTimeDate";
            this.dateTimeDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDate.TabIndex = 15;
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(978, 589);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(70, 31);
            this.textBoxId.TabIndex = 26;
            this.textBoxId.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(978, 457);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Effacer";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ListedesRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 649);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.dateTimeDate);
            this.Controls.Add(this.sup_Rapport);
            this.Controls.Add(this.mdf_Rapport);
            this.Controls.Add(this.btn_ajouterRapport);
            this.Controls.Add(this.textBoxBilan);
            this.Controls.Add(this.textBoxMotif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridRapport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Medecin);
            this.Controls.Add(this.comboBox_Visiteur);
            this.Name = "ListedesRapports";
            this.Text = "Rapport";
            this.Load += new System.EventHandler(this.ListedesRapports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_Visiteur;
        private System.Windows.Forms.ComboBox comboBox_Medecin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridRapport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMotif;
        private System.Windows.Forms.TextBox textBoxBilan;
        private System.Windows.Forms.Button sup_Rapport;
        private System.Windows.Forms.Button mdf_Rapport;
        private System.Windows.Forms.Button btn_ajouterRapport;
        private System.Windows.Forms.DateTimePicker dateTimeDate;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bilan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medecin;
        private System.Windows.Forms.Button btnClear;
    }
}