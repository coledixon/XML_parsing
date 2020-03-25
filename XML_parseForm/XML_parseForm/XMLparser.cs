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
        public bool infoFound; // validate returned XML info

        public XMLparser()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            infoFound = false; // default

            // validate input has value
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                // instantiate XML doc
                XmlDocument doc = new XmlDocument();
                doc.Load("Films.xml");

                // iterate through nodes in file
                foreach (XmlNode node in doc.DocumentElement)
                {
                    string title = node.Attributes[0].InnerText; // name

                    if (title.ToLower() == txtSearch.Text.ToLower()) // compare input val to XML file nodes
                    {
                        infoFound = true;

                        foreach (XmlNode child in node.ChildNodes)
                        {
                            if (child.InnerText.Contains(";"))
                            {
                                child.InnerText = child.InnerText.Replace(";", ", "); // replace semicolon delineation
                            }
                            string output = (child.Name.ToUpper() + " - " + child.InnerText); // format output
                            lvOutput.Items.Add(output); // output to listView
                        }

                        txtSearch.Text = title.ToUpper();
                    }
                }
            }
            else {
                MessageBox.Show("INVALID SEARCH INPUT");
                txtSearch.Text = string.Empty; // reset textbox
                txtSearch.Focus(); // refocus on control
            }

            if (!infoFound)
            {
                MessageBox.Show("FILM NOT CONTAINED IN LIST");
                ClearForm();
            }
        }

        private void ClearForm()
        {
            if (!string.IsNullOrEmpty(txtSearch.Text)) { txtSearch.Text = string.Empty; }
            if (lvOutput.Items.Count > 0) { lvOutput.Clear(); }
        }
    }
}
