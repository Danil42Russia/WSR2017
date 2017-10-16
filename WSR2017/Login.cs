using System;
using System.Drawing;
using System.Windows.Forms;

namespace WSR2017
{
    public partial class Login : Form
    {
        public override Size MaximumSize { get; set; }
        public override Size MinimumSize { get; set; }

        public Config config = new Config();

        public void NewBotton(int x,int y,int width, int height,string name,string text, EventHandler eventname)
        {
            Button button = new Button();
            button.Location = new Point(x, y);
            button.Name = name;
            button.Size = new Size(width, height);
            button.TabStop = false;
            button.Text = text;
            button.UseVisualStyleBackColor = true;
            button.Click += eventname;
            Controls.Add(button);
        }

        public void NewTextBox(int x, int y, int width, int height, string name, EventHandler eventname)
        {
            TextBox textbox = new TextBox();
            textbox.Location = new Point(x, y);
            textbox.Name = name;
            textbox.Size = new Size(width, height);
            textbox.TabStop = false;
            textbox.TextChanged += eventname;
            Controls.Add(textbox);
        }

        public void NewLabel(int x, int y, int width, int height, string name, string text,int textsize)
        {
            Label label = new Label();
            label.Location = new Point(x, y);
            label.Name = name;
            label.Size = new Size(width, height);
            label.AutoSize = false;
            label.TabStop = false;
            label.Text = text;
            label.Font = new Font(label.Font.Name, textsize, label.Font.Style);
            Controls.Add(label);
        }

        public Login()
        {
            InitializeComponent();
            MinimumSize = new Size(config.MinHeight, config.MaxWidth);
            MaximumSize = new Size(config.MaxHeight, config.MaxWidth);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            NewTextBox(Width/2-50, Width / 2-50, 100, 10, "login_textbox", Login_TextChanged);
            NewLabel(Width / 2-100, Width / 2-50, 100,20, "login_lebel", "Логин: ", 11);

            NewTextBox(Width / 2 - 50, Width / 2 - 20, 100, 10, "password_textbox", Login_TextChanged);
            NewLabel(Width / 2 - 111, Width / 2-20, 100, 20, "password_lebel", "Пароль: ", 11);

            NewBotton(Width / 2 -145 , Height / 2 + 20 / 2, 100, 25, "login_botton", "Войти", LoginBut_Click);
            NewBotton(Width / 2 -45, Height / 2 +20 / 2, 100, 25, "register_botton", "Регистрация", RegisterBut_Click);
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
                MessageBox.Show("dddd");
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
