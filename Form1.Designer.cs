namespace TradeCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Investment = new System.Windows.Forms.Label();
            this.lbl_BuyValue = new System.Windows.Forms.Label();
            this.lbl_Leverage = new System.Windows.Forms.Label();
            this.lbl_SellValue = new System.Windows.Forms.Label();
            this.txt_Investment = new System.Windows.Forms.TextBox();
            this.txt_BuyValue = new System.Windows.Forms.TextBox();
            this.txt_Leverage = new System.Windows.Forms.TextBox();
            this.txt_SellValue = new System.Windows.Forms.TextBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssl_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.tab_Calculators = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_TaxedReturn = new System.Windows.Forms.TextBox();
            this.lxl_ReturnTax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tab_Calculators.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Investment
            // 
            this.lbl_Investment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Investment.AutoSize = true;
            this.lbl_Investment.Location = new System.Drawing.Point(76, 23);
            this.lbl_Investment.Name = "lbl_Investment";
            this.lbl_Investment.Size = new System.Drawing.Size(83, 13);
            this.lbl_Investment.TabIndex = 0;
            this.lbl_Investment.Text = "Investment Sum";
            // 
            // lbl_BuyValue
            // 
            this.lbl_BuyValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_BuyValue.AutoSize = true;
            this.lbl_BuyValue.Location = new System.Drawing.Point(209, 23);
            this.lbl_BuyValue.Name = "lbl_BuyValue";
            this.lbl_BuyValue.Size = new System.Drawing.Size(55, 13);
            this.lbl_BuyValue.TabIndex = 1;
            this.lbl_BuyValue.Text = "Buy Value";
            this.lbl_BuyValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Leverage
            // 
            this.lbl_Leverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Leverage.AutoSize = true;
            this.lbl_Leverage.Location = new System.Drawing.Point(90, 62);
            this.lbl_Leverage.Name = "lbl_Leverage";
            this.lbl_Leverage.Size = new System.Drawing.Size(52, 13);
            this.lbl_Leverage.TabIndex = 2;
            this.lbl_Leverage.Text = "Leverage";
            this.lbl_Leverage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_SellValue
            // 
            this.lbl_SellValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_SellValue.AutoSize = true;
            this.lbl_SellValue.Location = new System.Drawing.Point(209, 62);
            this.lbl_SellValue.Name = "lbl_SellValue";
            this.lbl_SellValue.Size = new System.Drawing.Size(54, 13);
            this.lbl_SellValue.TabIndex = 3;
            this.lbl_SellValue.Text = "Sell Value";
            this.lbl_SellValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_Investment
            // 
            this.txt_Investment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_Investment.Location = new System.Drawing.Point(70, 39);
            this.txt_Investment.Name = "txt_Investment";
            this.txt_Investment.Size = new System.Drawing.Size(100, 20);
            this.txt_Investment.TabIndex = 4;
            this.txt_Investment.Enter += new System.EventHandler(this.Txt_Investment_Enter);
            this.txt_Investment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Investment_KeyPress);
            // 
            // txt_BuyValue
            // 
            this.txt_BuyValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_BuyValue.Location = new System.Drawing.Point(190, 39);
            this.txt_BuyValue.Name = "txt_BuyValue";
            this.txt_BuyValue.Size = new System.Drawing.Size(100, 20);
            this.txt_BuyValue.TabIndex = 5;
            this.txt_BuyValue.Enter += new System.EventHandler(this.Txt_BuyValue_Enter);
            this.txt_BuyValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_BuyValue_KeyPress);
            // 
            // txt_Leverage
            // 
            this.txt_Leverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_Leverage.Location = new System.Drawing.Point(70, 78);
            this.txt_Leverage.Name = "txt_Leverage";
            this.txt_Leverage.Size = new System.Drawing.Size(100, 20);
            this.txt_Leverage.TabIndex = 6;
            this.txt_Leverage.Enter += new System.EventHandler(this.Txt_Leverage_Enter);
            this.txt_Leverage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Leverage_KeyPress);
            // 
            // txt_SellValue
            // 
            this.txt_SellValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_SellValue.Location = new System.Drawing.Point(190, 78);
            this.txt_SellValue.Name = "txt_SellValue";
            this.txt_SellValue.Size = new System.Drawing.Size(100, 20);
            this.txt_SellValue.TabIndex = 7;
            this.txt_SellValue.Enter += new System.EventHandler(this.Txt_SellValue_Enter);
            this.txt_SellValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SellValue_KeyPress);
            // 
            // txt_Result
            // 
            this.txt_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_Result.Location = new System.Drawing.Point(70, 155);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(100, 20);
            this.txt_Result.TabIndex = 8;
            this.txt_Result.Enter += new System.EventHandler(this.Txt_Result_Enter);
            // 
            // lbl_Result
            // 
            this.lbl_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(98, 139);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(39, 13);
            this.lbl_Result.TabIndex = 9;
            this.lbl_Result.Text = "Return";
            this.lbl_Result.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Calculate.Location = new System.Drawing.Point(143, 104);
            this.btn_Calculate.MaximumSize = new System.Drawing.Size(75, 23);
            this.btn_Calculate.MinimumSize = new System.Drawing.Size(75, 23);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 10;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.Btn_Calculate_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Clear.Location = new System.Drawing.Point(143, 181);
            this.btn_Clear.MaximumSize = new System.Drawing.Size(75, 23);
            this.btn_Clear.MinimumSize = new System.Drawing.Size(75, 23);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssl_Info});
            this.statusStrip1.Location = new System.Drawing.Point(0, 289);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(464, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ssl_Info
            // 
            this.ssl_Info.Name = "ssl_Info";
            this.ssl_Info.Size = new System.Drawing.Size(0, 17);
            // 
            // tab_Calculators
            // 
            this.tab_Calculators.AccessibleName = "";
            this.tab_Calculators.Controls.Add(this.tabPage1);
            this.tab_Calculators.Location = new System.Drawing.Point(42, 21);
            this.tab_Calculators.Name = "tab_Calculators";
            this.tab_Calculators.SelectedIndex = 0;
            this.tab_Calculators.Size = new System.Drawing.Size(378, 254);
            this.tab_Calculators.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_TaxedReturn);
            this.tabPage1.Controls.Add(this.lxl_ReturnTax);
            this.tabPage1.Controls.Add(this.lbl_Investment);
            this.tabPage1.Controls.Add(this.lbl_BuyValue);
            this.tabPage1.Controls.Add(this.btn_Clear);
            this.tabPage1.Controls.Add(this.lbl_Leverage);
            this.tabPage1.Controls.Add(this.btn_Calculate);
            this.tabPage1.Controls.Add(this.lbl_SellValue);
            this.tabPage1.Controls.Add(this.lbl_Result);
            this.tabPage1.Controls.Add(this.txt_Investment);
            this.tabPage1.Controls.Add(this.txt_Result);
            this.tabPage1.Controls.Add(this.txt_BuyValue);
            this.tabPage1.Controls.Add(this.txt_SellValue);
            this.tabPage1.Controls.Add(this.txt_Leverage);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(370, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Retun Calc";
            // 
            // txt_TaxedReturn
            // 
            this.txt_TaxedReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_TaxedReturn.Location = new System.Drawing.Point(190, 155);
            this.txt_TaxedReturn.Name = "txt_TaxedReturn";
            this.txt_TaxedReturn.Size = new System.Drawing.Size(100, 20);
            this.txt_TaxedReturn.TabIndex = 12;
            // 
            // lxl_ReturnTax
            // 
            this.lxl_ReturnTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lxl_ReturnTax.AutoSize = true;
            this.lxl_ReturnTax.Location = new System.Drawing.Point(183, 139);
            this.lxl_ReturnTax.Name = "lxl_ReturnTax";
            this.lxl_ReturnTax.Size = new System.Drawing.Size(118, 13);
            this.lxl_ReturnTax.TabIndex = 11;
            this.lxl_ReturnTax.Text = "Taxed Return (UK only)";
            this.lxl_ReturnTax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "*Mainly for CFD Trading ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 311);
            this.Controls.Add(this.tab_Calculators);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 325);
            this.Name = "Form1";
            this.Text = "Trade Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tab_Calculators.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Investment;
        private System.Windows.Forms.Label lbl_BuyValue;
        private System.Windows.Forms.Label lbl_Leverage;
        private System.Windows.Forms.Label lbl_SellValue;
        private System.Windows.Forms.TextBox txt_Investment;
        private System.Windows.Forms.TextBox txt_BuyValue;
        private System.Windows.Forms.TextBox txt_Leverage;
        private System.Windows.Forms.TextBox txt_SellValue;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ssl_Info;
        private System.Windows.Forms.TabControl tab_Calculators;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_TaxedReturn;
        private System.Windows.Forms.Label lxl_ReturnTax;
        private System.Windows.Forms.Label label1;
    }
}

