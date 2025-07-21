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
    public partial class Dashboard : Form
    {
        // Instance of the Dashboard class
        static Dashboard _instance;

        // Singleton pattern to ensure only one instance of Dashboard exists
        public static Dashboard Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Dashboard();
                }
                return _instance;
            }
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            _instance = this;
        }
    }
}
