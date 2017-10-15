using System.Drawing;
using System.Windows.Forms;

namespace WSR2017
{
    public class NewElements : Control
    {
        public void NewBotton(int x, int y, int width, int height, string name, string text)
        {
            Button button = new Button();
            button.Location = new Point(x, y);
            button.Name = name;
            button.Size = new Size(width, height);
            button.TabStop = false;
            button.Text = text;
            button.UseVisualStyleBackColor = true;
            Controls.Add(button);
        }
    }
}