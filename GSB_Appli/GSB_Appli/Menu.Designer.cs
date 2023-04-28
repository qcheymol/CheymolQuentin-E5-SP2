namespace GSB_Appli
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitterMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesMédicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsOffertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesMédecinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesRapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.toolStripMenuItem1,
            this.visiteurToolStripMenuItem,
            this.médecinToolStripMenuItem,
            this.rapportToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuitterMenu});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // QuitterMenu
            // 
            this.QuitterMenu.Name = "QuitterMenu";
            this.QuitterMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.QuitterMenu.Size = new System.Drawing.Size(154, 22);
            this.QuitterMenu.Text = "Quitter";
            this.QuitterMenu.Click += new System.EventHandler(this.QuitterMenu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesMédicamentsToolStripMenuItem,
            this.médicamentsOffertToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem1.Text = " Médicaments";
            // 
            // listeDesMédicamentsToolStripMenuItem
            // 
            this.listeDesMédicamentsToolStripMenuItem.Name = "listeDesMédicamentsToolStripMenuItem";
            this.listeDesMédicamentsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.listeDesMédicamentsToolStripMenuItem.Text = "Liste des médicaments";
            this.listeDesMédicamentsToolStripMenuItem.Click += new System.EventHandler(this.listeDesMédicamentsToolStripMenuItem_Click_1);
            // 
            // médicamentsOffertToolStripMenuItem
            // 
            this.médicamentsOffertToolStripMenuItem.Name = "médicamentsOffertToolStripMenuItem";
            this.médicamentsOffertToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.médicamentsOffertToolStripMenuItem.Text = "Liste médicaments offert";
            // 
            // visiteurToolStripMenuItem
            // 
            this.visiteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesVisiteursToolStripMenuItem});
            this.visiteurToolStripMenuItem.Name = "visiteurToolStripMenuItem";
            this.visiteurToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.visiteurToolStripMenuItem.Text = "Visiteur";
            // 
            // listeDesVisiteursToolStripMenuItem
            // 
            this.listeDesVisiteursToolStripMenuItem.Name = "listeDesVisiteursToolStripMenuItem";
            this.listeDesVisiteursToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.listeDesVisiteursToolStripMenuItem.Text = "Liste des visiteurs";
            this.listeDesVisiteursToolStripMenuItem.Click += new System.EventHandler(this.listeDesVisiteursToolStripMenuItem_Click);
            // 
            // médecinToolStripMenuItem
            // 
            this.médecinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesMédecinsToolStripMenuItem});
            this.médecinToolStripMenuItem.Name = "médecinToolStripMenuItem";
            this.médecinToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.médecinToolStripMenuItem.Text = "Médecin";
            // 
            // listeDesMédecinsToolStripMenuItem
            // 
            this.listeDesMédecinsToolStripMenuItem.Name = "listeDesMédecinsToolStripMenuItem";
            this.listeDesMédecinsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.listeDesMédecinsToolStripMenuItem.Text = "Liste des médecins";
            this.listeDesMédecinsToolStripMenuItem.Click += new System.EventHandler(this.listeDesMédecinsToolStripMenuItem_Click);
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesRapportsToolStripMenuItem});
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.rapportToolStripMenuItem.Text = "Rapport";
            // 
            // listeDesRapportsToolStripMenuItem
            // 
            this.listeDesRapportsToolStripMenuItem.Name = "listeDesRapportsToolStripMenuItem";
            this.listeDesRapportsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeDesRapportsToolStripMenuItem.Text = "Liste des rapports";
            this.listeDesRapportsToolStripMenuItem.Click += new System.EventHandler(this.listeDesRapportsToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuitterMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesMédicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentsOffertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesVisiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesMédecinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesRapportsToolStripMenuItem;
    }
}

