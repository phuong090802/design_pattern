using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreationalDesignPattern.Refactoring.FactoryMethod
{
    public class WindowsButton : IButton
    {
        Form form = new Form();
        Panel panel = new Panel();
        Button button = new Button();
        public void OnClick()
        {
            button = new Button();
            button.Text = "Exit";
            button.AutoSize = true;
            button.Dock = DockStyle.Bottom;
            button.Click += new System.EventHandler(Button_Click);
        }

        public void render()
        {
            Label label = new Label();
            label.Text = "Hello World!";
            label.BackColor = System.Drawing.Color.Gold;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20, System.Drawing.FontStyle.Bold);
            label.AutoSize = true;
            label.Dock = DockStyle.Top;
            form.Controls.Add(panel);
            OnClick();
            panel.Controls.Add(button);
            panel.Controls.Add(label);
            form.ClientSize = new System.Drawing.Size(320, 200);
            Application.Run(form);
            OnClick();

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
