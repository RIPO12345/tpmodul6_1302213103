using tpmodul6_1302213103;

public class Program
{
    public static void Main(string[] args)
    {
        // membuat video baru dengan judul "Tutorial Design By Contract – [NAMA_PRAKTIKAN]"
        string videoTitle = "Tutorial Design By Contract - [Placida Ripo Naibaho]";
        SayaTubeVideo myVideo = new SayaTubeVideo(videoTitle);

        // call IncreasePlayCount method to add 100 views
        myVideo.IncreasePlayCount(100);

        // call PrintVideoDetails method to print video details
        myVideo.PrintVideoDetails();

        Console.ReadLine(); // keep console window open
    }
}
