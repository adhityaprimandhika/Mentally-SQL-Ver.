using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mentally_Library;

namespace Mentally
{
    public partial class Motivation : Form
    {
        public Motivation()
        {
            InitializeComponent();
        }

        private void btn_Motivasi_Back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btn_Motivasi_Click(object sender, EventArgs e)
        {
            Motivate motivate = new Motivate();
            lb_Motivasi.Text = motivate.showMotivasi(motivate.kalimatMotivasi);
        }
    }
}
