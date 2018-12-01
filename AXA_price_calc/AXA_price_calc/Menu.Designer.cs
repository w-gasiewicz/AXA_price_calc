namespace AXA_price_calc
{
    partial class Menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.EngineSize_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceCHF_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VAT_combo = new System.Windows.Forms.ComboBox();
            this.Calculate_btn = new System.Windows.Forms.Button();
            this.Transport_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pro_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalPLNPrice_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.VAT_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Provision_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CalSwissVAT_check = new System.Windows.Forms.CheckBox();
            this.CHFPrice_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.SwissVATValue_txt = new System.Windows.Forms.TextBox();
            this.Excise_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pojemność silnika";
            // 
            // EngineSize_combo
            // 
            this.EngineSize_combo.FormattingEnabled = true;
            this.EngineSize_combo.Items.AddRange(new object[] {
            "<2000cm3",
            ">2000cm3"});
            this.EngineSize_combo.Location = new System.Drawing.Point(145, 12);
            this.EngineSize_combo.Name = "EngineSize_combo";
            this.EngineSize_combo.Size = new System.Drawing.Size(121, 24);
            this.EngineSize_combo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cena [CHF]";
            // 
            // PriceCHF_txt
            // 
            this.PriceCHF_txt.Location = new System.Drawing.Point(145, 42);
            this.PriceCHF_txt.Name = "PriceCHF_txt";
            this.PriceCHF_txt.Size = new System.Drawing.Size(121, 22);
            this.PriceCHF_txt.TabIndex = 3;
            this.PriceCHF_txt.Leave += new System.EventHandler(this.PriceCHF_txt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "VAT";
            // 
            // VAT_combo
            // 
            this.VAT_combo.FormattingEnabled = true;
            this.VAT_combo.Items.AddRange(new object[] {
            "19%",
            "23%"});
            this.VAT_combo.Location = new System.Drawing.Point(145, 73);
            this.VAT_combo.Name = "VAT_combo";
            this.VAT_combo.Size = new System.Drawing.Size(121, 24);
            this.VAT_combo.TabIndex = 5;
            // 
            // Calculate_btn
            // 
            this.Calculate_btn.Location = new System.Drawing.Point(142, 342);
            this.Calculate_btn.Name = "Calculate_btn";
            this.Calculate_btn.Size = new System.Drawing.Size(75, 28);
            this.Calculate_btn.TabIndex = 6;
            this.Calculate_btn.Text = "Oblicz";
            this.Calculate_btn.UseVisualStyleBackColor = true;
            this.Calculate_btn.Click += new System.EventHandler(this.Calculate_btn_Click);
            // 
            // Transport_txt
            // 
            this.Transport_txt.Location = new System.Drawing.Point(145, 103);
            this.Transport_txt.Name = "Transport_txt";
            this.Transport_txt.Size = new System.Drawing.Size(121, 22);
            this.Transport_txt.TabIndex = 8;
            this.Transport_txt.Text = "2000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Transport [ZŁ]";
            // 
            // Pro_txt
            // 
            this.Pro_txt.Cursor = System.Windows.Forms.Cursors.No;
            this.Pro_txt.Location = new System.Drawing.Point(145, 131);
            this.Pro_txt.Name = "Pro_txt";
            this.Pro_txt.ReadOnly = true;
            this.Pro_txt.Size = new System.Drawing.Size(121, 22);
            this.Pro_txt.TabIndex = 10;
            this.Pro_txt.Text = "500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Prowizja [CHF]";
            // 
            // TotalPLNPrice_txt
            // 
            this.TotalPLNPrice_txt.Cursor = System.Windows.Forms.Cursors.No;
            this.TotalPLNPrice_txt.Location = new System.Drawing.Point(145, 159);
            this.TotalPLNPrice_txt.Name = "TotalPLNPrice_txt";
            this.TotalPLNPrice_txt.ReadOnly = true;
            this.TotalPLNPrice_txt.Size = new System.Drawing.Size(121, 22);
            this.TotalPLNPrice_txt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cena w Polsce PLN";
            // 
            // VAT_txt
            // 
            this.VAT_txt.Cursor = System.Windows.Forms.Cursors.No;
            this.VAT_txt.Location = new System.Drawing.Point(145, 187);
            this.VAT_txt.Name = "VAT_txt";
            this.VAT_txt.ReadOnly = true;
            this.VAT_txt.Size = new System.Drawing.Size(121, 22);
            this.VAT_txt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "VAT";
            // 
            // Provision_txt
            // 
            this.Provision_txt.Cursor = System.Windows.Forms.Cursors.No;
            this.Provision_txt.Location = new System.Drawing.Point(145, 215);
            this.Provision_txt.Name = "Provision_txt";
            this.Provision_txt.ReadOnly = true;
            this.Provision_txt.Size = new System.Drawing.Size(121, 22);
            this.Provision_txt.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Prowizja";
            // 
            // CalSwissVAT_check
            // 
            this.CalSwissVAT_check.AutoSize = true;
            this.CalSwissVAT_check.Location = new System.Drawing.Point(10, 315);
            this.CalSwissVAT_check.Name = "CalSwissVAT_check";
            this.CalSwissVAT_check.Size = new System.Drawing.Size(207, 21);
            this.CalSwissVAT_check.TabIndex = 17;
            this.CalSwissVAT_check.Text = "Czy wliczać VAT szwajcarski";
            this.CalSwissVAT_check.UseVisualStyleBackColor = true;
            this.CalSwissVAT_check.CheckedChanged += new System.EventHandler(this.CalSwissVAT_check_CheckedChanged);
            // 
            // CHFPrice_txt
            // 
            this.CHFPrice_txt.Cursor = System.Windows.Forms.Cursors.No;
            this.CHFPrice_txt.Location = new System.Drawing.Point(159, 243);
            this.CHFPrice_txt.Name = "CHFPrice_txt";
            this.CHFPrice_txt.ReadOnly = true;
            this.CHFPrice_txt.Size = new System.Drawing.Size(107, 22);
            this.CHFPrice_txt.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Dzisiejszy kurs franka";
            // 
            // Reset_btn
            // 
            this.Reset_btn.Location = new System.Drawing.Point(223, 342);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(75, 28);
            this.Reset_btn.TabIndex = 20;
            this.Reset_btn.Text = "Resetuj";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // SwissVATValue_txt
            // 
            this.SwissVATValue_txt.Cursor = System.Windows.Forms.Cursors.No;
            this.SwissVATValue_txt.Location = new System.Drawing.Point(223, 313);
            this.SwissVATValue_txt.Name = "SwissVATValue_txt";
            this.SwissVATValue_txt.ReadOnly = true;
            this.SwissVATValue_txt.Size = new System.Drawing.Size(107, 22);
            this.SwissVATValue_txt.TabIndex = 21;
            // 
            // Excise_txt
            // 
            this.Excise_txt.Cursor = System.Windows.Forms.Cursors.No;
            this.Excise_txt.Location = new System.Drawing.Point(145, 271);
            this.Excise_txt.Name = "Excise_txt";
            this.Excise_txt.ReadOnly = true;
            this.Excise_txt.Size = new System.Drawing.Size(121, 22);
            this.Excise_txt.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Akcyza";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 383);
            this.Controls.Add(this.Excise_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SwissVATValue_txt);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.CHFPrice_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CalSwissVAT_check);
            this.Controls.Add(this.Provision_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VAT_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalPLNPrice_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Pro_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Transport_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Calculate_btn);
            this.Controls.Add(this.VAT_combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceCHF_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EngineSize_combo);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(382, 287);
            this.Name = "Menu";
            this.Text = "Kalkulator ceny auta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EngineSize_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceCHF_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox VAT_combo;
        private System.Windows.Forms.Button Calculate_btn;
        private System.Windows.Forms.TextBox Transport_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Pro_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalPLNPrice_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox VAT_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Provision_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CalSwissVAT_check;
        private System.Windows.Forms.TextBox CHFPrice_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.TextBox SwissVATValue_txt;
        private System.Windows.Forms.TextBox Excise_txt;
        private System.Windows.Forms.Label label10;
    }
}

