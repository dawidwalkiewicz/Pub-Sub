using NetMQ;
using NetMQ.Sockets;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PracaMagisterskaPublisher
{
    public partial class PracaMagisterskaPublisher : Form
    {
        private PerformanceCounter p1;
        private PerformanceCounter ramCounter;
        private PerformanceCounter diskCounter;
        private PerformanceCounter pageCounter;
        Int32 maxRam = Convert.ToInt32(((new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory)/1024)/1024);
        int procent;
        Double availableRam;
        int procentDysku;
        int procentPlikuStrony;
        string PcName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
        string location = "Lokalizacja";
        string serverAddress = "tcp://localhost:12322";
        Task t;
        CancellationTokenSource source = new CancellationTokenSource();
        CancellationToken token;
        private Thread cpuThread;
        private Thread ramThread;
        private Thread diskThread;
        private Thread pageThread;
        private double[] cpuArray = new double[60];
        private double[] ramArray = new double[60];
        private double[] diskArray = new double[60];
        private double[] pageArray = new double[60];

        public PracaMagisterskaPublisher()
        {
            InitializeComponent();
            p1 = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            diskCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total", true);
            pageCounter = new PerformanceCounter("Paging File", "% Usage", "_Total", true);
            ComputerNameTextBox.Text = PcName;
        }

        private void Time1_tick(object sender, EventArgs e)
        {
            procent = Convert.ToInt32(p1.NextValue());
            progressBar1.Value = procent;
            label1.Text = procent + "%";

            availableRam = GetAvailableRAM();
            label2.Text = availableRam + " MB / " + maxRam + " MB";
            progressBar2.Value = (Int32)(availableRam / maxRam * 100);

            procentDysku = Convert.ToInt32(GetDiskData());
            progressBar3.Maximum = 10000;
            progressBar3.Value = procentDysku;
            label6.Text = procentDysku + "%";

            procentPlikuStrony = Convert.ToInt32(GetPageFileData());
            progressBar4.Value = procentPlikuStrony;
            label7.Text = procentPlikuStrony + "%";
        }

        public void Publisher()
        {
            cpuThread = new Thread(new ThreadStart(this.GetProcessorPerformanceCounter))
            {
                IsBackground = true
            };
            cpuThread.Start();

            ramThread = new Thread(new ThreadStart(this.GetRAMPerformanceCounter))
            {
                IsBackground = true
            };
            ramThread.Start();

            diskThread = new Thread(new ThreadStart(this.GetDiskPerformanceCounter))
            {
                IsBackground = true
            };
            diskThread.Start();

            pageThread = new Thread(new ThreadStart(this.GetPageFilePerformanceCounter))
            {
                IsBackground = true
            };
            pageThread.Start();

            Random rand = new Random(1);
            using (var pubSocket = new RequestSocket())
            {
                pubSocket.Connect(serverAddress);

                while (true)
                {
                    var randomizedTopic = rand.NextDouble();
                    ComputerData computerData = new ComputerData(PcName, location, procent, Convert.ToInt32(availableRam), maxRam, procentDysku,
                        procentPlikuStrony);
                    string msg = JsonConvert.SerializeObject(computerData);
                    pubSocket.SendFrame(msg);
                    var retMessage = pubSocket.ReceiveFrameString();
                    Thread.Sleep(500);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ComputerNameLabel.Text = "Nazwa komputera: " + PcName;
            LocationTextBox.Text = location;
            ServerTextBox.Text = serverAddress;
        }

        public double GetAvailableRAM()
        {
            return ramCounter.NextValue();
        }

        public double GetDiskData()
        {
            return diskCounter.NextValue();
        }

        public double GetPageFileData()
        {
            return pageCounter.NextValue();
        }

        private void GetProcessorPerformanceCounter()
        {
            while (true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(p1.NextValue(), 0);
                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);

                if (ProcessorDataChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        UpdateCpuChart();
                    });
                }
                else
                {
                }
                Thread.Sleep(500);
            }
        }

        private void UpdateCpuChart()
        {
            ProcessorDataChart.Series["Processor"].Points.Clear();
            for (int i = 0; i < cpuArray.Length - 1; ++i)
            {
                ProcessorDataChart.Series["Processor"].Points.AddY(cpuArray[i]);
            }
        }

        private void GetRAMPerformanceCounter()
        {
            while (true)
            {
                ramArray[ramArray.Length - 1] = Math.Round(ramCounter.NextValue(), 0);
                Array.Copy(ramArray, 1, ramArray, 0, ramArray.Length - 1);

                if (RAMDataChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        UpdateRAMChart();
                    });
                }
                else
                {
                }
                Thread.Sleep(500);
            }
        }

        private void UpdateRAMChart()
        {
            RAMDataChart.Series["RAM"].Points.Clear();
            for (int i = 0; i < ramArray.Length - 1; ++i)
            {
                RAMDataChart.Series["RAM"].Points.AddY(ramArray[i]);
            }
        }

        private void GetDiskPerformanceCounter()
        {
            while (true)
            {
                diskArray[diskArray.Length - 1] = Math.Round(diskCounter.NextValue(), 0);
                Array.Copy(diskArray, 1, diskArray, 0, diskArray.Length - 1);

                if (DiskDataChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        UpdateDiskChart();
                    });
                }
                else
                {
                }
                Thread.Sleep(500);
            }
        }

        private void UpdateDiskChart()
        {
            DiskDataChart.Series["Disk"].Points.Clear();
            for (int i = 0; i < diskArray.Length - 1; ++i)
            {
                DiskDataChart.Series["Disk"].Points.AddY(diskArray[i]);
            }
        }

        private void GetPageFilePerformanceCounter()
        {
            while (true)
            {
                pageArray[pageArray.Length - 1] = Math.Round(pageCounter.NextValue(), 0);
                Array.Copy(pageArray, 1, pageArray, 0, pageArray.Length - 1);

                if (PageFileDataChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        UpdatePageFileChart();
                    });
                }
                else
                {
                }
                Thread.Sleep(500);
            }
        }

        private void UpdatePageFileChart()
        {
            PageFileDataChart.Series["Paging File"].Points.Clear();
            for (int i = 0; i < pageArray.Length - 1; ++i)
            {
                PageFileDataChart.Series["Paging File"].Points.AddY(pageArray[i]);
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            token = source.Token;
            PcName = ComputerNameTextBox.Text;
            location = LocationTextBox.Text;
            serverAddress = ServerTextBox.Text;
            t = Task.Run(() => Publisher(), token);
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (source != null)
            {
                source.Cancel();
            }
        }
    }
}