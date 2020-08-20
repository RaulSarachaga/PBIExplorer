using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PBIAnalyzer
{
    public partial class Main : Form
    {
        private List<string> ports = null;
        private string [] daxFunctions = null;
        private string selectedPort = null;

        public Main()
        {
            // do nothing
        }

        public Main(List<string> ports, string [] functions) {
            InitializeComponent();
            this.ports = ports;
            daxFunctions = functions;
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            LoadPorts();
        }

        private void LoadPorts()
        {
            cbPorts.Items.AddRange(ports.ToArray());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to close the application?", "PBI Analyzer",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // form will be closed
                // do something here
            }
            else
            {
                // cancel the close event
                e.Cancel = true;
            }
        }

        private void btnConnectPort_Click(object sender, EventArgs e)
        {

            if (selectedPort != null)
            {
                var dbServer = new DBServer(selectedPort);

                if (dbServer.IsReady())
                {

                    Playground newForm = new Playground(dbServer, daxFunctions)
                    {
                        Owner = this
                    };

                    newForm.Show();

                    // hide the current form
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unable to connect to Server", "Server Connection Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select the port to connect", "Port Not Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbPorts.SelectedIndex;
            selectedPort = cbPorts.Items[selectedIndex].ToString();
        }
    }
}
