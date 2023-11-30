using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhraseNet
{
    public partial class frmStopWord : Form
    {
        public List<string> stopWords = new List<string>();

        public frmStopWord(List<string> _stopWords)
        {
            InitializeComponent();

            this.stopWords = _stopWords;
        }

        private void frmStopWord_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = string.Join(";", stopWords);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.stopWords = this.richTextBox1.Text.Split(';').ToList();
            this.Close();
        }
    }
}
