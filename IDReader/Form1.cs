using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDReader
{
    public partial class frmIDReader : Form
    {
        DataInput input;
        DataSearch searcher;
        DataTable data;

        public frmIDReader()
        {
            InitializeComponent();
            input = new DataInput();
            searcher = new DataSearch();
            data = new DataTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            rtbResult.ForeColor = Color.Black;
            tbcText.SelectedIndex = 0;
            rtbResult.Text = searcher.SearchForID(data, tbSearch.Text);
            if(rtbResult.Text.Contains("Not Found")) { rtbResult.ForeColor = Color.Red; }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lbStatus.Text = input.GetFile();
            if(!lbStatus.Text.Contains("Loaded"))
            {
                btnSearch.Enabled = false;
                tbSearch.Enabled = false;
                return;
            }
            data = input.GetData();
            btnSearch.Enabled = true;
            tbSearch.Enabled = true;
            rtbResult.ForeColor = Color.Black;
            tbcText.SelectedIndex = 1;
            //for debugging, delete this later
            var writer = new StringWriter();
            data.WriteXml(writer);
            rtbRaw.Text = writer.ToString();
        }
    }
}
