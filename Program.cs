using System.Net;
using System.Text;

string text = Path.GetTempPath() + "\\altanb.exe";
Random rnd = new Random();
for (int i = 0; i < 10000000; i++)
{
    WebClient webClient = new WebClient();
    webClient.DownloadFile("http://localhost/altanb.exe", text);
    Console.WriteLine(rnd.Next());
    File.Move(Path.GetTempPath() + "\\altanb.exe", "C:\\Users\\ZeroByte\\Desktop\\deneme\\" + rnd.Next() + ".exe");
}
