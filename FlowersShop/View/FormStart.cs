using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using LibraryFlowersShop;
using LibraryFlowersShop.Utils;

namespace FlowersShop.View
{
    public partial class FormStart : Form
    {
        private Flower _selectFlower;
        private Flower _selectFlowerBasket;
        private readonly Dictionary<string,Flower> _items = new Dictionary<string, Flower>();
        public FormStart()
        {
            InitializeComponent();
            labelPrice.Text = 0 + "руб.";
            var items = FileItems.Read(@"Files\Items.txt");

            foreach (var item in items)
            {

                comboBoxItems.Items.Add($"{item.Name} - {item.Price}руб.");
                _items.Add($"{item.Name} - {item.Price}руб.",item);
            }

            if (items.Count > 0)
            {
                comboBoxItems.SelectedIndex = 0;
            }
        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            _items.TryGetValue(comboBoxItems.Text, out _selectFlower);
            labelItem.Text = $"Цветок: {_selectFlower.Name}{Environment.NewLine}Цена: {_selectFlower.Price}руб.{Environment.NewLine}";
        }

        private void comboBoxBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            _items.TryGetValue(comboBoxBasket.Text, out _selectFlowerBasket);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!Basket.Flowers.Contains(_selectFlower))
            {
                Basket.Flowers.Add(_selectFlower);
                comboBoxBasket.Items.Add($"{_selectFlower?.Name ?? "Ошибка!"} - {_selectFlower?.Price ?? 0}руб.");
                comboBoxBasket.SelectedIndex = comboBoxBasket.Items.Count - 1;
                labelPrice.Text = Convert.ToString(Basket.Price = CalculatingPrice.Calculating()) + "руб.";
                comboBoxBasket.SelectedIndex = Basket.Flowers.Count - 1;
            }
            else
            {
                MessageBox.Show("Такой цветок уже присутствует в корзине!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Basket.Flowers.Count == 0)
            {
                MessageBox.Show("Ваша корзина пуста!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            comboBoxBasket.Text = "";
            if (Basket.Flowers.IndexOf(_selectFlowerBasket) != -1)
            {
                comboBoxBasket.Items.RemoveAt(Basket.Flowers.IndexOf(_selectFlowerBasket));
                Basket.Flowers.Remove(_selectFlowerBasket);
                comboBoxBasket.SelectedIndex = Basket.Flowers.Count - 1;
                labelPrice.Text = Convert.ToString(Basket.Price = CalculatingPrice.Calculating()) + "руб.";
            }
        }
        
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (Basket.Flowers.Count != 0)
            {
                this.Visible = false;
                new FormDelivery().Show(this);
                Cheque.Price = Basket.Price;
            }
            else
            {
                MessageBox.Show("Ваша корзина пуста!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show( File.ReadAllText(@"Files\Hello.txt"), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
