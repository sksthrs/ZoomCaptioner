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

        private string ZoomToken { get; set; } = "";

        private string ZoomLog { get; set; } = "";

        private bool IsLegitSeq() => Seq > 0;
        private void ResetSeq() { Seq = 0; }

        private string GetApiKey() => IsLegitApiKey(ZoomToken) ? ZoomToken : "";
        private bool IsLegitApiKey(string key) => key.StartsWith("https://");

        private LineInputDialog inputDialog;
        private Log logDialog;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddLog(string message, [CallerMemberName] string callerName = "")
        {
            var now = DateTimeOffset.Now.ToString("HH:mm:ss.ff");
            ZoomLog += $"{now} {message}" + Environment.NewLine;
        }

        private void UpdateStatusMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                if (IsLegitApiKey(ZoomToken))
                {
                    toolStripStatusLabel.Text = "Zoom字幕送信可能";
                }
                else
                {
                    toolStripStatusLabel.Text = "Zoom APIトークンが未設定です。";
                }
            }
            else
            {
                toolStripStatusLabel.Text = message;
            }
        }

        private void OnSuccess()
        {
            textInput.BackColor = SystemColors.Window;
            UpdateStatusMessage("");
        }

        private void OnFailure(string message)
        {
            textInput.BackColor = Color.Pink;
            AddLog(message);
            UpdateStatusMessage(message);
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
                var msg = "Zoom APIアクセスエラーです。メッセージ:" + ex.Message;
                AddLog(msg);
                UpdateStatusMessage(msg);
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
            var apiKey = GetApiKey();
            if (IsLegitApiKey(apiKey) != true) return false;

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
            if (e.KeyChar == 13 && textInput.Text.Length > 0)
            {
                var message = textInput.Text;
                AddLog(message);
                textInput.Text = "";
                if (IsLegitApiKey(ZoomToken))
                {
                    await TrySendAsync(message);
                }
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

        private void buttonMenu_click(object sender, EventArgs e)
        {
            var x = buttonMenu.Width - contextMenuStrip1.Width;
            var y = buttonMenu.Height;
            contextMenuStrip1.Show(buttonMenu, new Point(x, y));
        }

        private void menuZoomToken_click(object sender, EventArgs e)
        {
            if (inputDialog == null) { inputDialog = new LineInputDialog(); }
            if (inputDialog
                .SetValue(ZoomToken)
                .SetTitle("Zoom APIトークン入力")
                .ShowDialog() == DialogResult.OK)
            {
                if (IsLegitApiKey(inputDialog.Value))
                {
                    ZoomToken = inputDialog.Value;
                    Seq = 0;
                } else
                {
                    MessageBox.Show("APIトークンの形式が不適切です。", "エラー");
                }
            }
            UpdateStatusMessage("");
        }

        private void menuTopMost_CheckStateChanged(object sender, EventArgs e)
        {
            TopMost = menuTopMost.Checked;
        }

        private void menuShowLog_Click(object sender, EventArgs e)
        {
            if (logDialog == null)
            {
                logDialog = new Log();
            }
            logDialog.SetLog(ZoomLog).ShowDialog();
        }

        private void menuFocusInput_click(object sender, EventArgs e)
        {
            textInput.Focus();
        }

        private void menuFocusF1_Click(object sender, EventArgs e)
        {
            textF1.Focus();
        }
    }
}
