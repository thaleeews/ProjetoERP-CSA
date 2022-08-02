﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProgramaCSA.Estoque
{
    public partial class FrmFiltro : Form
    {
        public FrmFiltro()
        {
            InitializeComponent();
        }

        #region configurações primárias
        private void mtxt_Click(object sender, EventArgs e)
        {
            MaskedTextBox mascara = sender as MaskedTextBox;
            mascara.SelectionStart = 0;
        }

        private void mtxtCNPJ_Leave(object sender, EventArgs e)
        {
            if (!mtxtCNPJ.MaskFull)
            {
                mtxtCNPJ.Mask = "000,000,000-00";
            }
        }

        private void mtxtCNPJ_Enter(object sender, EventArgs e)
        {
            mtxtCNPJ.Mask = "00,000,000/0000-00";
        }

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
    }
}
