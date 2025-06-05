namespace atelier2
{
    partial class FrmModifierPersonnel
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
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            txtTel = new TextBox();
            txtMail = new TextBox();
            cmbService = new ComboBox();
            btnValider = new Button();
            btnAnnuler = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(140, 30);
            txtNom.Name = "txtNom";
            txtNom.PlaceholderText = "Nom";
            txtNom.Size = new Size(200, 23);
            txtNom.TabIndex = 0;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(140, 70);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.PlaceholderText = "Prénom";
            txtPrenom.Size = new Size(200, 23);
            txtPrenom.TabIndex = 1;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(140, 110);
            txtTel.Name = "txtTel";
            txtTel.PlaceholderText = "Téléphone";
            txtTel.Size = new Size(200, 23);
            txtTel.TabIndex = 2;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(140, 150);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "Email";
            txtMail.Size = new Size(200, 23);
            txtMail.TabIndex = 3;
            // 
            // cmbService
            // 
            cmbService.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbService.Location = new Point(140, 190);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(200, 23);
            cmbService.TabIndex = 4;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(140, 230);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(90, 30);
            btnValider.TabIndex = 5;
            btnValider.Text = "Valider";
            btnValider.Click += btnValider_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(250, 230);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(90, 30);
            btnAnnuler.TabIndex = 6;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 33);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 7;
            label1.Text = "Nom";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 73);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 8;
            label2.Text = "Prénom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 113);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 9;
            label3.Text = "Téléphone";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 153);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 193);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 11;
            label5.Text = "Service";
            // 
            // FrmModifierPersonnel
            // 
            ClientSize = new Size(400, 300);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNom);
            Controls.Add(txtPrenom);
            Controls.Add(txtTel);
            Controls.Add(txtMail);
            Controls.Add(cmbService);
            Controls.Add(btnValider);
            Controls.Add(btnAnnuler);
            Name = "FrmModifierPersonnel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modifier un personnel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private TextBox txtPrenom;
        private TextBox txtTel;
        private TextBox txtMail;
        private ComboBox cmbService;
        private Button btnValider;
        private Button btnAnnuler;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
