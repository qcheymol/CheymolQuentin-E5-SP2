namespace GSB_Appli
{
    partial class Offrir
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
            this.ListBoxOffrir = new System.Windows.Forms.ListBox();
            this.sup_offrir = new System.Windows.Forms.Button();
            this.mdf_offrir = new System.Windows.Forms.Button();
            this.btn_offrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxOffrir
            // 
            this.ListBoxOffrir.FormattingEnabled = true;
            this.ListBoxOffrir.Location = new System.Drawing.Point(12, 12);
            this.ListBoxOffrir.Name = "ListBoxOffrir";
            this.ListBoxOffrir.Size = new System.Drawing.Size(407, 251);
            this.ListBoxOffrir.TabIndex = 18;
            this.ListBoxOffrir.SelectedIndexChanged += new System.EventHandler(this.ListBoxOffrir_SelectedIndexChanged);
            // 
            // sup_offrir
            // 
            this.sup_offrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sup_offrir.Location = new System.Drawing.Point(262, 512);
            this.sup_offrir.Name = "sup_offrir";
            this.sup_offrir.Size = new System.Drawing.Size(98, 46);
            this.sup_offrir.TabIndex = 24;
            this.sup_offrir.Text = "Supprimer";
            this.sup_offrir.UseVisualStyleBackColor = true;
            // 
            // mdf_offrir
            // 
            this.mdf_offrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdf_offrir.Location = new System.Drawing.Point(159, 512);
            this.mdf_offrir.Name = "mdf_offrir";
            this.mdf_offrir.Size = new System.Drawing.Size(97, 46);
            this.mdf_offrir.TabIndex = 23;
            this.mdf_offrir.Text = "Modifier";
            this.mdf_offrir.UseVisualStyleBackColor = true;
            // 
            // btn_offrir
            // 
            this.btn_offrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_offrir.Location = new System.Drawing.Point(63, 512);
            this.btn_offrir.Name = "btn_offrir";
            this.btn_offrir.Size = new System.Drawing.Size(90, 46);
            this.btn_offrir.TabIndex = 22;
            this.btn_offrir.Text = "Ajouter";
            this.btn_offrir.UseVisualStyleBackColor = true;
            // 
            // Offrir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 600);
            this.Controls.Add(this.sup_offrir);
            this.Controls.Add(this.mdf_offrir);
            this.Controls.Add(this.btn_offrir);
            this.Controls.Add(this.ListBoxOffrir);
            this.Name = "Offrir";
            this.Text = "Offrir";
            this.Load += new System.EventHandler(this.Offrir_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxOffrir;
        private System.Windows.Forms.Button sup_offrir;
        private System.Windows.Forms.Button mdf_offrir;
        private System.Windows.Forms.Button btn_offrir;
    }
}