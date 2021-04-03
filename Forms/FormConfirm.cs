
using System.Windows.Forms;

namespace EasyShutdown.Forms {
    public partial class FormConfirm : Form {

        public FormConfirm(string label, bool checkboxChecked) {
            InitializeComponent();

            this.labelConfirm.Text = label;
            this.checkBox.Checked = checkboxChecked;
        }

        public bool isCheckboxChecked() {
            return this.checkBox.Checked;
        }

        private void buttonAccept_Click(object sender, System.EventArgs e) {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e) {
            Close();
        }
    }
}
