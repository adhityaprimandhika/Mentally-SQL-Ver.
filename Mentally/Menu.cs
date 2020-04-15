using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mentally
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_CheckUp_Click(object sender, EventArgs e)
        {
            CheckUp checkUp = new CheckUp();
            checkUp.Show();
            this.Hide();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {

        }

        private void btn_Motivasi_Click(object sender, EventArgs e)
        {
            Motivation motivation = new Motivation();
            motivation.Show();
            this.Hide();
        }
    }
}
