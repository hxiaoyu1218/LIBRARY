using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetWorkApp
{
	//class RequestHandler
	//{
	//	private string temp = string.Empty;//字符串缓存区

	//	public string[] GetActualString(string input)
	//	{
	//		return GetActualString(input, null);
	//	}

	//	private string[] GetActualString(string input,List<string> outputList)
	//	{
	//		if (outputList == null)
	//			outputList = new List<string>();
	//		if (!string.IsNullOrEmpty(temp))
	//			input = temp + input;
	//		string output = "";
	//		string pattern = @"(?<=^\[length=)(\d+)(?=\])";
	//		int length;
	//		if(Regex.IsMatch(input,pattern))
	//		{
	//			Match m = Regex.Match(input, pattern);

	//			length = Convert.ToInt32(m.Groups[0].Value);//获取length后的数字

	//			int startIndex = input.IndexOf(']') + 1;
	//			output = input.Substring(startIndex);

	//			if(output.Length==length)//长度匹配,说明刚好是一条消息
	//			{
	//				outputList.Add(output);
	//				temp = "";
	//			}
	//			else if(output.Length<length)//不足一条消息，缓存，待下次处理
	//			{
	//				temp = input;
	//			}
	//			else if(output.Length>length)//超过一条消息，截断后递归处理
	//			{
	//				outputList.Add(output.Substring(0, length));
	//				input = output.Substring(length + 1);
	//				temp = "";
	//				GetActualString(input, outputList);
	//			}
	//		}
	//		else//中括号不完整
	//		{
	//			temp = input;
	//		}
	//		return outputList.ToArray();
	//	}
	//	private void PrintOutput(string input)
	//	{
	//		Console.WriteLine(input);
	//		string[] outputArray = GetActualString(input);
	//		foreach (var output in outputArray)
	//		{
	//			Console.WriteLine(output);
	//		}
	//		Console.WriteLine();
	//	}
	//	public static void Test()
	//	{
	//		RequestHandler handler = new RequestHandler();
	//		string input;

	//		input = "[length=9]abcdefghi";
	//		handler.PrintOutput(input);

	//	}
	//}
}
