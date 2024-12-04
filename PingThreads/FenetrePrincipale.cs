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

            if (!TestIp(toTest))
            {
                MessageBox.Show("Adresse Incorrecte.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int pointDeDepart = 0;
            int quantity = Int32.Parse(textBoxQuantite.Text);
            List<String> addresses = new List<String>();
            addresses.Add(toTest);

            for (int i = 0; i < quantity - 1; i++)
            {
                String[] partiesAddresse;
                partiesAddresse = toTest.Split(".");
                pointDeDepart = Int32.Parse(partiesAddresse[partiesAddresse.Length - 1]);
                String nouveauAdresse = partiesAddresse[0] + "." + partiesAddresse[1] + "." + partiesAddresse[2] + "." + (pointDeDepart + (i + 1));
                addresses.Add(nouveauAdresse);
            }


            foreach (String address in addresses)
            {
                Thread thread = new Thread(() => PingIP(address));
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

        private bool TestIp(string toTest)
        {
            string pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            bool isValid = Regex.IsMatch(toTest, pattern);
            return isValid;
        }
    }
}
