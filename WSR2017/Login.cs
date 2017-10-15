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

        public Login()
        {
            InitializeComponent();
            MinimumSize = new Size(config.MinHeight, config.MaxWidth);
            MaximumSize = new Size(config.MaxHeight, config.MaxWidth);
            NewBotton(Width/2+25, Height/2+100 / 2, 100, 25,"button1","Я кнопка!", button1_Click);
            NewBotton(Width / 2-20, Height / 2-50, 100, 25, "button2", "Я 2 кнопка!", button2_Click);
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            NewBotton(Width / 2, Height / 2, 100, 25, "button3", "Я 3 кнопка!", button3_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я кнопка");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я 2 кнопка");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я 3 кнопка");
        }
    }
}
