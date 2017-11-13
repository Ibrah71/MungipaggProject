using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Mundipagg.PontoDigital.Solution.Presentation.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer ServiceTimer = new Timer(20000);
            ServiceTimer.Enabled = true;
            ServiceTimer.AutoReset = true;


            ServiceTimer.Elapsed += new System.Timers.ElapsedEventHandler(checkForTime_Elapsed);


            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();



            void checkForTime_Elapsed(object sender, ElapsedEventArgs e)
            {
                Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);

                try
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://192.168.1.65/MFRC522-python/teste2.json");
                    request.Method = WebRequestMethods.Ftp.DownloadFile;
                    request.Credentials = new NetworkCredential("pi", "123");
                    request.UseBinary = true;

                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {


                        using (Stream rs = response.GetResponseStream())
                        {
                            using (FileStream ws = new FileStream("C:\\Users\\marry\\Documents\\teste2.json", FileMode.Create))
                            {
                                byte[] buffer = new byte[2048];
                                int bytesRead = rs.Read(buffer, 0, buffer.Length);

                                while (bytesRead > 0)
                                {
                                    ws.Write(buffer, 0, bytesRead);
                                    bytesRead = rs.Read(buffer, 0, buffer.Length);
                                }

                            }

                        }

                    }
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
