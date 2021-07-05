using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ZoomCaption
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        public Log SetLog(string log)
        {
            textLog.Text = log;
            textLog.Select(log.Length, 0);
            return this;
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textLog.Text);
            }
        }

        private void menuFileClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
