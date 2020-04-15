using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentallyLibrary
{
    public class Library
    {
        public string idterpilih;
        SqlConnection Koneksi = new SqlConnection(MentallyLibrary.Properties.Resources.Koneksi.ToString());
        public SqlCommand cmd;
        private void ShowData()
        {
            SqlDataAdapter DA = new SqlDataAdapter("select * from Account", Koneksi);
            DataSet DS = new DataSet();
            DA.Fill(DS);
        }

        private void Add()
        {
            Koneksi.Open();
            cmd = new SqlCommand("insert into Account values('")
        }
    }
}
