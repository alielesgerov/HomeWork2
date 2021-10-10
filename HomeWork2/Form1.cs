using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_run_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.Dispose();
                Random random = new Random();
                int rndX = random.Next(this.Width - 164);
                int rndY = random.Next(this.Height - 52);
                Button button = new Button
                {
                    Size = new Size(145, 42),
                    Location = new Point(rndX, rndY),
                    Text = "Press Me",
                    Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular)
                };
                button.MouseEnter += btn_run_MouseEnter;
                Controls.Add(button);
            }
        }
    }
}
