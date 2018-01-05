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
    public class ServerClient
    {
        private const int BufferSize = 8192;
        private byte[] buffer;
        private TcpClient client;
        private NetworkStream steamToServe;
        private ProtocolHandler handler;
        private FileProtocol fileProtocol;
        private bool isConnected;
        public bool isTimeOut;
        private string msg = "Welcome To .Net Sockets!";
        private static string remoteServerIp = "10.206.16.143";
        private int remoteServerPort = 6000;

        internal FileProtocol FileProtocol
        {
            get
            {
                return fileProtocol;
            }

            set
            {
                fileProtocol = value;
            }
        }

        public ServerClient()
        {

            client = new TcpClient();
            handler = new ProtocolHandler();
            client.BeginConnect(remoteServerIp, remoteServerPort, new AsyncCallback(ConnectCallback), client);
            isConnected = false;
            isTimeOut = false;

            buffer = new byte[BufferSize];


            int timer = 0;
            while (timer < 5000 && isConnected == false)
            {
                timer += 50;
                Thread.Sleep(50);
            }

            if (timer >= 5000)
            {
                //timeout
                isTimeOut = true;
            }
            else
            {
                steamToServe = client.GetStream();
            }

        }


        private void ConnectCallback(IAsyncResult ar)
        {
            TcpClient tcp = (TcpClient)ar.AsyncState;
            if (tcp.Connected)
            {
                isConnected = true;
                //SendMessage(fileProtocol.ToString());
            }
            else
            {

            }
        }

        public void SendMessage(string msg)
        {
            //msg = String.Format("[length={0}]{1}", msg.Length, msg);

            byte[] tmp = Encoding.Unicode.GetBytes(msg);
            try
            {
                lock (steamToServe)
                {
                    steamToServe.Write(tmp, 0, tmp.Length);
                }
                Console.WriteLine("Sent: {0}", msg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

        }

        private void SendMessage() { SendMessage(this.msg); }



        private void SendFile(string filePath)
        {
            TcpListener listener = new TcpListener(IPAddress.Parse("0.0.0.0"), remoteServerPort);
            listener.Start();

            IPEndPoint endpoint = listener.LocalEndpoint as IPEndPoint;
            int listeningPort = endpoint.Port;

            string fileName = Path.GetFileName(filePath);
            FileProtocol protocol = new FileProtocol(RequestMode.UserAbookLoad, listeningPort);
            string pro = protocol.ToString();

            SendMessage(pro);

            TcpClient localClient = listener.AcceptTcpClient();
            Console.WriteLine("Start sending file...");
            NetworkStream stream = localClient.GetStream();

            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            byte[] fileBuffer = new byte[1024];
            int bytesRead;
            int totalBytes = 0;

            SendStatus status = new SendStatus(filePath);

            try
            {
                do
                {
                    Thread.Sleep(10);
                    bytesRead = fs.Read(fileBuffer, 0, fileBuffer.Length);
                    stream.Write(fileBuffer, 0, bytesRead);
                    totalBytes += bytesRead;
                    status.PrintStatus(totalBytes);
                } while (bytesRead > 0);
                Console.WriteLine("Total {0} bytes sent, Done!", totalBytes);
            }
            catch (Exception)
            {
                Console.WriteLine("Server has lost...");
            }
            finally
            {
                stream.Dispose();
                fs.Dispose();
                localClient.Close();
                listener.Stop();
            }
        }

        private void BeginSendFile(object obj)
        {
            string filePath = obj as string;
            SendFile(filePath);
        }
        public void BeginSendFile(string filePath)
        {
            Thread thr = new Thread(BeginSendFile);
            thr.Start(filePath);
            //ParameterizedThreadStart start = new ParameterizedThreadStart(BeginSendFile);
            //start.BeginInvoke(filePath, null, null);
        }

        public void BeginRead()
        {
            AsyncCallback callBack = new AsyncCallback(OnReadComplete);
            steamToServe.BeginRead(buffer, 0, BufferSize, callBack, null);
        }

        public FileProtocol Read()
        {
            int totalBytes = 0;
            int bytesRead;
            do
            {
                Array.Clear(buffer, 0, buffer.Length);
                bytesRead = steamToServe.Read(buffer, totalBytes, BufferSize);
                totalBytes += bytesRead;

                Console.WriteLine("Reveiving {0} bytes ...", totalBytes);
            } while (bytesRead > 0);
            string msg = Encoding.Unicode.GetString(buffer, 0, bytesRead);
            string[] protocolArray = handler.GetProtocol(msg);
            ProtocolHelper helper = new ProtocolHelper(protocolArray[0]);
            FileProtocol protocol = helper.GetProtocol();
            return protocol;
        }

        private void OnReadComplete(IAsyncResult ar)
        {
            int bytesRead = 0;
            try
            {
                lock (steamToServe)
                {
                    bytesRead = steamToServe.EndRead(ar);

                    Console.WriteLine("Reading Data, {0} bytes", bytesRead);
                }
                if (bytesRead == 0)
                {
                    return;
                }
                string msg = Encoding.Unicode.GetString(buffer, 0, bytesRead);
                Array.Clear(buffer, 0, buffer.Length);

                string[] protocolArray = handler.GetProtocol(msg);

                foreach (string pro in protocolArray)
                {
                    handleProtocol(pro);
                }

                lock (steamToServe)
                {
                    AsyncCallback callback = new AsyncCallback(OnReadComplete);
                    steamToServe.BeginRead(buffer, 0, BufferSize, callback, null);
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                if (steamToServe != null) steamToServe.Dispose();
                client.Close();
            }
            finally
            {
                if (steamToServe != null) steamToServe.Dispose();
                client.Close();
            }
        }

        private void handleProtocol(string obj)
        {
            string pro = obj;
            ProtocolHelper helper = new ProtocolHelper(pro);
            FileProtocol protocol = helper.GetProtocol();

            if (protocol.Mode == RequestMode.UserLogin)
            {
                PublicVar.ReturnValue = protocol.Retval;
            }
            else if (protocol.Mode == RequestMode.UserRegist)
            {
                PublicVar.ReturnValue = protocol.Retval;
            }
            else if (protocol.Mode == RequestMode.UserSearchBook)
            {
                PublicVar.currentBookList = protocol.Resbook;
                PublicVar.bookTotalAmount = protocol.Endnum;
                PublicVar.ReturnValue = 0;
            }
            else if (protocol.Mode == RequestMode.UserBookDetailLoad)
            {
                PublicVar.nowBook = protocol.NowBook;
                PublicVar.ReturnValue = 0;
            }
            else if (protocol.Mode == RequestMode.UserBookStateLoad)
            {
                PublicVar.eachBookState = protocol.EachBookState;
                PublicVar.ReturnValue = protocol.Retval;
            }
            else if (protocol.Mode == RequestMode.UserBookCommentLoad)
            {
                PublicVar.currentCommentList = protocol.Comments;
                PublicVar.commentTotalAmount = protocol.Endnum;
                PublicVar.ReturnValue = 0;
            }
            else if (protocol.Mode == RequestMode.UserBookLoad)
            {
                PublicVar.ReturnValue = protocol.Retval;
                PublicVar.nowBook = protocol.NowBook;
                PublicVar.eachBookState = protocol.EachBookState;
            }
            else if (protocol.Mode == RequestMode.UserCommentBook)
            {
                PublicVar.ReturnValue = protocol.Retval;
            }
            else if (protocol.Mode == RequestMode.UserDelComment)
            {
                PublicVar.ReturnValue = protocol.Retval;
            }
            else if (protocol.Mode == RequestMode.UserBorrowBook)
            {
                PublicVar.ReturnValue = protocol.Retval;
            }
            else if (protocol.Mode == RequestMode.UserSearchBook)
            {
                PublicVar.ReturnValue = protocol.Retval;
            }
            else if (protocol.Mode == RequestMode.UserOrderBook)
            {
                PublicVar.ReturnValue = protocol.Retval;
            }


        }

        public byte[] receiveFileAsByte()
        {
            //string path = Environment.CurrentDirectory + "//" + protocol.NowBook.BookIsbn;
            byte[] fileBuffer = new byte[1000 * 1024];
            byte[] tmp = new byte[1024];

            int bytesRead;
            int totalBytes = 0;
            do
            {
                bytesRead = steamToServe.Read(tmp, 0, 1024);
                tmp.CopyTo(fileBuffer, totalBytes);
                totalBytes += bytesRead;
                //Console.WriteLine("Reveiving {0} bytes ...", totalBytes);
            } while (bytesRead > 0);

            Console.WriteLine("Total {0} bytes received, Done!", totalBytes);

            steamToServe.Dispose();
            client.Close();
            return fileBuffer;
        }
    }
}
