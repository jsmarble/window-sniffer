using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowSniffer
{
    public partial class TextInputForm : Form
    {
        public TextInputForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public TextInputForm(string initialText)
            : this()
        {
            textBox1.Text = initialText;
        }

        public string InputText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
