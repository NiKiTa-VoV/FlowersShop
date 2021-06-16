
namespace FlowersShop.View
{
    partial class FormDelivery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFLM = new System.Windows.Forms.TextBox();
            this.labelFLM = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDelivery = new System.Windows.Forms.RadioButton();
            this.radioButtonPickUp = new System.Windows.Forms.RadioButton();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPriceDelivery = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonCashless = new System.Windows.Forms.RadioButton();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFLM
            // 
            this.textBoxFLM.Location = new System.Drawing.Point(7, 31);
            this.textBoxFLM.Name = "textBoxFLM";
            this.textBoxFLM.Size = new System.Drawing.Size(237, 23);
            this.textBoxFLM.TabIndex = 0;
            // 
            // labelFLM
            // 
            this.labelFLM.AutoSize = true;
            this.labelFLM.Location = new System.Drawing.Point(5, 10);
            this.labelFLM.Name = "labelFLM";
            this.labelFLM.Size = new System.Drawing.Size(83, 15);
            this.labelFLM.TabIndex = 1;
            this.labelFLM.Text = "Введите ФИО:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDelivery);
            this.groupBox1.Controls.Add(this.radioButtonPickUp);
            this.groupBox1.Location = new System.Drawing.Point(7, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Способ доставки";
            // 
            // radioButtonDelivery
            // 
            this.radioButtonDelivery.AutoSize = true;
            this.radioButtonDelivery.Location = new System.Drawing.Point(6, 45);
            this.radioButtonDelivery.Name = "radioButtonDelivery";
            this.radioButtonDelivery.Size = new System.Drawing.Size(75, 19);
            this.radioButtonDelivery.TabIndex = 1;
            this.radioButtonDelivery.Text = "Доставка";
            this.radioButtonDelivery.UseVisualStyleBackColor = true;
            // 
            // radioButtonPickUp
            // 
            this.radioButtonPickUp.AutoSize = true;
            this.radioButtonPickUp.Checked = true;
            this.radioButtonPickUp.Location = new System.Drawing.Point(6, 19);
            this.radioButtonPickUp.Name = "radioButtonPickUp";
            this.radioButtonPickUp.Size = new System.Drawing.Size(88, 19);
            this.radioButtonPickUp.TabIndex = 0;
            this.radioButtonPickUp.TabStop = true;
            this.radioButtonPickUp.Text = "Самовывоз";
            this.radioButtonPickUp.UseVisualStyleBackColor = true;
            this.radioButtonPickUp.CheckedChanged += new System.EventHandler(this.radioButtonPickUp_CheckedChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(7, 148);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(43, 15);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "Адрес:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(7, 169);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(237, 23);
            this.textBoxAddress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Цена доставки: ";
            // 
            // labelPriceDelivery
            // 
            this.labelPriceDelivery.AutoSize = true;
            this.labelPriceDelivery.Location = new System.Drawing.Point(96, 198);
            this.labelPriceDelivery.Name = "labelPriceDelivery";
            this.labelPriceDelivery.Size = new System.Drawing.Size(38, 15);
            this.labelPriceDelivery.TabIndex = 6;
            this.labelPriceDelivery.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Итоговая цена:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonCashless);
            this.groupBox2.Controls.Add(this.radioButtonCash);
            this.groupBox2.Location = new System.Drawing.Point(7, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 77);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Способ оплаты";
            // 
            // radioButtonCashless
            // 
            this.radioButtonCashless.AutoSize = true;
            this.radioButtonCashless.Location = new System.Drawing.Point(7, 48);
            this.radioButtonCashless.Name = "radioButtonCashless";
            this.radioButtonCashless.Size = new System.Drawing.Size(100, 19);
            this.radioButtonCashless.TabIndex = 1;
            this.radioButtonCashless.Text = "Безналичный";
            this.radioButtonCashless.UseVisualStyleBackColor = true;
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Checked = true;
            this.radioButtonCash.Location = new System.Drawing.Point(7, 23);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(83, 19);
            this.radioButtonCash.TabIndex = 0;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Наличные";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            this.radioButtonCash.CheckedChanged += new System.EventHandler(this.radioButtonCash_CheckedChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(169, 355);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(97, 312);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(38, 15);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "label4";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(88, 355);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Оформить";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // FormDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 387);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPriceDelivery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelFLM);
            this.Controls.Add(this.textBoxFLM);
            this.Name = "FormDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Доставка";
            this.Load += new System.EventHandler(this.FormDelivery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFLM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDelivery;
        private System.Windows.Forms.RadioButton radioButtonPickUp;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPriceDelivery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonCashless;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxFLM;
    }
}