using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMe
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void catchBtn_MouseEnter(object sender, EventArgs e)
        {
            if(sender is Button bt)
            {
                bt.Dispose();
                Button button = new Button();
                button.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
                button.Text = "Catch Me";
                button.AutoSize = true;
                button.MouseEnter += catchBtn_MouseEnter;
                Random random = new Random();
                int randomX = random.Next(this.Size.Width - 100);
                int randomY = random.Next(this.Size.Height - 100);                
                button.Location = new Point(randomX, randomY);
                this.Controls.Add(button);
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                BackColor = randomColor;
            }
            
        }
    }
}
