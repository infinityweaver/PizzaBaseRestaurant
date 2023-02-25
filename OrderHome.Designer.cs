
namespace PizzaBaseRestaurant
{
    partial class OrderHome
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
            this.ordersList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openOrderbutton = new System.Windows.Forms.Button();
            this.saveOrderButton = new System.Windows.Forms.Button();
            this.totalPriceDisplay = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.diyAddToOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.diyctype2 = new System.Windows.Forms.RadioButton();
            this.diyctype1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.DIYPizzaSize = new System.Windows.Forms.ComboBox();
            this.toppingsList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctype2 = new System.Windows.Forms.RadioButton();
            this.ctype1 = new System.Windows.Forms.RadioButton();
            this.prefabAddToOrder = new System.Windows.Forms.Button();
            this.prefabList = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bevButton4 = new System.Windows.Forms.Button();
            this.bevButton3 = new System.Windows.Forms.Button();
            this.bevButton2 = new System.Windows.Forms.Button();
            this.bevButton1 = new System.Windows.Forms.Button();
            this.clearOrdersButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersList
            // 
            this.ordersList.FormattingEnabled = true;
            this.ordersList.HorizontalScrollbar = true;
            this.ordersList.ItemHeight = 20;
            this.ordersList.Location = new System.Drawing.Point(15, 29);
            this.ordersList.Name = "ordersList";
            this.ordersList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ordersList.Size = new System.Drawing.Size(355, 724);
            this.ordersList.Sorted = true;
            this.ordersList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearOrdersButton);
            this.groupBox1.Controls.Add(this.openOrderbutton);
            this.groupBox1.Controls.Add(this.saveOrderButton);
            this.groupBox1.Controls.Add(this.totalPriceDisplay);
            this.groupBox1.Controls.Add(this.ordersList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 847);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Current Orders";
            // 
            // openOrderbutton
            // 
            this.openOrderbutton.Location = new System.Drawing.Point(15, 756);
            this.openOrderbutton.Name = "openOrderbutton";
            this.openOrderbutton.Size = new System.Drawing.Size(186, 33);
            this.openOrderbutton.TabIndex = 3;
            this.openOrderbutton.Text = "Open Order...";
            this.openOrderbutton.UseVisualStyleBackColor = true;
            // 
            // saveOrderButton
            // 
            this.saveOrderButton.Location = new System.Drawing.Point(15, 795);
            this.saveOrderButton.Name = "saveOrderButton";
            this.saveOrderButton.Size = new System.Drawing.Size(186, 33);
            this.saveOrderButton.TabIndex = 2;
            this.saveOrderButton.Text = "Save Order...";
            this.saveOrderButton.UseVisualStyleBackColor = true;
            // 
            // totalPriceDisplay
            // 
            this.totalPriceDisplay.AutoSize = true;
            this.totalPriceDisplay.Location = new System.Drawing.Point(207, 762);
            this.totalPriceDisplay.Name = "totalPriceDisplay";
            this.totalPriceDisplay.Size = new System.Drawing.Size(81, 20);
            this.totalPriceDisplay.TabIndex = 1;
            this.totalPriceDisplay.Text = "Total Price:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(406, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 847);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(22, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 656);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pizzas";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.diyAddToOrder);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.diyctype2);
            this.groupBox6.Controls.Add(this.diyctype1);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.DIYPizzaSize);
            this.groupBox6.Controls.Add(this.toppingsList);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(18, 229);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(306, 417);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "DoItYourself";
            // 
            // diyAddToOrder
            // 
            this.diyAddToOrder.Location = new System.Drawing.Point(22, 353);
            this.diyAddToOrder.Name = "diyAddToOrder";
            this.diyAddToOrder.Size = new System.Drawing.Size(279, 50);
            this.diyAddToOrder.TabIndex = 8;
            this.diyAddToOrder.Text = "Add to Order";
            this.diyAddToOrder.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Crust Type:";
            // 
            // diyctype2
            // 
            this.diyctype2.AutoSize = true;
            this.diyctype2.Location = new System.Drawing.Point(167, 323);
            this.diyctype2.Name = "diyctype2";
            this.diyctype2.Size = new System.Drawing.Size(99, 24);
            this.diyctype2.TabIndex = 6;
            this.diyctype2.Text = "deep crust";
            this.diyctype2.UseVisualStyleBackColor = true;
            // 
            // diyctype1
            // 
            this.diyctype1.AutoSize = true;
            this.diyctype1.Checked = true;
            this.diyctype1.Location = new System.Drawing.Point(58, 323);
            this.diyctype1.Name = "diyctype1";
            this.diyctype1.Size = new System.Drawing.Size(103, 24);
            this.diyctype1.TabIndex = 5;
            this.diyctype1.TabStop = true;
            this.diyctype1.Text = "crispy base";
            this.diyctype1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select size:";
            // 
            // DIYPizzaSize
            // 
            this.DIYPizzaSize.FormattingEnabled = true;
            this.DIYPizzaSize.Location = new System.Drawing.Point(21, 265);
            this.DIYPizzaSize.Name = "DIYPizzaSize";
            this.DIYPizzaSize.Size = new System.Drawing.Size(279, 28);
            this.DIYPizzaSize.TabIndex = 2;
            // 
            // toppingsList
            // 
            this.toppingsList.FormattingEnabled = true;
            this.toppingsList.Location = new System.Drawing.Point(21, 57);
            this.toppingsList.Name = "toppingsList";
            this.toppingsList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toppingsList.Size = new System.Drawing.Size(279, 180);
            this.toppingsList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select toppings:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.ctype2);
            this.groupBox5.Controls.Add(this.ctype1);
            this.groupBox5.Controls.Add(this.prefabAddToOrder);
            this.groupBox5.Controls.Add(this.prefabList);
            this.groupBox5.Location = new System.Drawing.Point(18, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(306, 197);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Prefab";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Crust Type:";
            // 
            // ctype2
            // 
            this.ctype2.AutoSize = true;
            this.ctype2.Location = new System.Drawing.Point(167, 99);
            this.ctype2.Name = "ctype2";
            this.ctype2.Size = new System.Drawing.Size(99, 24);
            this.ctype2.TabIndex = 3;
            this.ctype2.Text = "deep crust";
            this.ctype2.UseVisualStyleBackColor = true;
            // 
            // ctype1
            // 
            this.ctype1.AutoSize = true;
            this.ctype1.Checked = true;
            this.ctype1.Location = new System.Drawing.Point(58, 99);
            this.ctype1.Name = "ctype1";
            this.ctype1.Size = new System.Drawing.Size(103, 24);
            this.ctype1.TabIndex = 2;
            this.ctype1.TabStop = true;
            this.ctype1.Text = "crispy base";
            this.ctype1.UseVisualStyleBackColor = true;
            // 
            // prefabAddToOrder
            // 
            this.prefabAddToOrder.Location = new System.Drawing.Point(21, 129);
            this.prefabAddToOrder.Name = "prefabAddToOrder";
            this.prefabAddToOrder.Size = new System.Drawing.Size(279, 50);
            this.prefabAddToOrder.TabIndex = 1;
            this.prefabAddToOrder.Text = "Add to Order";
            this.prefabAddToOrder.UseVisualStyleBackColor = true;
            // 
            // prefabList
            // 
            this.prefabList.FormattingEnabled = true;
            this.prefabList.Location = new System.Drawing.Point(21, 34);
            this.prefabList.Name = "prefabList";
            this.prefabList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.prefabList.Size = new System.Drawing.Size(279, 28);
            this.prefabList.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bevButton4);
            this.groupBox3.Controls.Add(this.bevButton3);
            this.groupBox3.Controls.Add(this.bevButton2);
            this.groupBox3.Controls.Add(this.bevButton1);
            this.groupBox3.Location = new System.Drawing.Point(22, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 147);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Beverage";
            // 
            // bevButton4
            // 
            this.bevButton4.Location = new System.Drawing.Point(174, 82);
            this.bevButton4.Name = "bevButton4";
            this.bevButton4.Size = new System.Drawing.Size(150, 50);
            this.bevButton4.TabIndex = 3;
            this.bevButton4.Text = "Lemonade (Large)";
            this.bevButton4.UseVisualStyleBackColor = true;
            // 
            // bevButton3
            // 
            this.bevButton3.Location = new System.Drawing.Point(174, 26);
            this.bevButton3.Name = "bevButton3";
            this.bevButton3.Size = new System.Drawing.Size(150, 50);
            this.bevButton3.TabIndex = 3;
            this.bevButton3.Text = "Lemonade (Small)";
            this.bevButton3.UseVisualStyleBackColor = true;
            // 
            // bevButton2
            // 
            this.bevButton2.Location = new System.Drawing.Point(18, 82);
            this.bevButton2.Name = "bevButton2";
            this.bevButton2.Size = new System.Drawing.Size(150, 50);
            this.bevButton2.TabIndex = 2;
            this.bevButton2.Text = "Cola (Large)";
            this.bevButton2.UseVisualStyleBackColor = true;
            // 
            // bevButton1
            // 
            this.bevButton1.Location = new System.Drawing.Point(18, 26);
            this.bevButton1.Name = "bevButton1";
            this.bevButton1.Size = new System.Drawing.Size(150, 50);
            this.bevButton1.TabIndex = 1;
            this.bevButton1.Text = "Cola (Small)";
            this.bevButton1.UseVisualStyleBackColor = true;
            // 
            // clearOrdersButton
            // 
            this.clearOrdersButton.Location = new System.Drawing.Point(207, 795);
            this.clearOrdersButton.Name = "clearOrdersButton";
            this.clearOrdersButton.Size = new System.Drawing.Size(163, 33);
            this.clearOrdersButton.TabIndex = 4;
            this.clearOrdersButton.Text = "Clear Orders";
            this.clearOrdersButton.UseVisualStyleBackColor = true;
            // 
            // OrderHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 870);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OrderHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderHome";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ordersList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalPriceDisplay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bevButton4;
        private System.Windows.Forms.Button bevButton3;
        private System.Windows.Forms.Button bevButton2;
        private System.Windows.Forms.Button bevButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button prefabAddToOrder;
        private System.Windows.Forms.ComboBox prefabList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ctype2;
        private System.Windows.Forms.RadioButton ctype1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckedListBox toppingsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button diyAddToOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton diyctype2;
        private System.Windows.Forms.RadioButton diyctype1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DIYPizzaSize;
        private System.Windows.Forms.Button saveOrderButton;
        private System.Windows.Forms.Button openOrderbutton;
        private System.Windows.Forms.Button clearOrdersButton;
    }
}