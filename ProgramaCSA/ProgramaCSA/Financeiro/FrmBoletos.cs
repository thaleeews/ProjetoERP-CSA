using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaCSA.Financeiro
{
    public partial class FrmBoletos : Form
    {
        public FrmBoletos()
        {
            InitializeComponent();
        }

        #region configurações basicas
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btX_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        private Form activeForm = null;

        private void abrirForm(Form formNovo)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formNovo;
            formNovo.TopLevel = false;
            formNovo.FormBorderStyle = FormBorderStyle.None;
            formNovo.Dock = DockStyle.Fill;
            pFormRecb.Controls.Add(formNovo);
            pFormRecb.Tag = formNovo;
            formNovo.BringToFront();
            formNovo.Show();
        }

        private void btAprovar_Click(object sender, EventArgs e)
        {
            abrirForm(new FrmAprovacao());
        }
    }
}
