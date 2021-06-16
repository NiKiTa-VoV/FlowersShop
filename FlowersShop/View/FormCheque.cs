using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LibraryFlowersShop;

namespace FlowersShop.View
{
    public partial class FormCheque : Form
    {
        public FormCheque()
        {
            InitializeComponent();
            saveFileDialogcheque.DefaultExt = ".txt";
            saveFileDialogcheque.FileName = "newFile";
            textBoxcheque.Text = Cheque.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (saveFileDialogcheque.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialogcheque.FileName, textBoxcheque.Text);
        }

        private void FormCheque_Load(object sender, EventArgs e)
        {
            var x = Owner.Location.X + (Owner.Width - Width) / 2;
            var y = Owner.Location.Y + (Owner.Height - Height) / 2;
            Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
