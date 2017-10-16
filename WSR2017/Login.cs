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

        public Login()
        {
            InitializeComponent();
            MinimumSize = new Size(config.MinHeight, config.MaxWidth);
            MaximumSize = new Size(config.MaxHeight, config.MaxWidth);          
        }

        private void Login_Load(object sender, EventArgs e)
        {
            NewBotton(Width / 2 + 25, Height / 2 + 100 / 2, 100, 25, "button1", "Войти", button1_Click);
            NewTextBox(100, 150, 200, 150, "textbox2", textBox1_TextChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Controls["textbox2"].Text == "ТЕКСТ")
            {
                MessageBox.Show("заза");
            }
            else
            {
                MessageBox.Show("Сам ты " + Controls["textbox2"].Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
