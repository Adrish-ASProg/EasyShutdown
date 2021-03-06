using EasyShutdown.Forms;
using EasyShutdown.Properties;
using System;
using System.Windows.Forms;

namespace EasyShutdown {
    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();

            dateTimeDay.MinDate = DateTime.Today;
            this.Icon = Resources.shutdown;
        }


        private void Execute() {
            var shutdownDate = ComputeShutdownDate();
            var remainingTime = shutdownDate - DateTime.Now;

            if (remainingTime.TotalMinutes <= 0) {
                MessageBox.Show(this, $"La date ne doit pas être antérieure à la date actuelle.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mode;
            Action<int> action;

            // Détermination Arret ou Veille
            if (radioShutdown.Checked) {
                mode = "l'arrêt";
                action = Utils.ScheduleShutdown;
            }
            else {
                mode = "la veille prolongée";
                action = Utils.ScheduleHibernation;
            }

            var message = $"Programmer {mode} le {shutdownDate.ToString("dddd dd MMMM' à 'HH\\:mm")} ?\n" +
                $"({remainingTime:%d' jours et 'hh\\:mm\\:ss} restant)";

            var autoClosePreference = Settings.Default.autoClose;

            var confirmForm = new FormConfirm(message, autoClosePreference);
            confirmForm.ShowDialog();

            if (confirmForm.DialogResult == DialogResult.Yes) {
                action.Invoke((int) Math.Round(remainingTime.TotalSeconds));

                Settings.Default.autoClose = confirmForm.isCheckboxChecked();
                Settings.Default.Save();

                if (confirmForm.isCheckboxChecked()) Close();
            }
        }

        private DateTime ComputeShutdownDate() {
            var shutdownDate = DateTime.Now;

            if (radioAtTime.Checked)
                shutdownDate = dateTimeDay.Value;

            shutdownDate = shutdownDate.AddHours(dateTimeHour.Value.Hour)
                    .AddMinutes(dateTimeHour.Value.Minute)
                    .AddSeconds(dateTimeHour.Value.Second);

            return shutdownDate;
        }


        /**
         * Annulation d'une programmation d'extinction
         */
        private void CancelShutdown() {
            var dialogResult = Utils.ShowConfirmDialog(this, $"Annuler une extinction en cours ?");

            if (dialogResult == DialogResult.Yes) Utils.CancelShutdown();
        }




        #region ########## LISTENERS ##########

        private void radioAfterPeriod_CheckedChanged(object sender, EventArgs e) {
            var bounds = dateTimeHour.Bounds;

            if (radioAfterPeriod.Checked) {
                dateTimeDay.Visible = false;
                dateTimeHour.SetBounds(122, bounds.Y, 138, bounds.Height);
            }
            else {
                dateTimeDay.Visible = true;
                dateTimeHour.SetBounds(207, bounds.Y, 150, bounds.Height);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            Execute();
        }

        #endregion




        #region ########## MENU ##########

        private void menuItemCancelShutdown_Click(object sender, EventArgs e) {
            CancelShutdown();
        }

        private void menuItemAbout_Click(object sender, EventArgs e) {
            MessageBox.Show(this,
                "EasyShutdown v0.1\nIcons: Flaticon.com ♥\n© 2021 ASProg - All Rights reserved", "À propos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuItemQuit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        #endregion
    }
}

