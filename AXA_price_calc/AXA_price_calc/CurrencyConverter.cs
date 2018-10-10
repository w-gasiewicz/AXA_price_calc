using System;
using System.Windows.Forms;

namespace AXA_price_calc
{
    public partial class CurrencyConverter : Form
    {
        double value;

        public CurrencyConverter(string currency)
        {
            InitializeComponent();
            if (currency.Equals("CHF"))
                webBrowser1.Navigate("https://www.google.pl/search?ei=YyqiW4WQHYuNrwT6k7vgBQ&q=kurs+franka+szwajcarskiego&oq=kurs+franka+szwajcarskiego&gs_l=psy-ab.3...8836.16202.0.16469.0.0.0.0.0.0.0.0..0.0....0...1c.1.64.psy-ab..0.0.0....0.Tb-1edAOUsQ");//frank
            WaitTillLoad();
            Start();
        }
        private void Start()
        {
            string code = webBrowser1.Document.Body.OuterHtml;

            int start = code.IndexOf("dDoNo vk_bk");
            int end = code.IndexOf(" złotego polskiego");
            string course = code.Substring(start + 13, end - start - 13);

            value = Convert.ToDouble(course);
        }
        private void WaitTillLoad()
        {
            WebBrowserReadyState loadStatus = default(WebBrowserReadyState);
            int waittime = 100000;
            int counter = 0;
            while (true)
            {
                loadStatus = webBrowser1.ReadyState;
                Application.DoEvents();

                if ((counter > waittime) || (loadStatus == WebBrowserReadyState.Uninitialized) || (loadStatus == WebBrowserReadyState.Loading) || (loadStatus == WebBrowserReadyState.Interactive))
                {
                    break;
                }
                counter += 1;
            }
            counter = 0;
            while (true)
            {
                loadStatus = webBrowser1.ReadyState;
                Application.DoEvents();

                if (loadStatus == WebBrowserReadyState.Complete)
                {
                    break;
                }

                counter += 1;
            }
        }
        public double GetValue() { return value; }
    }
}
