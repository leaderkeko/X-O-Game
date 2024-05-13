using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_Game
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnoneplayer_Click(object sender, EventArgs e)
        {
            Frm_OnePlayer frm = new Frm_OnePlayer();
            frm.Show();
            this.Hide();

        }

        private void btntwoplayer_Click(object sender, EventArgs e)
        {
            Frm_TwoPlayer frm = new Frm_TwoPlayer();
            frm.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
