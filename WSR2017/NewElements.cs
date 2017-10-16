using System;
using System.Drawing;
using System.Windows.Forms;

namespace WSR2017
{
    public class NewElements : Control
    {
        public Button NewBotton(int x, int y, int width, int height, string name, string text, EventHandler eventname)
        {
            Button button = new Button();
            button.Location = new Point(x, y);
            button.Name = name;
            button.Size = new Size(width, height);
            button.TabStop = false;
            button.Text = text;
            button.UseVisualStyleBackColor = true;
            button.Click += eventname;
            return button;
        }

        public TextBox NewTextBox(int x, int y, int width, int height, string name, EventHandler eventname)
        {
            TextBox textbox = new TextBox();
            textbox.Location = new Point(x, y);
            textbox.Name = name;
            textbox.Size = new Size(width, height);
            textbox.TabStop = false;
            textbox.TextChanged += eventname;
            return textbox;
        }

        public Label NewLabel(int x, int y, int width, int height, string name, string text, int textsize)
        {
            Label label = new Label();
            label.Location = new Point(x, y);
            label.Name = name;
            label.Size = new Size(width, height);
            label.AutoSize = false;
            label.TabStop = false;
            label.Text = text;
            label.Font = new Font(label.Font.Name, textsize, label.Font.Style);
            return label;
        }
    }
}