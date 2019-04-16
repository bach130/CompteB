namespace Compte_Bancaire.Vue
{
    partial class ClientVue
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
            this.dGVWClient = new System.Windows.Forms.DataGridView();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNOM = new System.Windows.Forms.TextBox();
            this.tbPRENOM = new System.Windows.Forms.TextBox();
            this.tbADRESSE = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lalNOM = new System.Windows.Forms.Label();
            this.lblPRENOM = new System.Windows.Forms.Label();
            this.lblADRESSE = new System.Windows.Forms.Label();
            this.btnAFFICHER = new System.Windows.Forms.Button();
            this.btnMODIFIER = new System.Windows.Forms.Button();
            this.btnSUPPRIMER = new System.Windows.Forms.Button();
            this.btnAJOUTER = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVWClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVWClient
            // 
            this.dGVWClient.AllowUserToAddRows = false;
            this.dGVWClient.AllowUserToDeleteRows = false;
            this.dGVWClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVWClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dGVWClient.Location = new System.Drawing.Point(144, 153);
            this.dGVWClient.Name = "dGVWClient";
            this.dGVWClient.ReadOnly = true;
            this.dGVWClient.Size = new System.Drawing.Size(446, 150);
            this.dGVWClient.TabIndex = 0;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(111, 13);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 1;
            // 
            // tbNOM
            // 
            this.tbNOM.Location = new System.Drawing.Point(111, 51);
            this.tbNOM.Name = "tbNOM";
            this.tbNOM.Size = new System.Drawing.Size(100, 20);
            this.tbNOM.TabIndex = 2;
            // 
            // tbPRENOM
            // 
            this.tbPRENOM.Location = new System.Drawing.Point(111, 89);
            this.tbPRENOM.Name = "tbPRENOM";
            this.tbPRENOM.Size = new System.Drawing.Size(100, 20);
            this.tbPRENOM.TabIndex = 3;
            // 
            // tbADRESSE
            // 
            this.tbADRESSE.Location = new System.Drawing.Point(111, 127);
            this.tbADRESSE.Name = "tbADRESSE";
            this.tbADRESSE.Size = new System.Drawing.Size(100, 20);
            this.tbADRESSE.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(39, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID";
            // 
            // lalNOM
            // 
            this.lalNOM.AutoSize = true;
            this.lalNOM.Location = new System.Drawing.Point(39, 58);
            this.lalNOM.Name = "lalNOM";
            this.lalNOM.Size = new System.Drawing.Size(32, 13);
            this.lalNOM.TabIndex = 6;
            this.lalNOM.Text = "NOM";
            // 
            // lblPRENOM
            // 
            this.lblPRENOM.AutoSize = true;
            this.lblPRENOM.Location = new System.Drawing.Point(39, 96);
            this.lblPRENOM.Name = "lblPRENOM";
            this.lblPRENOM.Size = new System.Drawing.Size(54, 13);
            this.lblPRENOM.TabIndex = 7;
            this.lblPRENOM.Text = "PRENOM";
            // 
            // lblADRESSE
            // 
            this.lblADRESSE.AutoSize = true;
            this.lblADRESSE.Location = new System.Drawing.Point(39, 134);
            this.lblADRESSE.Name = "lblADRESSE";
            this.lblADRESSE.Size = new System.Drawing.Size(58, 13);
            this.lblADRESSE.TabIndex = 8;
            this.lblADRESSE.Text = "ADRESSE";
            // 
            // btnAFFICHER
            // 
            this.btnAFFICHER.Location = new System.Drawing.Point(655, 154);
            this.btnAFFICHER.Name = "btnAFFICHER";
            this.btnAFFICHER.Size = new System.Drawing.Size(75, 23);
            this.btnAFFICHER.TabIndex = 9;
            this.btnAFFICHER.Text = "AFFICHER";
            this.btnAFFICHER.UseVisualStyleBackColor = true;
            this.btnAFFICHER.Click += new System.EventHandler(this.btnAFFICHER_Click);
            // 
            // btnMODIFIER
            // 
            this.btnMODIFIER.Location = new System.Drawing.Point(655, 241);
            this.btnMODIFIER.Name = "btnMODIFIER";
            this.btnMODIFIER.Size = new System.Drawing.Size(75, 23);
            this.btnMODIFIER.TabIndex = 10;
            this.btnMODIFIER.Text = "MOFIFIER";
            this.btnMODIFIER.UseVisualStyleBackColor = true;
            this.btnMODIFIER.Click += new System.EventHandler(this.btnMODIFIER_Click);
            // 
            // btnSUPPRIMER
            // 
            this.btnSUPPRIMER.Location = new System.Drawing.Point(655, 270);
            this.btnSUPPRIMER.Name = "btnSUPPRIMER";
            this.btnSUPPRIMER.Size = new System.Drawing.Size(75, 23);
            this.btnSUPPRIMER.TabIndex = 11;
            this.btnSUPPRIMER.Text = "Supprimer";
            this.btnSUPPRIMER.UseVisualStyleBackColor = true;
            this.btnSUPPRIMER.Click += new System.EventHandler(this.btnSUPPRIMER_Click);
            // 
            // btnAJOUTER
            // 
            this.btnAJOUTER.Location = new System.Drawing.Point(655, 212);
            this.btnAJOUTER.Name = "btnAJOUTER";
            this.btnAJOUTER.Size = new System.Drawing.Size(75, 23);
            this.btnAJOUTER.TabIndex = 12;
            this.btnAJOUTER.Text = "AJOUTER";
            this.btnAJOUTER.UseVisualStyleBackColor = true;
            this.btnAJOUTER.Click += new System.EventHandler(this.btnAJOUTER_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOM";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PRENOM";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ADRESSE";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Rechercher_par_nom";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientVue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAJOUTER);
            this.Controls.Add(this.btnSUPPRIMER);
            this.Controls.Add(this.btnMODIFIER);
            this.Controls.Add(this.btnAFFICHER);
            this.Controls.Add(this.lblADRESSE);
            this.Controls.Add(this.lblPRENOM);
            this.Controls.Add(this.lalNOM);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbADRESSE);
            this.Controls.Add(this.tbPRENOM);
            this.Controls.Add(this.tbNOM);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.dGVWClient);
            this.Name = "ClientVue";
            this.Text = "ClientVue";
            ((System.ComponentModel.ISupportInitialize)(this.dGVWClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVWClient;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNOM;
        private System.Windows.Forms.TextBox tbPRENOM;
        private System.Windows.Forms.TextBox tbADRESSE;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lalNOM;
        private System.Windows.Forms.Label lblPRENOM;
        private System.Windows.Forms.Label lblADRESSE;
        private System.Windows.Forms.Button btnAFFICHER;
        private System.Windows.Forms.Button btnMODIFIER;
        private System.Windows.Forms.Button btnSUPPRIMER;
        private System.Windows.Forms.Button btnAJOUTER;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button1;
    }
}