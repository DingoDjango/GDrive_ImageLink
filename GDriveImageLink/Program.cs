using System;
using System.Windows.Forms;

namespace GDriveImageLink
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("GOOGLE DRIVE <img> LINK PROCESSOR");
            Console.WriteLine("------------------------------\n");

            ProcessLine();
        }

        static void ProcessLine()
        {
            Console.WriteLine("Please paste the full Google Drive URL:");
            Console.Write("[Input]: ");

            string inputURL = Console.ReadLine();
            string fileID = "";
            string[] urlSegments = new Uri(inputURL).Segments;

#if DEBUG
            Console.WriteLine("----urlSegments----");

            foreach (string s in urlSegments)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("-------------------");
#endif

            for (int i = 0; i < urlSegments.Length; i++)
            {
                if (urlSegments[i] == "d/")
                {
                    string ID = urlSegments[i + 1];
                    fileID = ID.Substring(0, ID.Length - 1);
                }
            }

            string outputURL = "https://drive.google.com/uc?export=view&id=" + fileID;
            string imgLink = "<img src=\"" + outputURL + "\" />";

            Console.WriteLine($"[Output URL]: {outputURL}");
            Clipboard.SetText(imgLink);

            Console.WriteLine("Copied the <img /> tag to clipboard.");
            Console.WriteLine("------------------------------\n");

            ProcessLine();
        }
    }
}
