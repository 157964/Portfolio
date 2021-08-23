using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Timers;

namespace PingAndLog
{
    class Program
    {
        private static Timer timer;
        static bool repeatProgram = true;
        static int waittime = 10000;
        static string path = @"D:\log\";
        static string fileName = "log.txt";


        static void Main()
        {
            Console.WriteLine("Program Started - Written By Joeri Smit");

            timer = new Timer();
            timer.Interval = waittime;
            timer.Elapsed += UpdateTimer;
            timer.AutoReset = true;
            timer.Enabled = repeatProgram;

            var settings = Console.ReadLine();

            if(settings == "edit")
            {
                editDefaultvalues();
            }

            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();
        }

        static int[] PingReturnData()
        {
            try
            {
                var ping = new Ping();
                var pingresult = ping.Send("www.google.com");
                int connectionSucces = 0;

                if (pingresult.Status != IPStatus.Success)
                {
                    connectionSucces = 1;
                }

                int roundtriptime = Convert.ToInt32(pingresult.RoundtripTime);
                int[] result = { roundtriptime, connectionSucces };

                return result;
            }
            catch
            {
                int[] result = { -1, 0 };
                return result;
            }
        }

        public static async Task InteractWithStorage(string Path, string Filename, string Args)
        {
            string file = Path + Filename;
            using StreamWriter UpdateFile = new(file, append: true);
            await UpdateFile.WriteLineAsync(Args);
        }

        private static async void UpdateTimer(Object source, System.Timers.ElapsedEventArgs e)
        {
            var pingData = PingReturnData();
            string WriteString = $"Ping: {pingData[0]}|Connectionsucces: {pingData[1]}|Timestamp: {e.SignalTime}";
            Console.WriteLine(WriteString);

            await InteractWithStorage(path, fileName, WriteString);
        }

        private static void editDefaultvalues()
        {
            timer.Stop();
            Console.WriteLine("REMINDER: Edit this everytime if you want custom timing");
            Console.Write("Custom timing in ms: ");
            var newTiming = Console.ReadLine();
            try
            {
                waittime = Convert.ToInt32(newTiming);
            }
            catch
            {
                Console.WriteLine("Invalid timing");
            }
            timer.Start();
        }
    }
}
