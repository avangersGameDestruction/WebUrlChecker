using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebUrlChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = ce_ComboBox1.SelectedItem + txtBox1.Text + ce_ComboBox2.SelectedItem;

            if (txtBox1.Text == string.Empty)
            {
                richTextBox1.Text = "please fill in the textbox for looking if a url is valid / in use or not";
            }

            else
            {
                richTextBox1.Text = IsValidURL(url).ToString();

                if (richTextBox1.Text == "True")
                {
                    richTextBox1.Text = txtBox1.Text + " - " + IsValidURL(url).ToString();
                }
            }
        }

        // Check if the url is valid
        private bool IsValidURL(string url)
        {
            Uri uriResult;
            return Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }
    }
}
