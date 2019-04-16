namespace Compte_Bancaire.Vue
{
    partial class CompteVue
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
            this.dGVWCompte = new System.Windows.Forms.DataGridView();
            this.btnOperation = new System.Windows.Forms.Button();
            this.tbValeurs = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opérationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.débiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modéficationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.découvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOpération = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVWCompte)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVWCompte
            // 
            this.dGVWCompte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVWCompte.Location = new System.Drawing.Point(12, 85);
            this.dGVWCompte.Name = "dGVWCompte";
            this.dGVWCompte.Size = new System.Drawing.Size(711, 150);
            this.dGVWCompte.TabIndex = 0;
            this.dGVWCompte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVWCompte_CellContentClick);
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(585, 271);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(121, 23);
            this.btnOperation.TabIndex = 1;
            this.btnOperation.Text = "OPERATION";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // tbValeurs
            // 
            this.tbValeurs.Location = new System.Drawing.Point(293, 274);
            this.tbValeurs.Name = "tbValeurs";
            this.tbValeurs.Size = new System.Drawing.Size(144, 20);
            this.tbValeurs.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opérationToolStripMenuItem,
            this.modéficationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opérationToolStripMenuItem
            // 
            this.opérationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créditerToolStripMenuItem,
            this.débiterToolStripMenuItem});
            this.opérationToolStripMenuItem.Name = "opérationToolStripMenuItem";
            this.opérationToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.opérationToolStripMenuItem.Text = "Opération";
            // 
            // créditerToolStripMenuItem
            // 
            this.créditerToolStripMenuItem.Name = "créditerToolStripMenuItem";
            this.créditerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.créditerToolStripMenuItem.Text = "Créditer";
            this.créditerToolStripMenuItem.Click += new System.EventHandler(this.créditerToolStripMenuItem_Click);
            // 
            // débiterToolStripMenuItem
            // 
            this.débiterToolStripMenuItem.Name = "débiterToolStripMenuItem";
            this.débiterToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.débiterToolStripMenuItem.Text = "Débiter";
            this.débiterToolStripMenuItem.Click += new System.EventHandler(this.débiterToolStripMenuItem_Click);
            // 
            // modéficationToolStripMenuItem
            // 
            this.modéficationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.découvertToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.modéficationToolStripMenuItem.Name = "modéficationToolStripMenuItem";
            this.modéficationToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.modéficationToolStripMenuItem.Text = "Modéfication";
            // 
            // découvertToolStripMenuItem
            // 
            this.découvertToolStripMenuItem.Name = "découvertToolStripMenuItem";
            this.découvertToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.découvertToolStripMenuItem.Text = "Découvert";
            this.découvertToolStripMenuItem.Click += new System.EventHandler(this.découvertToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // lblOpération
            // 
            this.lblOpération.AutoSize = true;
            this.lblOpération.Location = new System.Drawing.Point(112, 280);
            this.lblOpération.Name = "lblOpération";
            this.lblOpération.Size = new System.Drawing.Size(61, 13);
            this.lblOpération.TabIndex = 4;
            this.lblOpération.Text = "Montant à :";
            // 
            // CompteVue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 306);
            this.Controls.Add(this.lblOpération);
            this.Controls.Add(this.tbValeurs);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.dGVWCompte);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CompteVue";
            this.Text = "CompteVue";
            this.Load += new System.EventHandler(this.CompteVue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVWCompte)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVWCompte;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.TextBox tbValeurs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opérationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem débiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modéficationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem découvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.Label lblOpération;
    }
}