namespace LunchOrder
{
    partial class Form1
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
            this.gbxMain = new System.Windows.Forms.GroupBox();
            this.rbSalad = new System.Windows.Forms.RadioButton();
            this.rbPizza = new System.Windows.Forms.RadioButton();
            this.rbHamburger = new System.Windows.Forms.RadioButton();
            this.gbxOptions = new System.Windows.Forms.GroupBox();
            this.cbOption3 = new System.Windows.Forms.CheckBox();
            this.cbOption2 = new System.Windows.Forms.CheckBox();
            this.cbOption1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblGrand = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbPreview = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbxMain.SuspendLayout();
            this.gbxOptions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMain
            // 
            this.gbxMain.Controls.Add(this.rbSalad);
            this.gbxMain.Controls.Add(this.rbPizza);
            this.gbxMain.Controls.Add(this.rbHamburger);
            this.gbxMain.Location = new System.Drawing.Point(12, 12);
            this.gbxMain.Name = "gbxMain";
            this.gbxMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbxMain.Size = new System.Drawing.Size(141, 100);
            this.gbxMain.TabIndex = 0;
            this.gbxMain.TabStop = false;
            this.gbxMain.Text = "Main Course";
            // 
            // rbSalad
            // 
            this.rbSalad.AutoSize = true;
            this.rbSalad.Location = new System.Drawing.Point(6, 65);
            this.rbSalad.Name = "rbSalad";
            this.rbSalad.Size = new System.Drawing.Size(82, 17);
            this.rbSalad.TabIndex = 17;
            this.rbSalad.TabStop = true;
            this.rbSalad.Text = "Salad - 4.95";
            this.rbSalad.UseVisualStyleBackColor = true;
            this.rbSalad.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbPizza
            // 
            this.rbPizza.AutoSize = true;
            this.rbPizza.Location = new System.Drawing.Point(6, 42);
            this.rbPizza.Name = "rbPizza";
            this.rbPizza.Size = new System.Drawing.Size(80, 17);
            this.rbPizza.TabIndex = 16;
            this.rbPizza.TabStop = true;
            this.rbPizza.Text = "Pizza - 5.95";
            this.rbPizza.UseVisualStyleBackColor = true;
            this.rbPizza.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbHamburger
            // 
            this.rbHamburger.AutoSize = true;
            this.rbHamburger.Location = new System.Drawing.Point(6, 19);
            this.rbHamburger.Name = "rbHamburger";
            this.rbHamburger.Size = new System.Drawing.Size(113, 17);
            this.rbHamburger.TabIndex = 15;
            this.rbHamburger.TabStop = true;
            this.rbHamburger.Text = "Hamburger - $6.95";
            this.rbHamburger.UseVisualStyleBackColor = true;
            this.rbHamburger.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // gbxOptions
            // 
            this.gbxOptions.Controls.Add(this.cbOption3);
            this.gbxOptions.Controls.Add(this.cbOption2);
            this.gbxOptions.Controls.Add(this.cbOption1);
            this.gbxOptions.Location = new System.Drawing.Point(159, 12);
            this.gbxOptions.Name = "gbxOptions";
            this.gbxOptions.Size = new System.Drawing.Size(232, 100);
            this.gbxOptions.TabIndex = 1;
            this.gbxOptions.TabStop = false;
            this.gbxOptions.Text = "Add-on items";
            // 
            // cbOption3
            // 
            this.cbOption3.AutoSize = true;
            this.cbOption3.Location = new System.Drawing.Point(6, 65);
            this.cbOption3.Name = "cbOption3";
            this.cbOption3.Size = new System.Drawing.Size(80, 17);
            this.cbOption3.TabIndex = 20;
            this.cbOption3.Text = "checkBox3";
            this.cbOption3.UseVisualStyleBackColor = true;
            this.cbOption3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbOption2
            // 
            this.cbOption2.AutoSize = true;
            this.cbOption2.Location = new System.Drawing.Point(6, 42);
            this.cbOption2.Name = "cbOption2";
            this.cbOption2.Size = new System.Drawing.Size(80, 17);
            this.cbOption2.TabIndex = 19;
            this.cbOption2.Text = "checkBox2";
            this.cbOption2.UseVisualStyleBackColor = true;
            this.cbOption2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbOption1
            // 
            this.cbOption1.AutoSize = true;
            this.cbOption1.Location = new System.Drawing.Point(6, 19);
            this.cbOption1.Name = "cbOption1";
            this.cbOption1.Size = new System.Drawing.Size(80, 17);
            this.cbOption1.TabIndex = 18;
            this.cbOption1.Text = "checkBox1";
            this.cbOption1.UseVisualStyleBackColor = true;
            this.cbOption1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblGrand);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lblTax);
            this.groupBox3.Controls.Add(this.lblSubTotal);
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Total";
            // 
            // lblGrand
            // 
            this.lblGrand.BackColor = System.Drawing.Color.White;
            this.lblGrand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrand.Location = new System.Drawing.Point(192, 92);
            this.lblGrand.Name = "lblGrand";
            this.lblGrand.Size = new System.Drawing.Size(100, 23);
            this.lblGrand.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Current Total (w/ tax)";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Item Total (w/ tax)";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tax (7.75%)";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Subtotal";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(192, 69);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 7;
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.Color.White;
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTax.Location = new System.Drawing.Point(192, 46);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(100, 23);
            this.lblTax.TabIndex = 6;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.Color.White;
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTotal.Location = new System.Drawing.Point(192, 23);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(100, 23);
            this.lblSubTotal.TabIndex = 5;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(316, 147);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(316, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(316, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbPreview
            // 
            this.lbPreview.FormattingEnabled = true;
            this.lbPreview.Location = new System.Drawing.Point(397, 19);
            this.lbPreview.Name = "lbPreview";
            this.lbPreview.Size = new System.Drawing.Size(209, 225);
            this.lbPreview.TabIndex = 21;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(316, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "New Order";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(618, 253);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbPreview);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbxOptions);
            this.Controls.Add(this.gbxMain);
            this.Name = "Form1";
            this.Text = "Lunch Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxMain.ResumeLayout(false);
            this.gbxMain.PerformLayout();
            this.gbxOptions.ResumeLayout(false);
            this.gbxOptions.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMain;
        private System.Windows.Forms.RadioButton rbSalad;
        private System.Windows.Forms.RadioButton rbPizza;
        private System.Windows.Forms.RadioButton rbHamburger;
        private System.Windows.Forms.GroupBox gbxOptions;
        private System.Windows.Forms.CheckBox cbOption3;
        private System.Windows.Forms.CheckBox cbOption2;
        private System.Windows.Forms.CheckBox cbOption1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbPreview;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblGrand;
        private System.Windows.Forms.Label label1;
    }
}

