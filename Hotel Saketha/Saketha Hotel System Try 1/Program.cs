using Saketha_Hotel_System_Try_1.Accountant;
using Saketha_Hotel_System_Try_1.Director;
using Saketha_Hotel_System_Try_1.Head_Chef;
using Saketha_Hotel_System_Try_1.HR_Manager;
using Saketha_Hotel_System_Try_1.Logistic_Manager;
using Saketha_Hotel_System_Try_1.Reception;
using Saketha_Hotel_System_Try_1.Restaurant_Manager;
using Saketha_Hotel_System_Try_1.Sales_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Profit_Report = Saketha_Hotel_System_Try_1.Accountant.Profit_Report;

namespace Saketha_Hotel_System_Try_1
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

            

    }
}
