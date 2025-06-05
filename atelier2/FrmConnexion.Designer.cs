namespace atelier2
{
    partial class FrmConnexion
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitre;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitre = new Label();
            this.lblIdentifiant = new Label();
            this.txtLogin = new TextBox();
            this.lblMotDePasse = new Label();
            this.txtMdp = new TextBox();
            this.btnConnexion = new Button();
            this.lblMessage = new Label();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitre.Location = new Point(90, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new Size(163, 25);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Connexion Admin";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new Point(50, 70);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new Size(67, 15);
            this.lblIdentifiant.TabIndex = 1;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new Point(150, 67);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new Size(140, 23);
            this.txtLogin.TabIndex = 2;
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new Point(50, 110);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new Size(87, 15);
            this.lblMotDePasse.TabIndex = 3;
            this.lblMotDePasse.Text = "Mot de passe :";
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new Point(150, 107);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new Size(140, 23);
            this.txtMdp.TabIndex = 4;
            this.txtMdp.UseSystemPasswordChar = true;
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = Color.SteelBlue;
            this.btnConnexion.FlatStyle = FlatStyle.Flat;
            this.btnConnexion.ForeColor = Color.White;
            this.btnConnexion.Location = new Point(115, 150);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new Size(120, 30);
            this.btnConnexion.TabIndex = 5;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new EventHandler(this.btnConnexion_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = Color.Red;
            this.lblMessage.Location = new Point(100, 190);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new Size(0, 15);
            this.lblMessage.TabIndex = 6;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(360, 230);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmConnexion";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new EventHandler(this.FrmConnexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private Label lblIdentifiant;
        private TextBox txtLogin;
        private Label lblMotDePasse;
        private TextBox txtMdp;
        private Button btnConnexion;
        private Label lblMessage;
    }
}
