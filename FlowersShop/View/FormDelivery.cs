using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryFlowersShop;

namespace FlowersShop.View
{
    public partial class FormDelivery : Form
    {
        private const int PriceDelivery = 350;
        public FormDelivery()
        {
            InitializeComponent();
        }
        private void FormDelivery_Load(object sender, EventArgs e)
        {
            var x = Owner.Location.X + (Owner.Width - Width) / 2;
            var y = Owner.Location.Y + (Owner.Height - Height) / 2;
            Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
            radioButtonPickUp_CheckedChanged(sender,e);
            radioButtonCash_CheckedChanged(sender,e);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var owner = Owner;
            this.Close();
            owner.Visible = true;
        }

        private void radioButtonPickUp_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPickUp.Checked)
            {
                textBoxAddress.Enabled = false;
                textBoxAddress.Text = "";
                labelPriceDelivery.Text ="-";
                labelPrice.Text = Convert.ToString(Basket.AllPrice = Basket.Price) + "руб.";
                Cheque.TypeDelivery = radioButtonPickUp.Text;
                Cheque.Address = "-";
            }
            else
            {
                textBoxAddress.Enabled = true;
                labelPriceDelivery.Text = "350руб.";
                labelPrice.Text = Convert.ToString(Basket.AllPrice = PriceDelivery + Basket.Price) + "руб.";
                Cheque.TypeDelivery = radioButtonDelivery.Text;
                Cheque.Address = textBoxAddress.Text;
            }

        }

        private void radioButtonCash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCash.Checked)
                Cheque.TypePayment = radioButtonCash.Text;
            else
                Cheque.TypePayment = radioButtonCashless.Text;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (textBoxFLM.Text != "")
            {
                if (!radioButtonDelivery.Checked || textBoxAddress.Text != "")
                {
                    Cheque.Flm = textBoxFLM.Text;
                    this.Visible = false;
                    new FormCheque().Show(this);
                }
                else
                    MessageBox.Show("Не заполнено поле адреса!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Не заполнено поле ФИО!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
