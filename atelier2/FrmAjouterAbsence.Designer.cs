// FrmAjouterAbsence.Designer.cs
namespace atelier2
{
    partial class FrmAjouterAbsence
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;

        private void InitializeComponent()
        {
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // dtpDebut
            this.dtpDebut.Location = new System.Drawing.Point(30, 30);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 23);

            // dtpFin
            this.dtpFin.Location = new System.Drawing.Point(30, 70);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 23);

            // txtMotif
            this.txtMotif.Location = new System.Drawing.Point(30, 110);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.PlaceholderText = "Motif";
            this.txtMotif.Size = new System.Drawing.Size(200, 23);

            // btnValider
            this.btnValider.Location = new System.Drawing.Point(30, 150);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(90, 30);
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);

            // btnAnnuler
            this.btnAnnuler.Location = new System.Drawing.Point(140, 150);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(90, 30);
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);

            // FrmAjouterAbsence
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 211);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Name = "FrmAjouterAbsence";
            this.Text = "Ajouter une absence";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
