using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARSoft.Tools.Net.Dns;
using IpMatcher;

namespace LVL1DomainHelper
{

    public partial class Form1 : Form
    {
        // Массив с IP-адресами нашего сервера
        String[] okby = new String[6] { "93.84.119.238", "93.84.119.239", "93.84.119.240", "93.84.119.241", "93.84.119.242", "93.84.119.243" };

        //Инициализация объекта Matcher для диапазонов IP hoster.by
        Matcher hosterby = new Matcher();

        int bgclr = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Резолв имени домена
                System.Net.IPAddress[] ip = System.Net.Dns.GetHostAddresses(domainName.Text);

                // Определение вхождения IP-адреса в подсеть и вывод информации в поле 'IP-адрес'
                if (okby.Contains(ip[0].ToString()))
                {
                    ipAddress.Text = ip[0].ToString() + " (наш хостинг)";
                }
                else if (hosterby.MatchExists(ip[0].ToString()))
                {
                    ipAddress.Text = ip[0].ToString() + " (hoster.by)";
                }
                else
                {
                    ipAddress.Text = ip[0].ToString();
                }                
            }
            catch (Exception)
            {
                ipAddress.Clear();
                mxRecord.Clear();
                nsRecords.Clear();
                MessageBox.Show("Введено неверное имя домена или данный домен не существует");
                return;
            }

            // инициализация резолвера ресурсных записей домена
            var resolver = new DnsStubResolver();

            // определение MX-записи домена
            var mxs = resolver.Resolve<MxRecord>(domainName.Text, RecordType.Mx);
            String s1;
            String[] words = { };
            System.Net.IPAddress[] mxip = null;
            if (mxs.Any())
            {
                s1 = mxs[0].ToString();
                words = s1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                // Резолв IP-адреса MX-записи
                mxip = System.Net.Dns.GetHostAddresses(words.Last().TrimEnd('.'));
            }


            

            // Определение вхождения IP-адреса MX-записи в подсеть и вывод информации в поле 'Почта (MX-запись)'
            if (mxs.Any() == false)
            {
                mxRecord.Text = "Почтовые записи отсутствуют";
            }
            else if (okby.Contains(mxip[0].ToString()))
            {
                mxRecord.Text = words.Last().TrimEnd('.') + " (наш хостинг)";
            }
            else if (hosterby.MatchExists(mxip[0].ToString()))
            {
                mxRecord.Text = words.Last().TrimEnd('.') + " hoster.by";
            }
            else
            {
                mxRecord.Text = words.Last().TrimEnd('.');
            }

            // определение NS-записей домена
            var nss = resolver.Resolve<NsRecord>(domainName.Text, RecordType.Ns);

            // вывод NS-записей домена в поле 'DNS-серверы (NS-записи)'
            nsRecords.Clear();
            nss.Sort();
            foreach (NsRecord element in nss)
            {
                s1 = element.ToString();
                String[] wns = s1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                nsRecords.Text += wns.Last().TrimEnd('.') + '\n';
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            domainName.Text = "2kakadu.by";
            hosterby.Add("178.172.136.0", "255.255.248.0");
            hosterby.Add("178.172.160.0", "255.255.252.0");
            hosterby.Add("178.172.201.0", "255.255.255.0");
            hosterby.Add("178.172.244.0", "255.255.255.0");
            hosterby.Add("178.172.250.0", "255.255.255.0");
            hosterby.Add("195.137.160.0", "255.255.255.0");
            hosterby.Add("93.125.99.0", "255.255.255.0");
        }

        private void changeBackground_Click(object sender, EventArgs e)
        {
            if (bgclr == 0)
            {
                this.BackColor = Color.Pink;
                changeBackground.Text = "Сделать нормально";
                bgclr = 1;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                changeBackground.Text = "Сделать красиво";
                bgclr = 0;
            }
            
        }
    }
}
