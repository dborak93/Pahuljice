using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pahuljice
{
    public partial class FrmMain : Form
    {
        List<Snowflake> snowflakes = new List<Snowflake>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Color color = Color.FromName(txtBoja.Text);

            Snowflake snowflake = new Snowflake(color.ToKnownColor(), panel);           
            snowflakes.Add(snowflake);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {         
            foreach (Snowflake item in snowflakes)
            {
                item.Fall();
            }

            snowflakes.RemoveAll(f => f.Bottom >= panel.Height);
            lbNumberOfSnowflakes.Text = snowflakes.Count.ToString();

        }

    }
}
