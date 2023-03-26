using tpmodul6_1302213103;

public class Program
{
    public static void Main(string[] args)
    {
        // Panggil object dari class SayaTubeVideo yang menguji prekondisi dan exception
        try
        {
            // membuat video dengan judul lebih dari 100 karakter (prekondisi tidak terpenuhi)
            string videoTitle = "Tutorial Design By Contract - Implementasi Design by Contract pada OOP dengan C#";
            SayaTubeVideo myVideo = new SayaTubeVideo(videoTitle);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // membuat video dengan judul yang valid
        string videoTitle2 = "Tutorial Design By Contract - Test Prekondisi & Exception";
        SayaTubeVideo myVideo2 = new SayaTubeVideo(videoTitle2);

        // panggil IncreasePlayCount dengan nilai yang valid
        myVideo2.IncreasePlayCount(1000);

        // panggil IncreasePlayCount dengan nilai yang melebihi batas maksimum (exception terjadi)
        for (int i = 0; i < 20000000; i += 10000000)
        {
            try
            {
                myVideo2.IncreasePlayCount(10000000);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                break;
            }
        }

        // cetak informasi detail video
        myVideo2.PrintVideoDetails();

        Console.ReadLine(); // keep console window open
    }
}
