using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LIBRARY
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			LoadServerInformation();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//Application.Run(new UserForm(null));
			PublicVar.CacheCheck();

			LoginForm loginForm = new LoginForm();
			loginForm.ShowDialog();
			loginForm.Dispose();

			if ((int)loginForm.Tag == 1)
			{
				Application.Run(new UserMainForm());

			}
			else if ((int)loginForm.Tag == 2)
			{
				Application.Run(new AdminMainForm());
			}
			//   Application.Run(new AddBookForm());
		}

		static void LoadServerInformation()
		{
			string configFile = @"ClientConfig.xml";
			XmlNode sqlNode;
			XmlNode root;

			XmlDocument doc = new XmlDocument();
			doc.Load(configFile);
			root = doc.DocumentElement;
			sqlNode = root.SelectSingleNode("ClientConfig");
			ServerClient.remoteServerIp = sqlNode.SelectSingleNode("ServerIpAddress").InnerText;
			if(ServerClient.remoteServerIp.Trim()=="") {
				MessageBox messageBox = new MessageBox(36);
				messageBox.ShowDialog();
				messageBox.Dispose();
				System.Environment.Exit(1);
			}
		}
	}
}

