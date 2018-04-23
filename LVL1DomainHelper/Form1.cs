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
        String[] okby = new String[6] { "93.84.119.238", "93.84.119.239", "93.84.119.240", "93.84.119.241", "93.84.119.242", "93.84.119.243" };
        Matcher hosterby = new Matcher();
        


        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            System.Net.IPAddress[] ip = System.Net.Dns.GetHostAddresses(domainName.Text);
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

            var resolver = new DnsStubResolver();

            var mxs = resolver.Resolve<MxRecord>(domainName.Text, RecordType.Mx);
            String s1 = mxs[0].ToString();
            String[] words = s1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            System.Net.IPAddress[] mxip = System.Net.Dns.GetHostAddresses(words.Last().TrimEnd('.'));
            if (okby.Contains(mxip[0].ToString()))
            {
                mxRecord.Text = words.Last().TrimEnd('.') + " (наш хостинг)";
            }
            else if (hosterby.MatchExists(mxip[0].ToString()))  {
                mxRecord.Text = words.Last().TrimEnd('.') + " hoster.by";
            }
            else
            {
                mxRecord.Text = words.Last().TrimEnd('.');
            }

            var nss = resolver.Resolve<NsRecord>(domainName.Text, RecordType.Ns);

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
            hosterby.Add("93.125.99.0", "255.255.255.0");
        }
    }
}
