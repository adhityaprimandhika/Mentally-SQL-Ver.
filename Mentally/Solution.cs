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
    public partial class Solution : Form
    {
        
        
        public Solution(string Gangguan)
        {
            InitializeComponent();
            string pilihan = Gangguan;
            GiveSolution giveSolution = new GiveSolution(pilihan);
            lb_Solusi_1.Text = giveSolution.solusi_1;
            lb_Solusi_2.Text = giveSolution.solusi_2;
            lb_Solusi_3.Text = giveSolution.solusi_3;
            lb_Solusi_4.Text = giveSolution.solusi_4;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved");
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
