using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoomCaption
{
    public partial class LineInputDialog : Form
    {
        public string Value { get => textBoxValue.Text; }

        public LineInputDialog()
        {
            InitializeComponent();
        }

        public LineInputDialog SetValue(string value)
        {
            textBoxValue.Text = value;
            return this;
        }

        public LineInputDialog SetTitle(string title)
        {
            Text = title;
            return this;
        }

        private void textBoxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
