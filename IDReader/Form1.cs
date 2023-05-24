using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDReader
{
    public partial class frmIDReader : Form
    {
        public frmIDReader()
        {
            InitializeComponent();
        }

        private void btnClickHere_Click(object sender, EventArgs e)
        {
            lbClickHere.Text = "Hello World!";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
