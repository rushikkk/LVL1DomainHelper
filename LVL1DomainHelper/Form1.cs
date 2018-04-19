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

namespace LVL1DomainHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            System.Net.IPAddress[] ip = System.Net.Dns.GetHostAddresses(domainName.Text);
            ipAddress.Text = ip[0].ToString();
            var resolver = new DnsStubResolver();
            var mxs = resolver.Resolve<MxRecord>(domainName.Text, RecordType.Mx);
            mxRecord.Text = mxs[0].ToString();
        }
    }
}
