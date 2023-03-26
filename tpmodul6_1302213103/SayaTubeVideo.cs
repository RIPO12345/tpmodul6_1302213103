using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302213103
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string videoTitle)
        {
            // Prekondisi: Judul video memiliki panjang maksimal 100 karakter dan tidak berupa null.
            if (videoTitle == null || videoTitle.Length > 100)
            {
                throw new ArgumentException("Judul video harus berisi antara 1-100 karakter");
            }

            // generate random id with 5 digits
            Random rand = new Random();
            id = rand.Next(10000, 99999);

            title = videoTitle;
            playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            // Prekondisi: Input penambahan play count maksimal 10.000.000 per panggilan method-nya.
            if (count < 0 || count > 10000000)
            {
                throw new ArgumentOutOfRangeException("Jumlah penambahan play count harus di antara 0-10.000.000");
            }

            try
            {
                // pastikan tidak terjadi overflow pada penambahan playCount
                playCount = checked(playCount + count);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("========== Video Details=========");
            Console.WriteLine("ID           : " + id);
            Console.WriteLine("Title        : " + title);
            Console.WriteLine("Play Count   : " + playCount);
        }
    }
}
    
