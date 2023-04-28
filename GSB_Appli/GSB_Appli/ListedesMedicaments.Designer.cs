namespace GSB_Appli
{
    partial class ListedesMedicaments
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
            this.labelmedicament = new System.Windows.Forms.Label();
            this.ListBoxMedicament = new System.Windows.Forms.ListBox();
            this.GroupBoxMedicament = new System.Windows.Forms.GroupBox();
            this.ComboBoxfamille = new System.Windows.Forms.ComboBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNomCo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContre = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.lblEffet = new System.Windows.Forms.Label();
            this.textBoxEffet = new System.Windows.Forms.TextBox();
            this.textBoxCompo = new System.Windows.Forms.TextBox();
            this.textBoxContreIndic = new System.Windows.Forms.TextBox();
            this.sup_medicament = new System.Windows.Forms.Button();
            this.mdf_Medicament = new System.Windows.Forms.Button();
            this.btn_ajoutermedicament = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBoxPrixunitaire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBoxMedicament.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelmedicament
            // 
            this.labelmedicament.AutoSize = true;
            this.labelmedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmedicament.Location = new System.Drawing.Point(174, 9);
            this.labelmedicament.Name = "labelmedicament";
            this.labelmedicament.Size = new System.Drawing.Size(202, 24);
            this.labelmedicament.TabIndex = 18;
            this.labelmedicament.Text = "Liste des médicaments";
            // 
            // ListBoxMedicament
            // 
            this.ListBoxMedicament.FormattingEnabled = true;
            this.ListBoxMedicament.Location = new System.Drawing.Point(12, 59);
            this.ListBoxMedicament.Name = "ListBoxMedicament";
            this.ListBoxMedicament.Size = new System.Drawing.Size(541, 251);
            this.ListBoxMedicament.TabIndex = 17;
            this.ListBoxMedicament.SelectedIndexChanged += new System.EventHandler(this.ListBoxMedicament_SelectedIndexChanged);
            this.ListBoxMedicament.DoubleClick += new System.EventHandler(this.ListBoxMedicament_SelectedIndexChanged);
            // 
            // GroupBoxMedicament
            // 
            this.GroupBoxMedicament.Controls.Add(this.label3);
            this.GroupBoxMedicament.Controls.Add(this.textBoxPrixunitaire);
            this.GroupBoxMedicament.Controls.Add(this.btnClear);
            this.GroupBoxMedicament.Controls.Add(this.ComboBoxfamille);
            this.GroupBoxMedicament.Controls.Add(this.textBoxId);
            this.GroupBoxMedicament.Controls.Add(this.textBoxNomCo);
            this.GroupBoxMedicament.Controls.Add(this.label2);
            this.GroupBoxMedicament.Controls.Add(this.label1);
            this.GroupBoxMedicament.Controls.Add(this.lblContre);
            this.GroupBoxMedicament.Controls.Add(this.lblComp);
            this.GroupBoxMedicament.Controls.Add(this.lblEffet);
            this.GroupBoxMedicament.Controls.Add(this.textBoxEffet);
            this.GroupBoxMedicament.Controls.Add(this.textBoxCompo);
            this.GroupBoxMedicament.Controls.Add(this.textBoxContreIndic);
            this.GroupBoxMedicament.Location = new System.Drawing.Point(12, 316);
            this.GroupBoxMedicament.Name = "GroupBoxMedicament";
            this.GroupBoxMedicament.Size = new System.Drawing.Size(541, 338);
            this.GroupBoxMedicament.TabIndex = 16;
            this.GroupBoxMedicament.TabStop = false;
            this.GroupBoxMedicament.Enter += new System.EventHandler(this.GroupBoxMedicament_Enter);
            // 
            // ComboBoxfamille
            // 
            this.ComboBoxfamille.FormattingEnabled = true;
            this.ComboBoxfamille.Location = new System.Drawing.Point(339, 274);
            this.ComboBoxfamille.Name = "ComboBoxfamille";
            this.ComboBoxfamille.Size = new System.Drawing.Size(170, 21);
            this.ComboBoxfamille.TabIndex = 12;
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxId.Location = new System.Drawing.Point(466, 304);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(73, 34);
            this.textBoxId.TabIndex = 11;
            this.textBoxId.Visible = false;
            // 
            // textBoxNomCo
            // 
            this.textBoxNomCo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxNomCo.Location = new System.Drawing.Point(9, 152);
            this.textBoxNomCo.Multiline = true;
            this.textBoxNomCo.Name = "textBoxNomCo";
            this.textBoxNomCo.Size = new System.Drawing.Size(214, 34);
            this.textBoxNomCo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom Commercial :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Famille :";
            // 
            // lblContre
            // 
            this.lblContre.AutoSize = true;
            this.lblContre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContre.Location = new System.Drawing.Point(251, 118);
            this.lblContre.Name = "lblContre";
            this.lblContre.Size = new System.Drawing.Size(113, 16);
            this.lblContre.TabIndex = 5;
            this.lblContre.Text = "Contre Indication :";
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComp.Location = new System.Drawing.Point(6, 198);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(89, 16);
            this.lblComp.TabIndex = 4;
            this.lblComp.Text = "Composition :";
            // 
            // lblEffet
            // 
            this.lblEffet.AutoSize = true;
            this.lblEffet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffet.Location = new System.Drawing.Point(6, 16);
            this.lblEffet.Name = "lblEffet";
            this.lblEffet.Size = new System.Drawing.Size(40, 16);
            this.lblEffet.TabIndex = 3;
            this.lblEffet.Text = "Effet :";
            // 
            // textBoxEffet
            // 
            this.textBoxEffet.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxEffet.Location = new System.Drawing.Point(6, 39);
            this.textBoxEffet.Multiline = true;
            this.textBoxEffet.Name = "textBoxEffet";
            this.textBoxEffet.Size = new System.Drawing.Size(358, 76);
            this.textBoxEffet.TabIndex = 0;
            // 
            // textBoxCompo
            // 
            this.textBoxCompo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxCompo.Location = new System.Drawing.Point(9, 228);
            this.textBoxCompo.Multiline = true;
            this.textBoxCompo.Name = "textBoxCompo";
            this.textBoxCompo.Size = new System.Drawing.Size(230, 104);
            this.textBoxCompo.TabIndex = 2;
            // 
            // textBoxContreIndic
            // 
            this.textBoxContreIndic.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxContreIndic.Location = new System.Drawing.Point(245, 152);
            this.textBoxContreIndic.Multiline = true;
            this.textBoxContreIndic.Name = "textBoxContreIndic";
            this.textBoxContreIndic.Size = new System.Drawing.Size(281, 85);
            this.textBoxContreIndic.TabIndex = 1;
            // 
            // sup_medicament
            // 
            this.sup_medicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sup_medicament.Location = new System.Drawing.Point(339, 675);
            this.sup_medicament.Name = "sup_medicament";
            this.sup_medicament.Size = new System.Drawing.Size(147, 60);
            this.sup_medicament.TabIndex = 21;
            this.sup_medicament.Text = "Supprimer";
            this.sup_medicament.UseVisualStyleBackColor = true;
            this.sup_medicament.Click += new System.EventHandler(this.sup_medicament_Click);
            // 
            // mdf_Medicament
            // 
            this.mdf_Medicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdf_Medicament.Location = new System.Drawing.Point(187, 675);
            this.mdf_Medicament.Name = "mdf_Medicament";
            this.mdf_Medicament.Size = new System.Drawing.Size(146, 60);
            this.mdf_Medicament.TabIndex = 20;
            this.mdf_Medicament.Text = "Modifier";
            this.mdf_Medicament.UseVisualStyleBackColor = true;
            this.mdf_Medicament.Click += new System.EventHandler(this.mdf_Medicament_Click);
            // 
            // btn_ajoutermedicament
            // 
            this.btn_ajoutermedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutermedicament.Location = new System.Drawing.Point(42, 675);
            this.btn_ajoutermedicament.Name = "btn_ajoutermedicament";
            this.btn_ajoutermedicament.Size = new System.Drawing.Size(139, 60);
            this.btn_ajoutermedicament.TabIndex = 19;
            this.btn_ajoutermedicament.Text = "Ajouter";
            this.btn_ajoutermedicament.UseVisualStyleBackColor = true;
            this.btn_ajoutermedicament.Click += new System.EventHandler(this.btn_ajoutermedicament_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(367, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Effacer";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBoxPrixunitaire
            // 
            this.textBoxPrixunitaire.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxPrixunitaire.Location = new System.Drawing.Point(404, 74);
            this.textBoxPrixunitaire.Multiline = true;
            this.textBoxPrixunitaire.Name = "textBoxPrixunitaire";
            this.textBoxPrixunitaire.Size = new System.Drawing.Size(83, 41);
            this.textBoxPrixunitaire.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Prix unitaire :";
            // 
            // ListedesMedicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 762);
            this.Controls.Add(this.sup_medicament);
            this.Controls.Add(this.mdf_Medicament);
            this.Controls.Add(this.btn_ajoutermedicament);
            this.Controls.Add(this.labelmedicament);
            this.Controls.Add(this.ListBoxMedicament);
            this.Controls.Add(this.GroupBoxMedicament);
            this.Name = "ListedesMedicaments";
            this.Text = "ListedesMedicaments";
            this.Load += new System.EventHandler(this.ListedesMedicaments_Load);
            this.GroupBoxMedicament.ResumeLayout(false);
            this.GroupBoxMedicament.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmedicament;
        private System.Windows.Forms.ListBox ListBoxMedicament;
        private System.Windows.Forms.GroupBox GroupBoxMedicament;
        private System.Windows.Forms.Label lblContre;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Label lblEffet;
        private System.Windows.Forms.TextBox textBoxEffet;
        private System.Windows.Forms.TextBox textBoxCompo;
        private System.Windows.Forms.TextBox textBoxContreIndic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomCo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sup_medicament;
        private System.Windows.Forms.Button mdf_Medicament;
        private System.Windows.Forms.Button btn_ajoutermedicament;
        private System.Windows.Forms.ComboBox ComboBoxfamille;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrixunitaire;
    }
}