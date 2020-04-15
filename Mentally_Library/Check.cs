using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentally_Library
{
    public class Check : Data
    {
        public string Analisis(int pilihan)
        {
            string Gangguan = "";
            if (pilihan == 1)
                Gangguan = DaftarGangguan[0];
            else if (pilihan == 2)
                Gangguan = DaftarGangguan[1];
            else if (pilihan == 3)
                Gangguan = DaftarGangguan[2];
            else if (pilihan == 4)
                Gangguan = DaftarGangguan[3];
            else if (pilihan == 5)
                Gangguan = DaftarGangguan[4];

            return Gangguan;
        }
    }
}
