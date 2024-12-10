using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PingThreads
{
    public class IPv4
    {
        public int part1 { get; set; }
        public int part2 { get; set; }
        public int part3 { get; set; }
        public int part4 { get; set; }

        public override String ToString()
        {
            if (checkParts())
            {
                return (part1 + "." + part2 + "." + part3 + "." + part4);
            } else
            {
                return null;
            }
        }

        public void Parse(string adresse)
        {
            if (!TestIp(adresse))
            {
                MessageBox.Show("Adresse incorecte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                String[] strParts = adresse.Split(new char[] { '.' });
                for (int i = 0; i < strParts.Length; i++)
                {
                    switch(i)
                    {
                        case 0:
                            part1 = Convert.ToInt32(strParts[i]);
                            break;
                        case 1:
                            part2 = Convert.ToInt32(strParts[i]);
                            break;              
                        case 2:
                            part3 = Convert.ToInt32(strParts[i]);
                            break;
                        case 3:
                            part4 = Convert.ToInt32(strParts[i]);
                            break;
                    }
                }
            }
        }

        public bool checkParts()
        {

            if (part4 > 254)
            {
                int switches = part4 / 255;
                part3 = part3 + (part4 / 255);
                part4 = part4 - (255 * switches);
            }

            if (part3 > 254)
            {
                int switches = part3 / 255;
                part2 = part2 + (part3 / 255);
                part3 = part3 - (255 * switches);
            }
            if (part2 > 254)
            {
                int switches = part2 / 255;
                part1 = part1 + (part2 / 255);
                part2 = part2 + switches - (255 * switches);
            }

            if (part1 > 254)
            {
                MessageBox.Show("Adresse incorecte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool TestIp(string toTest)
        {
            string pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            bool isValid = Regex.IsMatch(toTest, pattern);
            return isValid;
        }
    }
}
