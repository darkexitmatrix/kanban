namespace atelier2
{
    partial class FrmPersonnel
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
            this.dgvPersonnels = new DataGridView();
            this.colNom = new DataGridViewTextBoxColumn();
            this.colPrenom = new DataGridViewTextBoxColumn();
            this.colService = new DataGridViewTextBoxColumn();
            this.btnAjouter = new Button();
            this.btnModifier = new Button();
            this.btnSupprimer = new Button();
            this.btnAbsences = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).BeginInit();
            this.SuspendLayout();

            // dgvPersonnels
            this.dgvPersonnels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnels.Columns.AddRange(new DataGridViewColumn[] {
                this.colNom, this.colPrenom, this.colService });
            this.dgvPersonnels.Location = new Point(50, 30);
            this.dgvPersonnels.Name = "dgvPersonnels";
            this.dgvPersonnels.Size = new Size(500, 250);
            this.dgvPersonnels.TabIndex = 0;

            // colNom
            this.colNom.HeaderText = "Nom";
            this.colNom.Name = "colNom";
            this.colNom.Width = 150;

            // colPrenom
            this.colPrenom.HeaderText = "Prénom";
            this.colPrenom.Name = "colPrenom";
            this.colPrenom.Width = 150;

            // colService
            this.colService.HeaderText = "Service";
            this.colService.Name = "colService";
            this.colService.Width = 150;

            // btnAjouter
            this.btnAjouter.Location = new Point(580, 40);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new Size(120, 30);
            this.btnAjouter.Text = "➕ Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;

            // btnModifier
            this.btnModifier.Location = new Point(580, 90);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new Size(120, 30);
            this.btnModifier.Text = "📝 Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;

            // btnSupprimer
            this.btnSupprimer.Location = new Point(580, 140);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new Size(120, 30);
            this.btnSupprimer.Text = "❌ Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;

            // btnAbsences
            this.btnAbsences.Location = new Point(580, 190);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new Size(120, 30);
            this.btnAbsences.Text = "📆 Gérer absences";
            this.btnAbsences.UseVisualStyleBackColor = true;

            // FrmPersonnel
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(750, 330);
            this.Controls.Add(this.dgvPersonnels);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAbsences);
            this.Name = "FrmPersonnel";
            this.Text = "Gestion du Personnel";

            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPersonnels;
        private DataGridViewTextBoxColumn colNom;
        private DataGridViewTextBoxColumn colPrenom;
        private DataGridViewTextBoxColumn colService;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private Button btnAbsences;
    }
}
