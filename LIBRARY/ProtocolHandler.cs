using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
namespace LIBRARY
{
	class ProtocolHandler
	{
		private string partialProtocal;
		public ProtocolHandler()
		{
			partialProtocal = "";
		}
		public string[] GetProtocol(string input)
		{
			return GetProtocol(input, null);
		}
		public string[] GetProtocol(string input,List<string> outputList)
		{
			if (outputList == null) 
				outputList = new List<string>();
			if (String.IsNullOrEmpty(input))
				return outputList.ToArray();
			if (!String.IsNullOrEmpty(partialProtocal))
				input = partialProtocal + input;
			string pattern= "(^<protocol>.*?</protocol>)";
            FileStream fs = new FileStream("t.txt", FileMode.Create);
            byte[] bt = Encoding.Unicode.GetBytes(input);
            fs.Write(bt,0,bt.Length);
            fs.Close();

			if (Regex.IsMatch(input,pattern,RegexOptions.Singleline))
			{
                
				string match = Regex.Match(input, pattern, RegexOptions.Singleline).Groups[0].Value;
				outputList.Add(match);
				partialProtocal = "";

				input = input.Substring(match.Length);

				GetProtocol(input, outputList);
			}
			else
			{
				partialProtocal = input;
			}
			return outputList.ToArray();
		}
	}
}
