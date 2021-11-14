using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebUrlChecker
{
    public partial class Form1 : Form
    {

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = ce_ComboBox1.SelectedItem + txtBox1.Text + ce_ComboBox2.SelectedItem;

            progressBar1.Value = 0;

            if (txtBox1.Text == string.Empty)
            {
                richTextBox1.Text = "please fill in the textbox for looking if a url is valid / in use or not";
            }

            else
            {
                if (progressBar1.Value == 0)
                {
                    progressBar1.Value += 10;

                    if (progressBar1.Value > 100)
                    {
                        richTextBox1.Text = IsValidURL(url).ToString();

                        if (richTextBox1.Text == "True")
                        {
                            richTextBox1.Text = txtBox1.Text + " - " + IsValidAndReachable(url).ToString();
                        }

                        else if (richTextBox1.Text == "False")
                        {
                            richTextBox1.Text = txtBox2.Text + " - " + IsValidAndReachable(url).ToString();
                        }

                        else
                        {
                            richTextBox1.Text = "something did go wrong please report the isseu or try again";
                        }
                    }
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

        private bool IsValidAndReachable(string url)
        {
            if (IsValidURL(url))
            {
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    request.Timeout = 5000;
                    request.Method = "HEAD";
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    return response.StatusCode == HttpStatusCode.OK;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("true means its already in use false mean its not in use on the internet created by avangers MIT license", "Web Url Checker");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fullurl = txtBox2.Text;

            progressBar1.Value = 0;

            if (txtBox2.Text == string.Empty)
            {
                richTextBox1.Text = "please fill in the textbox for looking if a url is valid / in use or not";
            }

            else
            {
                if (progressBar1.Value == 0)
                {
                    if (progressBar1.Value > 100)
                    {
                        richTextBox1.Text = IsValidURL(fullurl).ToString();

                        if (richTextBox1.Text == "True")
                        {
                            richTextBox1.Text = txtBox1.Text + " - " + IsValidAndReachable(fullurl).ToString();
                        }

                        else if (richTextBox1.Text == "False")
                        {
                            richTextBox1.Text = txtBox2.Text + " - " + IsValidAndReachable(fullurl).ToString();
                        }

                        else
                        {
                            richTextBox1.Text = "something did go wrong please report the isseu or try again";
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
