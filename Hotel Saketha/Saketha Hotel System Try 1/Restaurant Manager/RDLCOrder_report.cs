using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saketha_Hotel_System_Try_1.Restaurant_Manager
{
    public partial class RDLCOrder_report : Form
    {
        public RDLCOrder_report()
        {
            InitializeComponent();
        }

        private void RDLCOrder_report_Load(object sender, EventArgs e)
        {

            this.reportViewer3.RefreshReport();
        }
    }
}
