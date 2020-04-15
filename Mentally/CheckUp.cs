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
    public partial class CheckUp : Form
    {
        public CheckUp()
        {
            InitializeComponent();
        }

        private void btn_CheckUp_Click(object sender, EventArgs e)
        {
            string pilihan = "";
            Check check = new Check();
            if (Rbtn_Gejala_1.Checked == true)
                pilihan = check.Analisis(1);
            else if (Rbtn_Gejala_2.Checked == true)
                pilihan = check.Analisis(2);
            else if (Rbtn_Gejala_3.Checked == true)
                pilihan = check.Analisis(3);
            else if (Rbtn_Gejala_4.Checked == true)
                pilihan = check.Analisis(4);
            else if (Rbtn_Gejala_5.Checked == true)
                pilihan = check.Analisis(5);

            Result hasil = new Result(pilihan);
            hasil.Show();
            this.Hide();
        }

        private void btn_CheckUp_Back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
