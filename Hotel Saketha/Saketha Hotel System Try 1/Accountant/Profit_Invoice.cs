using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saketha_Hotel_System_Try_1.Accountant
{
    public partial class Profit_Invoice : Form
    {
        public Profit_Invoice()
        {
            InitializeComponent();
        }

        private void Profit_Invoice_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
