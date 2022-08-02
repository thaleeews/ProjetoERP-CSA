using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaCSA
{
    public partial class FrmSair : Form
    {
        public FrmSair()
        {
            InitializeComponent();
        }

        private void btX_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btSim_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btNao_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
