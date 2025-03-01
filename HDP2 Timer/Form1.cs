using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDP2_Timer
{
    public partial class FormREIZ : Form
    {
        public FormREIZ()
        {
            InitializeComponent();
        }

        private void ButtDesplazar_Click(object sender, EventArgs e)
        {
            TmrDesplazar.Enabled = true;
        }
        int X = 0;
        bool rebote = true;
        private void TmrDesplazar_Tick(object sender, EventArgs e)
        {
            ElrashoPng.Location = new Point(X, 12);

            if (rebote)
            {
                X += 15;

            }
            else
            {
                X -= 15;
            }

            if (X >= this.Size.Width - ElrashoPng.Width)
            {
                rebote = false;
            }

            if (X <= 10)
            {
                rebote |= true;
            }
        }

        private void FormREIZ_Load(object sender, EventArgs e)
        {

        }
    }
}
