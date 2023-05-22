
namespace GSB_Appli
{
    partial class AjouterRapport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btEffacer = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.txtIdRapport = new System.Windows.Forms.TextBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.dtDateRapport = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelMed = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.med1 = new System.Windows.Forms.Panel();
            this.nudQte = new System.Windows.Forms.NumericUpDown();
            this.cbMedicament = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAjoutMed = new System.Windows.Forms.Button();
            this.dgvMedicament = new System.Windows.Forms.DataGridView();
            this.nomMedic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cbVisiteur = new System.Windows.Forms.ComboBox();
            this.cbMedecin = new System.Windows.Forms.ComboBox();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMed.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.med1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // btEffacer
            // 
            this.btEffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEffacer.Location = new System.Drawing.Point(71, 209);
            this.btEffacer.Name = "btEffacer";
            this.btEffacer.Size = new System.Drawing.Size(102, 39);
            this.btEffacer.TabIndex = 126;
            this.btEffacer.Text = "Effacer";
            this.btEffacer.UseVisualStyleBackColor = true;
            this.btEffacer.Click += new System.EventHandler(this.btEffacer_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(693, 209);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(104, 39);
            this.btQuitter.TabIndex = 125;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // txtIdRapport
            // 
            this.txtIdRapport.Location = new System.Drawing.Point(729, 11);
            this.txtIdRapport.Name = "txtIdRapport";
            this.txtIdRapport.Size = new System.Drawing.Size(67, 20);
            this.txtIdRapport.TabIndex = 124;
            this.txtIdRapport.Visible = false;
            // 
            // txtMotif
            // 
            this.txtMotif.BackColor = System.Drawing.SystemColors.Control;
            this.txtMotif.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtMotif.Location = new System.Drawing.Point(180, 135);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(228, 25);
            this.txtMotif.TabIndex = 123;
            // 
            // dtDateRapport
            // 
            this.dtDateRapport.Location = new System.Drawing.Point(171, 95);
            this.dtDateRapport.Name = "dtDateRapport";
            this.dtDateRapport.Size = new System.Drawing.Size(219, 20);
            this.dtDateRapport.TabIndex = 122;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(494, 260);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 17);
            this.label14.TabIndex = 121;
            this.label14.Text = "Cette option est facultative.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(73, 260);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(416, 17);
            this.label11.TabIndex = 119;
            this.label11.Text = "Vous devez d\'abord créer le compte-rendu avant d\'y lier des échantillons.";
            // 
            // panelMed
            // 
            this.panelMed.Controls.Add(this.groupBox1);
            this.panelMed.Controls.Add(this.dgvMedicament);
            this.panelMed.Controls.Add(this.label7);
            this.panelMed.Location = new System.Drawing.Point(74, 280);
            this.panelMed.Margin = new System.Windows.Forms.Padding(2);
            this.panelMed.Name = "panelMed";
            this.panelMed.Size = new System.Drawing.Size(696, 206);
            this.panelMed.TabIndex = 120;
            this.panelMed.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.med1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btAjoutMed);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(452, 180);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Echantillons de médicaments";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 58);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(364, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Pour supprimer un échantillon, il faut double-cliquer sur celui-ci.";
            // 
            // med1
            // 
            this.med1.Controls.Add(this.nudQte);
            this.med1.Controls.Add(this.cbMedicament);
            this.med1.Controls.Add(this.label12);
            this.med1.Controls.Add(this.label13);
            this.med1.Location = new System.Drawing.Point(0, 87);
            this.med1.Margin = new System.Windows.Forms.Padding(2);
            this.med1.Name = "med1";
            this.med1.Size = new System.Drawing.Size(449, 32);
            this.med1.TabIndex = 38;
            // 
            // nudQte
            // 
            this.nudQte.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.nudQte.Location = new System.Drawing.Point(359, 4);
            this.nudQte.Name = "nudQte";
            this.nudQte.Size = new System.Drawing.Size(54, 25);
            this.nudQte.TabIndex = 39;
            this.nudQte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbMedicament
            // 
            this.cbMedicament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedicament.FormattingEnabled = true;
            this.cbMedicament.Location = new System.Drawing.Point(134, 7);
            this.cbMedicament.Margin = new System.Windows.Forms.Padding(2);
            this.cbMedicament.Name = "cbMedicament";
            this.cbMedicament.Size = new System.Drawing.Size(160, 21);
            this.cbMedicament.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Nom du médicament";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(310, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Quantité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Pour ce faire, il faut cliquer à nouveau sur \"Ajouter un échantillon\".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Information : Vous pouvez en ajouter plusieurs. ";
            // 
            // btAjoutMed
            // 
            this.btAjoutMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjoutMed.Location = new System.Drawing.Point(134, 143);
            this.btAjoutMed.Name = "btAjoutMed";
            this.btAjoutMed.Size = new System.Drawing.Size(190, 27);
            this.btAjoutMed.TabIndex = 35;
            this.btAjoutMed.Text = "Ajouter un échantillon";
            this.btAjoutMed.UseVisualStyleBackColor = true;
            this.btAjoutMed.Click += new System.EventHandler(this.btAjoutMed_Click);
            // 
            // dgvMedicament
            // 
            this.dgvMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomMedic,
            this.nombre});
            this.dgvMedicament.Location = new System.Drawing.Point(464, 17);
            this.dgvMedicament.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMedicament.Name = "dgvMedicament";
            this.dgvMedicament.RowTemplate.Height = 24;
            this.dgvMedicament.Size = new System.Drawing.Size(230, 165);
            this.dgvMedicament.TabIndex = 35;
            this.dgvMedicament.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicament_CellContentClick);
            // 
            // nomMedic
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nomMedic.DefaultCellStyle = dataGridViewCellStyle1;
            this.nomMedic.HeaderText = "Nom du médicament";
            this.nomMedic.Name = "nomMedic";
            this.nomMedic.ReadOnly = true;
            // 
            // nombre
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombre.HeaderText = "Quantité offerte";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(472, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Visualisation des échantillons";
            // 
            // cbVisiteur
            // 
            this.cbVisiteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisiteur.FormattingEnabled = true;
            this.cbVisiteur.Location = new System.Drawing.Point(559, 57);
            this.cbVisiteur.Margin = new System.Windows.Forms.Padding(2);
            this.cbVisiteur.Name = "cbVisiteur";
            this.cbVisiteur.Size = new System.Drawing.Size(238, 21);
            this.cbVisiteur.TabIndex = 111;
            // 
            // cbMedecin
            // 
            this.cbMedecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedecin.FormattingEnabled = true;
            this.cbMedecin.Location = new System.Drawing.Point(162, 58);
            this.cbMedecin.Margin = new System.Windows.Forms.Padding(2);
            this.cbMedecin.Name = "cbMedecin";
            this.cbMedecin.Size = new System.Drawing.Size(274, 21);
            this.cbMedecin.TabIndex = 110;
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnregistrer.Location = new System.Drawing.Point(251, 209);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(304, 39);
            this.btEnregistrer.TabIndex = 118;
            this.btEnregistrer.Text = "Enregistrer le nouveau compte-rendu";
            this.btEnregistrer.UseVisualStyleBackColor = true;
            this.btEnregistrer.Click += new System.EventHandler(this.btEnregistrer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 117;
            this.label9.Text = "Motif de la visite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(417, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 116;
            this.label8.Text = "Bilan";
            // 
            // txtBilan
            // 
            this.txtBilan.BackColor = System.Drawing.SystemColors.Control;
            this.txtBilan.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtBilan.Location = new System.Drawing.Point(462, 96);
            this.txtBilan.Margin = new System.Windows.Forms.Padding(2);
            this.txtBilan.MaxLength = 255;
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(335, 99);
            this.txtBilan.TabIndex = 112;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 115;
            this.label6.Text = "Date de visite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(459, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 114;
            this.label5.Text = "Nom du visiteur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 113;
            this.label4.Text = "Praticien visité";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 23);
            this.label1.TabIndex = 109;
            this.label1.Text = "Ajout d\'un nouveau rapport ";
            // 
            // AjouterRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 496);
            this.Controls.Add(this.btEffacer);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.txtIdRapport);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.dtDateRapport);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panelMed);
            this.Controls.Add(this.cbVisiteur);
            this.Controls.Add(this.cbMedecin);
            this.Controls.Add(this.btEnregistrer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "AjouterRapport";
            this.Text = "AjouterRapport";
            this.Load += new System.EventHandler(this.AjouterRapport_Load);
            this.panelMed.ResumeLayout(false);
            this.panelMed.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.med1.ResumeLayout(false);
            this.med1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEffacer;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.TextBox txtIdRapport;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.DateTimePicker dtDateRapport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelMed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel med1;
        private System.Windows.Forms.NumericUpDown nudQte;
        private System.Windows.Forms.ComboBox cbMedicament;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAjoutMed;
        private System.Windows.Forms.DataGridView dgvMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMedic;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbVisiteur;
        private System.Windows.Forms.ComboBox cbMedecin;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}