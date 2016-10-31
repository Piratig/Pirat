using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        Random rnd;
        char[] specialsymbols_char = new char[] {'%','*',')','?','#','$','^','&','~' };

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password Generator: Generates passwords and saves them. \n Author: Kharkovskiy Igor.");
        }

        private void btnGenerates_Click(object sender, EventArgs e)
        {
            if (chlbGenerator.CheckedItems.Count == 0) return;
            string password = "";
            for (int i = 0; i < nudLength.Value; i++)
            {
                int n = rnd.Next(0, chlbGenerator.CheckedItems.Count);
                string s = chlbGenerator.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Lowercase": password += Convert.ToChar(rnd.Next(97,122));
                        break;
                    case "Uppercase": password += Convert.ToChar(rnd.Next(65, 90));
                        break;
                    case "Numbers": password += rnd.Next(10).ToString();
                        break;
                   
                    default:
                        password += specialsymbols_char[rnd.Next(specialsymbols_char.Length)];
                            break;
                }
                txbPassword.Text = password;
            }
        }
    }
}
