using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Division42.NetworkTools;

namespace NirSoftNetTools
{
    public partial class MainForm : Form
    {
        private static string whois = "";
        private static string domain = "";
        int counter = 0;    // порядковый номер

        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            WhoisResult_TextBox.Clear();
            WhoisResult_TextBox.Text = WhoisService.WhoIs(domainName_TextBox.Text);
        }

        private void TraceRoute_Button_Click(object sender, EventArgs e)
        {
            string[] buffer = new string[TR_ListView.Columns.Count];
            int counter = 1;
            foreach (var info in TraceRoute.GetTraceRoute(TR_InputTextBox.Text))
            {
                buffer[0] = counter++.ToString();
                buffer[1] = info.ElapsedTime.ToString();
                buffer[2] = info.IP.ToString();
                buffer[3] = info.Domain.ToString();
                TR_ListView.Items.Add(new ListViewItem(buffer));
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string mac = textBox3.Text;
            textBox4.Text = VendorMAC.VendMAC(mac);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string Number = textBox5.Text;
            textBox6.Text = Operator.OpMobNUM(Number);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            string BIN = textBox8.Text;
            string[] res = BINCARD.BankByBIN(BIN);
            textBox7.Text += "Платёжная система: " + res[0] + Environment.NewLine;
            textBox7.Text += "Страна: " + res[1] + Environment.NewLine;
            textBox7.Text += "Банк: " + res[2] + Environment.NewLine;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string Number = textBox5.Text;
            textBox6.Text = Operator.OpNUM(Number); // test
        }

        private void Resolver_Button_Click(object sender, EventArgs e)
        {
            string data = Resolver_TextBox.Text;
        }

        private void IMEI_button_Click(object sender, EventArgs e)
        {
            string IMEI = IMEI_input_tb.Text;
            IMEI_output_tb.Text = VendorIMEI.LookupIMEI(IMEI);
        }
    }
}
