using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentally_Library
{
    public class Motivate
    {
        private string[] DaftarMotivasi = new string[]
        {"Jangan menyerah","Jangan terus bersedih","Jika kamu jatuh, kamu harus bangkit lebih banyak","Selalu berpikir positif","Semesta ingin kau lebih kuat"};
        public string showMotivasi(string motivasi)
        {
            return motivasi;
        }
        public string kalimatMotivasi = "";
        public Motivate()
        {
            int RandomNum(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
            int rand = RandomNum(0, 5);
            kalimatMotivasi = DaftarMotivasi[rand];
        }
    }
}
