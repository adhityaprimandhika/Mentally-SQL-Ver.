using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentally_Library
{
    public class GiveSolution : Data
    {
        private string[] DaftarSolusi_1 = new string[]
        {"Berlatih memerangi setiap pikiran negatif","Buat buku harian yang bercerita tentang suasana hati","Lakukan hal baru","Buat rutinitas baru"};
        private string[] DaftarSolusi_2 = new string[]
        {"Tidur dengan cukup","Olahraga teratur","Mengatur tingkat stres","Menjaga interaksi sosial"};
        private string[] DaftarSolusi_3 = new string[]
        {"Memusatkan pikiran pada aktivitas yang sedang dijalani","Menghindari kafein dan alkohol","Bercerita kepada orang lain","Menyediakan waktu untuk diri sendiri"};
        private string[] DaftarSolusi_4 = new string[]
        {"Cari teman bicara","Aktivitas di luar bersama dengan teman","Berolahraga untuk tetap aktif","Nikmati semua yang terjadi dalam hidup"};
        private string[] DaftarSolusi_5 = new string[]
        {"Waktu bangun dan tidur harus teratur","Gunakan kasur hanya untuk tidur","Buat tempat tidur menjadi nyaman","Makan malam lebih awal"};

        public string solusi_1 = "";
        public string solusi_2 = "";
        public string solusi_3 = "";
        public string solusi_4 = "";

        public GiveSolution(string Gangguan)
        {
            if (Gangguan == DaftarGangguan[0])
            {
                solusi_1 = DaftarSolusi_1[0];
                solusi_2 = DaftarSolusi_1[1];
                solusi_3 = DaftarSolusi_1[2];
                solusi_4 = DaftarSolusi_1[3];
            }
            else if (Gangguan == DaftarGangguan[1])
            {
                solusi_1 = DaftarSolusi_2[0];
                solusi_2 = DaftarSolusi_2[1];
                solusi_3 = DaftarSolusi_2[2];
                solusi_4 = DaftarSolusi_2[3];
            }
            else if (Gangguan == DaftarGangguan[2])
            {
                solusi_1 = DaftarSolusi_3[0];
                solusi_2 = DaftarSolusi_3[1];
                solusi_3 = DaftarSolusi_3[2];
                solusi_4 = DaftarSolusi_3[3];
            }
            else if (Gangguan == DaftarGangguan[3])
            {
                solusi_1 = DaftarSolusi_4[0];
                solusi_2 = DaftarSolusi_4[1];
                solusi_3 = DaftarSolusi_4[2];
                solusi_4 = DaftarSolusi_4[3];
            }
            else if (Gangguan == DaftarGangguan[4])
            {
                solusi_1 = DaftarSolusi_5[0];
                solusi_2 = DaftarSolusi_5[1];
                solusi_3 = DaftarSolusi_5[2];
                solusi_4 = DaftarSolusi_5[3];
            }
        }
    }
}
