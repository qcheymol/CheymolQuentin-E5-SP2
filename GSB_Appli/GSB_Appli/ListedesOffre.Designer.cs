namespace GSB_Appli
{
    partial class ListedesOffre
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
            this.sup_offrir = new System.Windows.Forms.Button();
            this.mdf_offrir = new System.Windows.Forms.Button();
            this.btn_offrir = new System.Windows.Forms.Button();
            this.dataGridViewOffrir = new System.Windows.Forms.DataGridView();
            this.comboBoxMedicament = new System.Windows.Forms.ComboBox();
            this.comboBoxRapport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffrir)).BeginInit();
            this.SuspendLayout();
            // 
            // sup_offrir
            // 
            this.sup_offrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sup_offrir.Location = new System.Drawing.Point(270, 424);
            this.sup_offrir.Name = "sup_offrir";
            this.sup_offrir.Size = new System.Drawing.Size(98, 46);
            this.sup_offrir.TabIndex = 24;
            this.sup_offrir.Text = "Supprimer";
            this.sup_offrir.UseVisualStyleBackColor = true;
            this.sup_offrir.Click += new System.EventHandler(this.sup_offrir_Click);
            // 
            // mdf_offrir
            // 
            this.mdf_offrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdf_offrir.Location = new System.Drawing.Point(167, 424);
            this.mdf_offrir.Name = "mdf_offrir";
            this.mdf_offrir.Size = new System.Drawing.Size(97, 46);
            this.mdf_offrir.TabIndex = 23;
            this.mdf_offrir.Text = "Modifier";
            this.mdf_offrir.UseVisualStyleBackColor = true;
            this.mdf_offrir.Click += new System.EventHandler(this.mdf_offrir_Click);
            // 
            // btn_offrir
            // 
            this.btn_offrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_offrir.Location = new System.Drawing.Point(71, 424);
            this.btn_offrir.Name = "btn_offrir";
            this.btn_offrir.Size = new System.Drawing.Size(90, 46);
            this.btn_offrir.TabIndex = 22;
            this.btn_offrir.Text = "Ajouter";
            this.btn_offrir.UseVisualStyleBackColor = true;
            this.btn_offrir.Click += new System.EventHandler(this.btn_offrir_Click);
            // 
            // dataGridViewOffrir
            // 
            this.dataGridViewOffrir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffrir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Medicament,
            this.Rapport,
            this.Quantite});
            this.dataGridViewOffrir.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOffrir.Name = "dataGridViewOffrir";
            this.dataGridViewOffrir.Size = new System.Drawing.Size(451, 322);
            this.dataGridViewOffrir.TabIndex = 25;
            this.dataGridViewOffrir.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOffrir_CellContentClick);
            // 
            // comboBoxMedicament
            // 
            this.comboBoxMedicament.FormattingEnabled = true;
            this.comboBoxMedicament.Location = new System.Drawing.Point(12, 382);
            this.comboBoxMedicament.Name = "comboBoxMedicament";
            this.comboBoxMedicament.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMedicament.TabIndex = 26;
            // 
            // comboBoxRapport
            // 
            this.comboBoxRapport.FormattingEnabled = true;
            this.comboBoxRapport.Location = new System.Drawing.Point(154, 382);
            this.comboBoxRapport.Name = "comboBoxRapport";
            this.comboBoxRapport.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRapport.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Medicament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Rapport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Quantite";
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Location = new System.Drawing.Point(308, 383);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantite.TabIndex = 31;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Medicament
            // 
            this.Medicament.HeaderText = "Medicament";
            this.Medicament.Name = "Medicament";
            // 
            // Rapport
            // 
            this.Rapport.HeaderText = "Rapport";
            this.Rapport.Name = "Rapport";
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantite";
            this.Quantite.Name = "Quantite";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(388, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Effacer";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Offrir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 496);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textBoxQuantite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRapport);
            this.Controls.Add(this.comboBoxMedicament);
            this.Controls.Add(this.dataGridViewOffrir);
            this.Controls.Add(this.sup_offrir);
            this.Controls.Add(this.mdf_offrir);
            this.Controls.Add(this.btn_offrir);
            this.Name = "Offrir";
            this.Text = "Offrir";
            this.Load += new System.EventHandler(this.Offrir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffrir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sup_offrir;
        private System.Windows.Forms.Button mdf_offrir;
        private System.Windows.Forms.Button btn_offrir;
        private System.Windows.Forms.DataGridView dataGridViewOffrir;
        private System.Windows.Forms.ComboBox comboBoxMedicament;
        private System.Windows.Forms.ComboBox comboBoxRapport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.Button btnClear;
    }
}