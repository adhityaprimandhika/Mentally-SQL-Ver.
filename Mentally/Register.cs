using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Mentally_Library;
using Mentally_DB_Library;

namespace Mentally
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterAccount()
        {
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `account`(`email`, `password`, `username`, `nama`) VALUES ( @email, @pass, @usn, @nama)", dB.getConnection());


            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = tb_Email.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tb_Password.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = tb_Username.Text;
            command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = tb_Nama.Text;

            dB.openConnection();

            if (!checkValue())
            {
                if (checkUsername())
                {
                    MessageBox.Show("This username already taken");
                }
                else
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Account Created");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill your information correctly");
            }
            

            dB.closeConnection();
        }

        public Boolean checkUsername()
        {
            DB db = new DB();

            string username = tb_Username.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `account` WHERE `username` = @usn", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean checkValue()
        {
            string email = tb_Email.Text;
            string password = tb_Password.Text;
            string username = tb_Username.Text;
            string nama = tb_Nama.Text;
            if(email.Equals("") || password.Equals("") || username.Equals("") || nama.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            RegisterAccount();
            Start start = new Start();
            start.Show();
            this.Close();
        }

        private void btn_Register_Back_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Hide();
        }

        
    }
}
