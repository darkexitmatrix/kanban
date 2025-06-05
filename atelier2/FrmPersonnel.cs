using System;
using System.Collections.Generic;
using System.Windows.Forms;
using atelier2.dal;
using atelier2.model;

namespace atelier2
{
    public partial class FrmPersonnel : Form
    {
        private readonly PersonnelAccess personnelAccess;
        private BindingSource bsPersonnels = new BindingSource();

        public FrmPersonnel()
        {
            InitializeComponent();
            personnelAccess = new PersonnelAccess();
            this.Load += FrmPersonnel_Load;
            btnAjouter.Click += btnAjouter_Click;
            btnModifier.Click += btnModifier_Click;
            btnSupprimer.Click += btnSupprimer_Click;
            btnAbsences.Click += btnAbsences_Click;
        }

        private void FrmPersonnel_Load(object sender, EventArgs e)
        {
            ChargerListePersonnels();
        }

        private void ChargerListePersonnels()
        {
            List<Personnel> personnels = personnelAccess.GetAllPersonnels();
            bsPersonnels.DataSource = personnels;

            dgvPersonnels.DataSource = null;
            dgvPersonnels.AutoGenerateColumns = false;
            dgvPersonnels.Columns.Clear();

            dgvPersonnels.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nom",
                HeaderText = "Nom"
            });
            dgvPersonnels.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Prenom",
                HeaderText = "Prénom"
            });
            dgvPersonnels.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Mail",
                HeaderText = "Email"
            });
            dgvPersonnels.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Tel",
                HeaderText = "Téléphone"
            });
            dgvPersonnels.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "idservice",
                HeaderText = "Service"
            });

            dgvPersonnels.DataSource = bsPersonnels;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjouterPersonnel frmAjout = new FrmAjouterPersonnel();
            if (frmAjout.ShowDialog() == DialogResult.OK)
            {
                ChargerListePersonnels();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.CurrentRow == null) return;

            if (dgvPersonnels.CurrentRow.DataBoundItem is Personnel perso)
            {
                FrmModifierPersonnel frmModif = new FrmModifierPersonnel(perso);
                if (frmModif.ShowDialog() == DialogResult.OK)
                {
                    ChargerListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Erreur : l'objet sélectionné n'est pas un Personnel.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.CurrentRow == null) return;

            if (dgvPersonnels.CurrentRow.DataBoundItem is Personnel perso)
            {
                DialogResult confirm = MessageBox.Show(
                    $"Confirmer la suppression de {perso.Nom} {perso.Prenom} ?",
                    "Confirmation", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    personnelAccess.SupprimerPersonnel(perso.IdPersonnel);
                    ChargerListePersonnels();
                }
            }
        }

        private void btnAbsences_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un personnel.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvPersonnels.CurrentRow.DataBoundItem is Personnel perso)
            {
                FrmAbsences frmAbs = new FrmAbsences(perso);
                frmAbs.ShowDialog();
            }
            else
            {
                MessageBox.Show("Erreur : l'objet sélectionné n'est pas un Personnel.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
