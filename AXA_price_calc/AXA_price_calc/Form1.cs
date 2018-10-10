using System;
using System.Windows.Forms;

namespace AXA_price_calc
{
    public partial class Form1 : Form
    {
        double value;

        public Form1()
        {
            InitializeComponent();
            EngineSize_combo.DropDownStyle = ComboBoxStyle.DropDownList; EngineSize_combo.SelectedIndex = 0;
            VAT_combo.DropDownStyle = ComboBoxStyle.DropDownList; VAT_combo.SelectedIndex = 0;
        }

        private void Calculate_btn_Click(object sender, EventArgs e)
        {
            CalcProcedure();

        }
        private void CalcProcedure()
        {
            double price,excise,totalPLN;

            price = Convert.ToDouble(PriceCHF_txt.Text);
            price=price*1.08;//cena po vacie chf

            if (VAT_combo.SelectedItem.ToString().Contains("19"))
            {
                price = price * 1.19;
            }
            else
            {
                price=price*1.23;
            }

            if(EngineSize_combo.SelectedItem.ToString().Contains(">"))
            {
                excise=price*0.18;
            }
            else { excise = price * 0.03; }
            CurrencyConverter cc = new CurrencyConverter("CHF");
            value= cc.GetValue();

            totalPLN = (price + excise + Convert.ToDouble(Pro_txt.Text)) * value + Convert.ToDouble(Transport_txt.Text);
            
            TotalPLNPrice_txt.Text = Math.Round(totalPLN, 2).ToString();
        }

        private void PriceCHF_txt_Leave(object sender, EventArgs e)
        {
            if(Convert.ToDouble(PriceCHF_txt.Text)>5000)
            {
                Pro_txt.Text = (Convert.ToDouble(PriceCHF_txt.Text) / 10).ToString();
            }
            else if (Convert.ToDouble(PriceCHF_txt.Text) <= 5000)
            {
                Pro_txt.Text = "500";
            }
        }
    }
}
