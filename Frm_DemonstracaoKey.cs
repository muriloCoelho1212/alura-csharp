using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_DemonstracaoKey : Form
    {
        public Frm_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Msg.AppendText("\r\n" + "Pressionei a tecla " + e.KeyCode + "\r\n");
            Txt_Msg.AppendText("\r\n" + "Código da tecla " + ((int)e.KeyCode) + "\r\n");
            Txt_Msg.AppendText("\r\n" + "Nome da tecla " + e.KeyData + "\r\n");
            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Msg.Text = null;
            Txt_Input.Text = null;
            Lbl_Upper.Text = null;
            Lbl_Lower.Text = null;
        }
    }
}
