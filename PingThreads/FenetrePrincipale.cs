using System.DirectoryServices.ActiveDirectory;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace PingThreads
{
    public partial class FenetrePrincipale : Form
    {
        public FenetrePrincipale()
        {
            InitializeComponent();
        }
        public static ListViewItem item;
        private void buttonPing_Click(object sender, EventArgs e)
        {
            tableauResultats.Items.Clear();
            var toTest = textAdresse.Text;

            int pointDeDepart = 0;
            int quantity = Int32.Parse(textBoxQuantite.Text);
            List<IPv4> addresses = new List<IPv4>();

            IPv4 addressStart = new IPv4();
            addressStart.Parse(toTest);
            addressStart.checkParts();

            if (addressStart.ToString() != null && addressStart.part4 != 0)
            {
                addresses.Add(addressStart);
            } else
            {
                quantity = quantity + 1;
            }

            for (int i = 0; i < quantity - 1; i++)
            {
                IPv4 newAddress = new IPv4();
                newAddress.part1 = addressStart.part1;
                newAddress.part2 = addressStart.part2;
                newAddress.part3 = addressStart.part3;
                newAddress.part4 = addressStart.part4 + (i + 1);
                newAddress.checkParts();

                if (newAddress.part4 != 0)
                {
                    addresses.Add(newAddress);
                } else
                {
                    quantity = quantity + 1;
                }
            }


            foreach (IPv4 address in addresses)
            {
                Thread thread = new Thread(() => PingIP(address.ToString()));
                thread.Start();
            }
        }

        private void PingIP(String toTest)
        {
            Ping pingSender = new Ping();
            var item = new ListViewItem(toTest);
            try
            {
                PingReply reply = pingSender.Send(toTest);
                if (reply.Status == IPStatus.Success)
                {
                    item.SubItems.Add(reply.RoundtripTime.ToString() + " ms");
                    
                }
                else
                {
                    item.SubItems.Add("Ping failed " + reply.Status);
                }

            }
            catch (Exception ex)
            {
                item.SubItems.Add("Erreur: " + ex.Message);
            }

            tableauResultats.Invoke(new Action(() =>
            {
                tableauResultats.Items.Add(item);
            }));
        }
    }
}
