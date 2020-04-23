using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Mentally_Library;
using Mentally_DB_Library;

namespace Mentally
{
    public partial class Solution : Form
    {
        private string gangguan = "";
        public Solution(string Gangguan)
        {
            InitializeComponent();
            string pilihan = Gangguan;
            GiveSolution giveSolution = new GiveSolution(pilihan);
            lb_Solusi_1.Text = giveSolution.solusi_1;
            lb_Solusi_2.Text = giveSolution.solusi_2;
            lb_Solusi_3.Text = giveSolution.solusi_3;
            lb_Solusi_4.Text = giveSolution.solusi_4;
            gangguan = pilihan;
        }

        public Boolean checkValue()
        {
            string Gangguan = gangguan;
            string sol1 = lb_Solusi_1.Text;
            string sol2 = lb_Solusi_2.Text;
            string sol3 = lb_Solusi_3.Text;
            string sol4 = lb_Solusi_4.Text;
            if(Gangguan.Equals("") || sol1.Equals("") || sol2.Equals("") || sol3.Equals("") || sol4.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void UploadData()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `history`(`gangguan`, `solusi_1`, `solusi_2`, `solusi_3`, `solusi_4`) VALUES(@gangguan, @sol_1, @sol_2, @sol_3, @sol_4)", db.getConnection());

            command.Parameters.Add("@gangguan", MySqlDbType.VarChar).Value = gangguan;
            command.Parameters.Add("@sol_1", MySqlDbType.VarChar).Value = lb_Solusi_1.Text;
            command.Parameters.Add("@sol_2", MySqlDbType.VarChar).Value = lb_Solusi_2.Text;
            command.Parameters.Add("@sol_3", MySqlDbType.VarChar).Value = lb_Solusi_3.Text;
            command.Parameters.Add("@sol_4", MySqlDbType.VarChar).Value = lb_Solusi_4.Text;

            db.openConnection();
            if (!checkValue())
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Please fill your information correctly");
            }
            db.closeConnection();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            UploadData();
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
