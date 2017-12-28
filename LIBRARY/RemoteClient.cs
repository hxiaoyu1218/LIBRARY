using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LIBRARY
{
    class RemoteClient
    {
        private TcpClient client;
        private NetworkStream streamToClient;
        private const int BufferSize = 8192;
        private byte[] buffer;
        private ProtocolHandler handler;

        public RemoteClient(TcpClient client)
        {
            this.client = client;

            Console.WriteLine("\nClient Connected ! {0} <-- {1}",
                client.Client.LocalEndPoint, client.Client.RemoteEndPoint);

            streamToClient = client.GetStream();
            buffer = new byte[BufferSize];

            handler = new ProtocolHandler();
        }

        public void BeginRead()
        {
            AsyncCallback callBack = new AsyncCallback(OnReadComplete);
            streamToClient.BeginRead(buffer, 0, BufferSize, callBack, null);
        }

        private void OnReadComplete(IAsyncResult ar)
        {
            int bytesRead = 0;
            try
            {
                lock (streamToClient)
                {
                    bytesRead = streamToClient.EndRead(ar);
                    Console.WriteLine("Reading Data, {0} bytes", bytesRead);
                }

                string msg = Encoding.Unicode.GetString(buffer, 0, bytesRead);
                Array.Clear(buffer, 0, buffer.Length);

                string[] protocolArray = handler.GetProtocol(msg);

                foreach (string pro in protocolArray)
                {
                    Thread thr = new Thread(handleProtocol);
                    thr.Start(pro);
                }

                lock (streamToClient)
                {
                    AsyncCallback callback = new AsyncCallback(OnReadComplete);
                    streamToClient.BeginRead(buffer, 0, BufferSize, callback, null);
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                if (streamToClient != null) streamToClient.Dispose();
                client.Close();
            }
        }

        private void handleProtocol(object obj)
        {
            string pro = obj as string;
            ProtocolHelper helper = new ProtocolHelper(pro);
            FileProtocol protocol = helper.GetProtocol();

            if (protocol.Mode == RequestMode.UserLogin)
            {
                PublicVar.ReturnValue = protocol.Retval;
            }
        }

        private void receiveFile(FileProtocol protocol)
        {
            IPEndPoint endpoint = client.Client.RemoteEndPoint as IPEndPoint;
            IPAddress ip = endpoint.Address;

            endpoint = new IPEndPoint(ip, protocol.Port);

            TcpClient localClient;
            try
            {
                localClient = new TcpClient();
                localClient.Connect(endpoint);
            }
            catch
            {
                Console.WriteLine("无法连接到客户端 --> {0}", endpoint);
                return;
            }
            NetworkStream streamToClient = localClient.GetStream();
            string path = "";// Environment.CurrentDirectory + "/" + generateFileName(protocol.UserName);
            byte[] fileBuffer = new byte[1024];
            FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);

            int bytesRead;
            int totalBytes = 0;
            do
            {
                bytesRead = streamToClient.Read(buffer, 0, BufferSize);
                fs.Write(buffer, 0, bytesRead);
                totalBytes += bytesRead;
                Console.WriteLine("Reveiving {0} bytes ...", totalBytes);
            } while (bytesRead > 0);

            Console.WriteLine("Total {0} bytes received, Done!", totalBytes);

            this.streamToClient.Dispose();
            fs.Dispose();
            localClient.Close();
        }

        private string generateFileName(string fileName)
        {
            DateTime now = DateTime.Now;
            return String.Format("{0}_{1}_{2}_{3}", now.Minute, now.Second, now.Millisecond, fileName);
        }
    }
}
