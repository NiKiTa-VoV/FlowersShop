
namespace FlowersShop.View
{
    partial class FormStart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.labelList = new System.Windows.Forms.Label();
            this.comboBoxBasket = new System.Windows.Forms.ComboBox();
            this.labelBasket = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.labelSelect = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(12, 41);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(142, 23);
            this.comboBoxItems.TabIndex = 1;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxItems_SelectedIndexChanged);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(12, 23);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(91, 15);
            this.labelList.TabIndex = 1;
            this.labelList.Text = "Список цветов:";
            // 
            // comboBoxBasket
            // 
            this.comboBoxBasket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBasket.FormattingEnabled = true;
            this.comboBoxBasket.Location = new System.Drawing.Point(162, 41);
            this.comboBoxBasket.Name = "comboBoxBasket";
            this.comboBoxBasket.Size = new System.Drawing.Size(150, 23);
            this.comboBoxBasket.TabIndex = 3;
            this.comboBoxBasket.SelectedIndexChanged += new System.EventHandler(this.comboBoxBasket_SelectedIndexChanged);
            // 
            // labelBasket
            // 
            this.labelBasket.AutoSize = true;
            this.labelBasket.Location = new System.Drawing.Point(162, 23);
            this.labelBasket.Name = "labelBasket";
            this.labelBasket.Size = new System.Drawing.Size(56, 15);
            this.labelBasket.TabIndex = 3;
            this.labelBasket.Text = "Корзина:";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(238, 317);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 79);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(237, 79);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(12, 317);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonInfo.TabIndex = 0;
            this.buttonInfo.Text = "Справка";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(12, 117);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(116, 15);
            this.labelSelect.TabIndex = 9;
            this.labelSelect.Text = "Выбранный цветок:";
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(13, 139);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(47, 15);
            this.labelItem.TabIndex = 10;
            this.labelItem.Text = "текст....";
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(157, 317);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 5;
            this.buttonBuy.Text = "Купить";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Цена цветов в корзине:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(162, 139);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(45, 15);
            this.labelPrice.TabIndex = 15;
            this.labelPrice.Text = "цена....";
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 350);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelBasket);
            this.Controls.Add(this.comboBoxBasket);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.comboBoxItems);
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.ComboBox comboBoxBasket;
        private System.Windows.Forms.Label labelBasket;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPrice;
    }
}

