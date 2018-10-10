namespace AXA_price_calc
{
    partial class Form1
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
            this.Calculate_btn.Location = new System.Drawing.Point(145, 159);
            this.Calculate_btn.Name = "Calculate_btn";
            this.Calculate_btn.Size = new System.Drawing.Size(75, 23);
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
            this.TotalPLNPrice_txt.Location = new System.Drawing.Point(145, 188);
            this.TotalPLNPrice_txt.Name = "TotalPLNPrice_txt";
            this.TotalPLNPrice_txt.ReadOnly = true;
            this.TotalPLNPrice_txt.Size = new System.Drawing.Size(121, 22);
            this.TotalPLNPrice_txt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cena w Polsce PLN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 240);
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
            this.MaximumSize = new System.Drawing.Size(382, 287);
            this.MinimumSize = new System.Drawing.Size(382, 287);
            this.Name = "Form1";
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
    }
}

