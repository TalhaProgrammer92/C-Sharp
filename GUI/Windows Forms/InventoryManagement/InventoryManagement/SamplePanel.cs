using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class SamplePanel : Form
    {
        public SamplePanel()
        {
            InitializeComponent();

            // Initialize the Sample form
            if (!DesignMode)
            {
                msg_dialog.Parent = Dashboard.Instance;
            }
        }

        private void Sample_Load(object sender, EventArgs e)
        {

        }
    }
}
