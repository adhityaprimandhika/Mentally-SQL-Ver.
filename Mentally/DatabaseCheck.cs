using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mentally_DB_Library;

namespace Mentally
{
    public partial class DatabaseCheck : Form
    {
        public DatabaseCheck()
        {
            InitializeComponent();
        }

        private void btn_Database1_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            DB db = new DB();
            DatabaseCheck database = new DatabaseCheck();
            db.openConnection();
            table = db.Read_1();
            dtg_Database.DataSource  = table;
            db.closeConnection();
        }

        private void btn_Database2_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            DB db = new DB();
            DatabaseCheck database = new DatabaseCheck();
            db.openConnection();
            table = db.Read_2();
            dtg_Database.DataSource = table;
            db.closeConnection();
        }
    }
}
