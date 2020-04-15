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
    public partial class Result : Form
    {
        public Result(string Gangguan)
        {
            InitializeComponent();
            lb_HasilGangguan.Text = Gangguan;
        }

        private void btn_HasilSolusi_Click(object sender, EventArgs e)
        {
            Solution solution = new Solution(lb_HasilGangguan.Text);
            solution.Show();
            this.Hide();
        }
    }
}
