using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateStructure;
using System.Collections.Generic;

namespace DateStructureTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			DicTree<string> test = new DicTree<string>();
			string[] tmp = new string[10];
			tmp[0] = "数学";
			tmp[1] = "数字";
			tmp[2] = "数学家";
			tmp[3] = "数学家们";
			tmp[4] = "数字哈哈";
			for(int i = 0;i < 5;i++)
			{
				test.Insert(tmp[i], tmp[i]);
			}
			string s = Console.ReadLine();
			List<string> res = test.Find(s);
			foreach(string t in res)
				Console.WriteLine(t);
			test.Erase(tmp[1], tmp[1]);
			res = test.Find(s);
			foreach(string t in res)
				Console.WriteLine(t);

			Console.ReadKey();
		}
	}
}
