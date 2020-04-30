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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void btn_showHistory_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            DB db = new DB();
            History history = new History();
            db.openConnection();
            table = db.Read_2();
            dtgView.DataSource = table;
            db.closeConnection();
        }

        private void btn_Back_History_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
