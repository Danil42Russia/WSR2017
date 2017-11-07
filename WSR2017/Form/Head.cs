using System;
using System.Drawing;
using System.Windows.Forms;

namespace WSR2017
{
    public partial class Head : Form
    {
        private Config config = new Config();
        private NewElements elements = new NewElements();
        private UserLogins user = new UserLogins();

        public Head()
        {
            InitializeComponent();
            MinimumSize = new Size(config.MinHeight, config.MaxWidth);
            MaximumSize = new Size(config.MaxHeight, config.MaxWidth);
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            Button exit = elements.NewBotton(385, 0, 100, 25, "exit_botton", "Выйти", ExitBut_Click);
            Controls.Add(exit);
        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            user.Login = "";
            user.Password = "";
            user.Role = 0;
            Form form_login = new Login();
            form_login.Show();
            Hide();
        }
    }
}
