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
using System.Runtime.CompilerServices;

namespace ZoomCaption
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        private int Seq { get; set; } = 0;

        private bool IsLegitSeq() => Seq > 0;
        private void ResetSeq() { Seq = 0; }

        private string GetApiKey() => IsLegitApiKey() ? textUrl.Text : "";
        private bool IsLegitApiKey() => textUrl.Text.StartsWith("https://");

        public Form1()
        {
            InitializeComponent();
        }

        private void WriteInnerLog(string message, [CallerMemberName] string callerName = "")
        {
            var now = DateTimeOffset.Now.ToString("u");
            var msg = $"{now} [{callerName}] {message}";
            System.Diagnostics.Debug.WriteLine(msg);
        }

        private void AddLog(string message, [CallerMemberName] string callerName = "")
        {
            var now = DateTimeOffset.Now.ToString("HH:mm:ss.ff");
            textLog.AppendText($"{now} {message}\r\n");
            WriteInnerLog(message, callerName);
        }

        private void OnSuccess()
        {
            textInput.BackColor = SystemColors.Window;
        }

        private void OnFailure(string message)
        {
            textInput.BackColor = Color.Pink;
            AddLog(message);
        }

        private string MakeGetUrl(string apikey)
        {
            return apikey.Replace("/closedcaption?", "/closedcaption/seq?");
        }

        private string MakePostUrl(string apiKey, int seq, string lang = "jp-JP")
        {
            return $"{apiKey}&lang={lang}&seq={seq}";
        }

        private async Task<int> GetSeqAsync(string apiKey)
        {
            try
            {
                var response = await _httpClient.GetAsync(MakeGetUrl(apiKey));
                if (response.IsSuccessStatusCode != true) return -1;
                var message = await response.Content.ReadAsStringAsync();
                if (int.TryParse(message, out int number))
                {
                    return number;
                }
            }
            catch (Exception ex)
            {
                WriteInnerLog(ex.Message);
            }
            return -1;
        }

        private async Task<int> FetchSeq(string apiKey)
        {
            var s = await GetSeqAsync(apiKey);
            return (s >= 0) ? s : 0;
        }

        private async Task<HttpResponseMessage> TrySendMessageAsync(string apiKey, int seq, string message)
        {
            var url = MakePostUrl(apiKey, seq);
            var content = new StringContent(message, Encoding.UTF8);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            return await _httpClient.PostAsync(url, content);
        }

        private async Task<bool> TrySendAsync(string message)
        {
            if (IsLegitApiKey() != true) return false;
            var apiKey = GetApiKey();

            if (IsLegitSeq()) { Seq++; }
            else { Seq = await FetchSeq(apiKey) + 1; }
            var responseTry1 = await TrySendMessageAsync(apiKey, Seq, message);
            if (responseTry1.IsSuccessStatusCode)
            {
                OnSuccess();
                return true;
            }

            Seq = await FetchSeq(apiKey) + 1;
            var responseTry2 = await TrySendMessageAsync(apiKey, Seq, message);
            if (responseTry2.IsSuccessStatusCode)
            {
                OnSuccess();
                return true;
            }
            else
            {
                OnFailure($"[{responseTry2.StatusCode}] {responseTry2.ReasonPhrase}");
                Seq = 0;
                return false;
            }
        }

        private async void textInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && textInput.Text.Length > 0 && IsLegitApiKey())
            {
                var message = textInput.Text;
                textInput.Text = "";
                await TrySendAsync(message);
            }
        }

        private void InsertFKey(TextBox textBox)
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
            if (e.KeyData == Keys.F1) { InsertFKey(textF1); }
            if (e.KeyData == Keys.F2) { InsertFKey(textF2); }
            if (e.KeyData == Keys.F3) { InsertFKey(textF3); }
            if (e.KeyData == Keys.F4) { InsertFKey(textF4); }
            if (e.KeyData == Keys.F5) { InsertFKey(textF5); }
            if (e.KeyData == Keys.F6) { InsertFKey(textF6); }
            if (e.KeyData == Keys.F7) { InsertFKey(textF7); }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetSeq();
        }
    }
}
