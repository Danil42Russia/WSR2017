using System;
using System.Drawing;
using System.Windows.Forms;

namespace WSR2017
{
    public partial class Login : Form
    {
        private Config config = new Config();
        private NewElements elements = new NewElements();
        private SqlQuerry sql = new SqlQuerry();
        private UserLogins user = new UserLogins();

        public Login()
        {
            InitializeComponent();
            MinimumSize = new Size(config.MinHeight, config.MaxWidth);
            MaximumSize = new Size(config.MaxHeight, config.MaxWidth);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TextBox login_textbox = elements.NewTextBox(Width/2-50, Height / 2-50, 100, 10, "login_textbox", Login_TextChanged);
            Label login_lebel = elements.NewLabel(Width / 2-100, Height / 2-50, 100,20, "login_lebel", "Логин: ", 11);
            Controls.Add(login_textbox);
            Controls.Add(login_lebel);

            TextBox password_textbox = elements.NewTextBox(Width / 2 - 50, Height / 2 - 20, 100, 10, "password_textbox", Login_TextChanged);
            Label password_lebel = elements.NewLabel(Width / 2 - 111, Height / 2-20, 100, 20, "password_lebel", "Пароль: ", 11);
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
                MessageBox.Show("Вы не ввели данные");
            else
            {
                //select [dbo].[Roll].[name] From Roll Inner join [User] ON [User].[role] = Roll.ID where [user].ID = 2
                string quarry = String.Format("SELECT [role] FROM [dbo].[User] WHERE [login] = '{0}' AND [password] = '{1}'",
                    Controls["login_textbox"].Text, Controls["password_textbox"].Text);
                string[] outs =  (string[])sql.SQlSelect(quarry, "role");
                if (outs[0] == null)
                    MessageBox.Show("Неправильный логин/Пароль");
                else
                {
                    user.Login = Controls["login_textbox"].Text;          
                    user.Password = Controls["password_textbox"].Text;
                    user.Role = Convert.ToInt32(outs[0]);

                    Form form_customer = new Customer();
                    Form form_manager = new Manager();
                    Form form_storekeeper = new Storekeeper();
                    Form form_head = new Head();
                    switch (Convert.ToInt32(outs[0]))
                    {
                        case 0:
                            form_customer.Show();
                            Hide();
                            break;
                        case 1:
                            form_manager.Show();
                            Hide();
                            break;
                        case 2:
                            form_storekeeper.Show();
                            Hide();
                            break;
                        case 3:
                            form_head.Show();
                            Hide();
                            break;
                        default:
                            MessageBox.Show("Ошибка при открытии формы");
                            break;
                    }
                }
            }
        }
        private void RegisterBut_Click(object sender, EventArgs e)
        {
            if (Controls["login_textbox"].Text.Length == 0 || Controls["password_textbox"].Text.Length == 0)
                MessageBox.Show("Вы не ввели данные");
            else
            {
                string quarry = String.Format("SELECT [login] FROM [dbo].[User] WHERE [login] = '{0}'",
                    Controls["login_textbox"].Text);
                string[] outs = (string[]) sql.SQlSelect(quarry, "login");
                if (outs[0] != null)
                    MessageBox.Show("Такой пользователь уже зарегестрирован!");
                else
                {
                    string quarry_reg = String.Format(
                        "INSERT INTO [dbo].[User] ([login] ,[password] ,[role]) VALUES ('{0}','{1}','0')",
                        Controls["login_textbox"].Text, Controls["password_textbox"].Text);
                    string reg_result = sql.SQLInsertInto(quarry_reg);
                    if (reg_result != null)
                        MessageBox.Show("Вы успешно зарегестрировались");
                    else
                        MessageBox.Show("Ошибка при регистрации");
                }
            }
        }
    }
}