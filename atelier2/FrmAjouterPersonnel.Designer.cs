namespace atelier2
{
    partial class FrmAjouterPersonnel
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtNom = new TextBox();
            this.txtPrenom = new TextBox();
            this.txtTel = new TextBox();
            this.txtMail = new TextBox();
            this.cmbService = new ComboBox();
            this.btnValider = new Button();
            this.btnAnnuler = new Button();
            this.SuspendLayout();
            // 
            // txtNom
            this.txtNom.Location = new Point(140, 30);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new Size(200, 23);
            this.txtNom.PlaceholderText = "Nom";
            // 
            // txtPrenom
            this.txtPrenom.Location = new Point(140, 70);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new Size(200, 23);
            this.txtPrenom.PlaceholderText = "Prénom";
            // 
            // txtTel
            this.txtTel.Location = new Point(140, 110);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new Size(200, 23);
            this.txtTel.PlaceholderText = "Téléphone";
            // 
            // txtMail
            this.txtMail.Location = new Point(140, 150);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new Size(200, 23);
            this.txtMail.PlaceholderText = "Email";
            // 
            // cmbService
            this.cmbService.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbService.Location = new Point(140, 190);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new Size(200, 23);
            // 
            // btnValider
            this.btnValider.Location = new Point(140, 240);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new Size(90, 30);
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            this.btnAnnuler.Location = new Point(250, 240);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new Size(90, 30);
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new EventHandler(this.btnAnnuler_Click);
            // 
            // FrmAjouterPersonnel
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 300);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Name = "FrmAjouterPersonnel";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Ajout d'un personnel";
            this.Load += new EventHandler(this.FrmAjouterPersonnel_Load); // ✅ Important pour charger les services
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private TextBox txtPrenom;
        private TextBox txtTel;
        private TextBox txtMail;
        private ComboBox cmbService;
        private Button btnValider;
        private Button btnAnnuler;
    }
}
