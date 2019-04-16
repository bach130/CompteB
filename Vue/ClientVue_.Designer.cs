namespace Compte_Bancaire.Vue
{
    partial class ClientVue_
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
            this.btnVueClientModéfier = new System.Windows.Forms.Button();
            this.lblVueClient_Id = new System.Windows.Forms.Label();
            this.lblVueClient_NOM = new System.Windows.Forms.Label();
            this.lblVueClient_PRENOM = new System.Windows.Forms.Label();
            this.lblVueClient_Adresse = new System.Windows.Forms.Label();
            this.tbClientVue_ID = new System.Windows.Forms.TextBox();
            this.tbClientVue_Nom = new System.Windows.Forms.TextBox();
            this.tbClientVue_PRENOM = new System.Windows.Forms.TextBox();
            this.tbClientVue_ADRESSE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVueClientModéfier
            // 
            this.btnVueClientModéfier.Location = new System.Drawing.Point(169, 262);
            this.btnVueClientModéfier.Name = "btnVueClientModéfier";
            this.btnVueClientModéfier.Size = new System.Drawing.Size(149, 23);
            this.btnVueClientModéfier.TabIndex = 0;
            this.btnVueClientModéfier.Text = "Modéfier";
            this.btnVueClientModéfier.UseVisualStyleBackColor = true;
            this.btnVueClientModéfier.Click += new System.EventHandler(this.btnVueClientModéfier_Click);
            // 
            // lblVueClient_Id
            // 
            this.lblVueClient_Id.AutoSize = true;
            this.lblVueClient_Id.Location = new System.Drawing.Point(49, 36);
            this.lblVueClient_Id.Name = "lblVueClient_Id";
            this.lblVueClient_Id.Size = new System.Drawing.Size(45, 13);
            this.lblVueClient_Id.TabIndex = 1;
            this.lblVueClient_Id.Text = "NUMCL";
            // 
            // lblVueClient_NOM
            // 
            this.lblVueClient_NOM.AutoSize = true;
            this.lblVueClient_NOM.Location = new System.Drawing.Point(49, 81);
            this.lblVueClient_NOM.Name = "lblVueClient_NOM";
            this.lblVueClient_NOM.Size = new System.Drawing.Size(32, 13);
            this.lblVueClient_NOM.TabIndex = 2;
            this.lblVueClient_NOM.Text = "NOM";
            // 
            // lblVueClient_PRENOM
            // 
            this.lblVueClient_PRENOM.AutoSize = true;
            this.lblVueClient_PRENOM.Location = new System.Drawing.Point(49, 131);
            this.lblVueClient_PRENOM.Name = "lblVueClient_PRENOM";
            this.lblVueClient_PRENOM.Size = new System.Drawing.Size(54, 13);
            this.lblVueClient_PRENOM.TabIndex = 3;
            this.lblVueClient_PRENOM.Text = "PRENOM";
            // 
            // lblVueClient_Adresse
            // 
            this.lblVueClient_Adresse.AutoSize = true;
            this.lblVueClient_Adresse.Location = new System.Drawing.Point(49, 180);
            this.lblVueClient_Adresse.Name = "lblVueClient_Adresse";
            this.lblVueClient_Adresse.Size = new System.Drawing.Size(58, 13);
            this.lblVueClient_Adresse.TabIndex = 4;
            this.lblVueClient_Adresse.Text = "ADRESSE";
            // 
            // tbClientVue_ID
            // 
            this.tbClientVue_ID.Location = new System.Drawing.Point(169, 36);
            this.tbClientVue_ID.Name = "tbClientVue_ID";
            this.tbClientVue_ID.Size = new System.Drawing.Size(100, 20);
            this.tbClientVue_ID.TabIndex = 5;
            // 
            // tbClientVue_Nom
            // 
            this.tbClientVue_Nom.Location = new System.Drawing.Point(169, 78);
            this.tbClientVue_Nom.Name = "tbClientVue_Nom";
            this.tbClientVue_Nom.Size = new System.Drawing.Size(100, 20);
            this.tbClientVue_Nom.TabIndex = 6;
            // 
            // tbClientVue_PRENOM
            // 
            this.tbClientVue_PRENOM.Location = new System.Drawing.Point(169, 128);
            this.tbClientVue_PRENOM.Name = "tbClientVue_PRENOM";
            this.tbClientVue_PRENOM.Size = new System.Drawing.Size(100, 20);
            this.tbClientVue_PRENOM.TabIndex = 7;
            // 
            // tbClientVue_ADRESSE
            // 
            this.tbClientVue_ADRESSE.Location = new System.Drawing.Point(169, 164);
            this.tbClientVue_ADRESSE.Name = "tbClientVue_ADRESSE";
            this.tbClientVue_ADRESSE.Size = new System.Drawing.Size(100, 20);
            this.tbClientVue_ADRESSE.TabIndex = 8;
            // 
            // ClientVue_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 313);
            this.Controls.Add(this.tbClientVue_ADRESSE);
            this.Controls.Add(this.tbClientVue_PRENOM);
            this.Controls.Add(this.tbClientVue_Nom);
            this.Controls.Add(this.tbClientVue_ID);
            this.Controls.Add(this.lblVueClient_Adresse);
            this.Controls.Add(this.lblVueClient_PRENOM);
            this.Controls.Add(this.lblVueClient_NOM);
            this.Controls.Add(this.lblVueClient_Id);
            this.Controls.Add(this.btnVueClientModéfier);
            this.Name = "ClientVue_";
            this.Text = "ClientVue_";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVueClient_Id;
        private System.Windows.Forms.Label lblVueClient_NOM;
        private System.Windows.Forms.Label lblVueClient_PRENOM;
        private System.Windows.Forms.Label lblVueClient_Adresse;
        public System.Windows.Forms.TextBox tbClientVue_Nom;
        public System.Windows.Forms.Button btnVueClientModéfier;
        public System.Windows.Forms.TextBox tbClientVue_ID;
        public System.Windows.Forms.TextBox tbClientVue_PRENOM;
        public System.Windows.Forms.TextBox tbClientVue_ADRESSE;
    }
}