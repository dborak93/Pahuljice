using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pahuljice
{
    public partial class Snowflake : UserControl
    {
        Random random = new Random();

        public Snowflake(KnownColor color,Panel panel)
        {
            InitializeComponent();

            this.Size = new Size(10, 10);
            this.BackColor = Color.FromKnownColor(color);
            
            int x = random.Next(0, panel.Width);
            this.Location = new Point(x, 0);

            panel.Controls.Add(this);
        }

        public void Fall()
        {
            int broj =  random.Next(1, 5);
            this.Top += broj;
        }
    }
}
