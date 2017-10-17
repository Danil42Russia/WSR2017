using System;
using System.Drawing;
using System.Windows.Forms;

namespace WSR2017
{
    public partial class Manager : Form
    {
        private Config config = new Config();
        private NewElements elements = new NewElements();
        private Procedure procedure = new Procedure();

        public Manager()
        {
            InitializeComponent();
            MinimumSize = new Size(config.MinHeight, config.MaxWidth);
            MaximumSize = new Size(config.MaxHeight, config.MaxWidth);
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            Label password_lebel = elements.NewLabel(Width / 2 - 111, Width / 2 - 20, 100, 20, "password_lebel", "Пароль: ", 11);
            Controls.Add(password_lebel);
        }



    }
}
