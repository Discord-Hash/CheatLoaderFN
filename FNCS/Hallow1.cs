

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace Hallow
{
	internal class Hallow1
	{
		public static void Inject()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			WebClient webClient = new WebClient();
			Directory.CreateDirectory("C:\\FNCS\\");

			string text1 = "C:\\FNCS\\test.exe";

			webClient.DownloadFile("", text1);
			Process process = new Process();
			Thread.Sleep(3000);
			process.Close();
			Console.Clear();
			Console.WriteLine(" <3  Load Fortnite");
			Thread.Sleep(4000);
			Hallow2.Print("\n Press [Enter] in Lobby...");
			Console.ReadLine();
			Process.Start(text1);
			Thread.Sleep(4000);
			Hallow2.Print("\n Press [Enter] to Close Console");
			File.Delete(text1);
			Environment.Exit(0);


		}
	}
}
