using System;
using System.Windows.Forms;

namespace AXA_price_calc
{
    public partial class Menu : Form
    {
        double value;
        bool calcSwissVAT = false;

        public Menu()
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
            double price,excise,totalPLN,vat;

            CurrencyConverter cc = new CurrencyConverter("CHF");
            value = cc.GetValue();
            price = Convert.ToDouble(PriceCHF_txt.Text);
            vat = price;

            if (calcSwissVAT)
            {
                price = price * 1.08;//cena po vacie chf
                SwissVATValue_txt.Text = Math.Round(((price - vat) * value), 2).ToString();
            }

            if (VAT_combo.SelectedItem.ToString().Contains("19"))
            {
                price = price * 1.19;
            }
            else
            {
                price=price*1.23;
            }      

            if (EngineSize_combo.SelectedItem.ToString().Contains(">"))
            {
                excise=price*0.18;
            }
            else { excise = price * 0.03; }
            Excise_txt.Text = Math.Round(excise*value, 2).ToString();
            VAT_txt.Text = Math.Round((price - vat) * value, 2).ToString();

            totalPLN = (price + excise + Convert.ToDouble(Pro_txt.Text)) * value + Convert.ToDouble(Transport_txt.Text);
            double provision = (value * Convert.ToDouble(Pro_txt.Text));
            Provision_txt.Text = Math.Round(provision,2).ToString();
            CHFPrice_txt.Text = Math.Round(value,2).ToString();
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

        private void CalSwissVAT_check_CheckedChanged(object sender, EventArgs e)
        {
            if (CalSwissVAT_check.Checked)
                calcSwissVAT = true;
            else
            {
                calcSwissVAT = false;
                SwissVATValue_txt.Clear();
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            try
            {
                PriceCHF_txt.Clear();
                Provision_txt.Clear();
                CHFPrice_txt.Clear();
                TotalPLNPrice_txt.Clear();
                VAT_txt.Clear();
                SwissVATValue_txt.Clear();
                Excise_txt.Clear();
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
