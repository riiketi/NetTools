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
            domain = domainName_TB.Text;    // Доменное имя введённое в текстбокс
            string whoisResult = WhoisService.WhoIs(domain);
            result_TB.Text = whoisResult;


            // Добавляем элемент в таблицу////////////////
            string[] element = new string[21];

            element[0] = counter.ToString();    // Индекс
            element[1] = System.Net.Dns.GetHostEntry(domain).AddressList[0].ToString(); // IP адрес
            if (domain == "") // Статус
                element[2] = "Unexpected error occured!";
            else
                element[2] = "Succeed";

            ListViewItem item = new ListViewItem(element);
            listView1.Items.Add(item);
            //////////////////////////////////////////////
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string hostname = textBox1.Text;
            string Result = TraceRoute.Traceroute(hostname);
            textBox2.Text = Result;
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
    }
}
