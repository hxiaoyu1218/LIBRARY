using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY
{
	class SendStatus
	{
		private FileInfo info;
		private long fileBytes;

		public SendStatus(string filePath)
		{
			info = new FileInfo(filePath);
			fileBytes = info.Length;
		}
		public void PrintStatus(int sent)
		{
			string percent = GetPercent(sent);
			Console.WriteLine("Sending {0} bytes, {1}% ...", sent, percent);
		}

		public string GetPercent(int sent)
		{
			decimal allBytes = Convert.ToDecimal(fileBytes);
			decimal currentSent = Convert.ToDecimal(sent);

			decimal percent = currentSent / allBytes * 100;
			percent = Math.Round(percent, 1);
			return percent.ToString();
		}
	}
}
