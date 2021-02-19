using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ZoomCaption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addLog(string message)
        {
            textLog.AppendText(message + "\r\n");
        }

        private string makeUrl()
        {
            var c = 0;
            var count = int.TryParse(textSeq.Text, out c) ? c : 0;
            count++;
            var countStr = count.ToString();
            textSeq.Text = countStr;
            return textUrl.Text + "&lang=jp-JP&seq=" + countStr;
        }

        private async void sendMessage(string message)
        {
            textInput.Text = "";
            var content = new StringContent(message, Encoding.UTF8);
            var url = makeUrl();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    textInput.BackColor = SystemColors.Window;
                }
                else
                {
                    textInput.BackColor = Color.Pink;
                    addLog("[" + response.StatusCode.ToString() + "] " 
                        + response.ReasonPhrase);
                }
            }
        }

        private void textInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && textInput.Text.Length > 0 && textUrl.Text.Length > 0)
            {
                sendMessage(textInput.Text);
            }
        }

        private void insertFKey(TextBox textBox)
        {
            var ins = textBox.Text;
            if (ins.Length < 1) return;
            var start = textInput.SelectionStart;
            var len = textInput.SelectionLength;
            var newText = textInput.Text.Substring(0, start)
                + ins
                + textInput.Text.Substring(start + len);
            textInput.Text = newText;
            textInput.SelectionStart = start + ins.Length;
        }

        private void Parenthesize(string before, string after)
        {
            var len = textInput.Text.Length;
            textInput.Text = before + textInput.Text + after;
            textInput.SelectionStart = len + before.Length;
        }

        private void textInput_KeyDown(object sender, KeyEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("keyData:" + e.KeyData.ToString());
            if (e.KeyData == Keys.F1) { insertFKey(textF1); }
            if (e.KeyData == Keys.F2) { insertFKey(textF2); }
            if (e.KeyData == Keys.F3) { insertFKey(textF3); }
            if (e.KeyData == Keys.F4) { insertFKey(textF4); }
            if (e.KeyData == Keys.F5) { insertFKey(textF5); }
            if (e.KeyData == Keys.F6) { insertFKey(textF6); }
            if (e.KeyData == Keys.F7) { insertFKey(textF7); }
            if (e.KeyData == Keys.F8)
            {
                Parenthesize("「", "」");
            }
            if (e.KeyData == (Keys.F8 | Keys.Shift))
            {
                Parenthesize("（", "）");
            }
            if (e.KeyData == Keys.Escape)
            {
                textInput.Text = "";
            }
        }
    }
}
