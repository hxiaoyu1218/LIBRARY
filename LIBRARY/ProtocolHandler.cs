using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

			if (Regex.IsMatch(input,pattern))
			{
				string match = Regex.Match(input, pattern).Groups[0].Value;
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
