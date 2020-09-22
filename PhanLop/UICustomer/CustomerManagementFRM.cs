using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanLop.UICustomer
{
    public partial class CustomerManagementFRM : UserControl
    {
        private static CustomerManagementFRM _instance;
        public static CustomerManagementFRM getInstance()
        {
            if (_instance is CustomerManagementFRM && _instance == null)
            {
                _instance = new CustomerManagementFRM();
            }
            return _instance;
        }

        public CustomerManagementFRM()
        {
            InitializeComponent();
        }
    }
}
