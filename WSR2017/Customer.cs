using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR2017
{
    public partial class Customer : Form
    {
        private Config config = new Config();
        private NewElements elements = new NewElements();
        private Procedure procedure = new Procedure();

        public Customer()
        {
            InitializeComponent();
            MinimumSize = new Size(config.MinHeight, config.MaxWidth);
            MaximumSize = new Size(config.MaxHeight, config.MaxWidth);
        }
        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
