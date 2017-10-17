using System;
using System.Drawing;
using System.Windows.Forms;

namespace WSR2017
{
    public partial class Login : Form
    {
        private Config config = new Config();
        private NewElements elements = new NewElements();
        private Procedure procedure = new Procedure();

        public Login()
        {
            InitializeComponent();
            MinimumSize = new Size(config.MinHeight, config.MaxWidth);
            MaximumSize = new Size(config.MaxHeight, config.MaxWidth);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TextBox login_textbox = elements.NewTextBox(Width/2-50, Width / 2-50, 100, 10, "login_textbox", Login_TextChanged);
            Label login_lebel = elements.NewLabel(Width / 2-100, Width / 2-50, 100,20, "login_lebel", "Логин: ", 11);
            Controls.Add(login_textbox);
            Controls.Add(login_lebel);

            TextBox password_textbox = elements.NewTextBox(Width / 2 - 50, Width / 2 - 20, 100, 10, "password_textbox", Login_TextChanged);
            Label password_lebel = elements.NewLabel(Width / 2 - 111, Width / 2-20, 100, 20, "password_lebel", "Пароль: ", 11);
            Controls.Add(password_textbox);
            Controls.Add(password_lebel);

            Button login_botton = elements.NewBotton(Width / 2 - 145, Height / 2 + 20 / 2, 100, 25, "login_botton", "Войти", LoginBut_Click);
            Button register_botton = elements.NewBotton(Width / 2 - 45, Height / 2 + 20 / 2, 100, 25, "register_botton", "Регистрация", RegisterBut_Click);
            Controls.Add(login_botton);
            Controls.Add(register_botton);
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
        }
        private void Register_TextChanged(object sender, EventArgs e)
        {
        }
        private void LoginBut_Click(object sender, EventArgs e)
        {
            if (Controls["login_textbox"].Text.Length == 0 || Controls["password_textbox"].Text.Length == 0)
            {
                MessageBox.Show("Пусто");
            }
            else
            {
                switch (Controls["login_textbox"].Text)
                {
                    case "danil":
                        Form form_manager = new Manager();
                        form_manager.Show();
                        Hide();
                        break;
                    case "danil2":
                        Form form_customer = new Customer();
                        form_customer.Show();
                        Hide();
                        break;
                    default:
                        MessageBox.Show("Я не знаю таких даееых");
                        break;
                }
            }
        }
        private void RegisterBut_Click(object sender, EventArgs e)
        {
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
