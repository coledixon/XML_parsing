using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML_parseForm
{
    public partial class XMLparser : Form
    {
        public XMLparser()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // validate input has value and is more than 3 chars
            if (!string.IsNullOrEmpty(txtSearch.Text) && txtSearch.Text.Length >= 3)
            {
                // instantiate XML doc
                XmlDocument doc = new XmlDocument();
            }
            else {
                MessageBox.Show("INVALID SEARCH INPUT");
                txtSearch.Text = string.Empty; // reset textbox
                txtSearch.Focus(); // refocus on control
            }
        }
    }
}
