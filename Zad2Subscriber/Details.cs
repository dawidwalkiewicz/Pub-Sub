using System;
using System.Threading;
using System.Windows.Forms;

namespace PracaMagisterskaSubscriber
{
    public partial class Details : Form
    {
        public Details(ComputerDataHistory _history)
        {
            InitializeComponent();
            history = _history;
        }

        ComputerDataHistory history;
        string DisplayedPcName;
        int procent;
        Double availableRam;
        int procentDysku;
        int procentPlikuStrony;
        private Thread cpuThread;
        private Thread ramThread;
        private Thread diskThread;
        private Thread pageThread;
        private double[] cpuArray = new double[60];
        private double[] ramArray = new double[60];
        private double[] diskArray = new double[60];
        private double[] pageArray = new double[60];

        private void Time1_tick(object sender, EventArgs e)
        {
            int last = history.computerDataHistoryElements.Count - 1;
            procent = history.computerDataHistoryElements[last].ComputerData.ComputerCPU;
            CPUProgressBar.Value = procent;
            label1.Text = procent + "%";

            Int32 maxRam = history.computerDataHistoryElements[last].ComputerData.ComputerAvailableRAM;

            availableRam = history.computerDataHistoryElements[last].ComputerData.ComputerRAM;
            label2.Text = availableRam + " MB / " + maxRam + " MB";
            RAMProgressBar.Value = (Int32)(availableRam / maxRam);

            procentDysku = (int)history.computerDataHistoryElements[last].ComputerData.ComputerDisk;
            DiskProgressBar.Maximum = 10000;
            DiskProgressBar.Value = procentDysku;
            label6.Text = procentDysku + "%";

            procentPlikuStrony = history.computerDataHistoryElements[last].ComputerData.ComputerPageFile;
            PagingFileProgressBar.Value = procentPlikuStrony;
            label7.Text = procentPlikuStrony + "%";
        }

        public void MainDetails()
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Tick += Time1_tick;
            timer1.Enabled = true;
            timer1.Start();
            Form1 subscriber = (Form1)this.Owner;
            DisplayedPcName = history.ComputerName;
            ComputerNameLabel.Text = "Nazwa komputera: " + DisplayedPcName;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveAllButton_Click(object sender, EventArgs e)
        {
            UpdateExcel();
        }

        private void GetProcessorPerformanceCounter()
        {
            while (true)
            {
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

        private void UpdateExcel()
        {
            Microsoft.Office.Interop.Excel.Application oXL = null;
            Microsoft.Office.Interop.Excel._Workbook oWB = null;
            Microsoft.Office.Interop.Excel._Worksheet oSheet = null;
            object misvalue = System.Reflection.Missing.Value;
            int last = history.computerDataHistoryElements.Count;
            try
            {
                oXL = new Microsoft.Office.Interop.Excel.Application
                {
                    Visible = false
                };
                oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
                oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

                oSheet.Cells[1, 1] = "Data";
                oSheet.Cells[1, 2] = "Nazwa komputera";
                oSheet.Cells[1, 3] = "Lokalizacja";
                oSheet.Cells[1, 4] = "Procesor";
                oSheet.Cells[1, 5] = "Dostępna pamięć RAM";
                oSheet.Cells[1, 6] = "Pamięć RAM";
                oSheet.Cells[1, 7] = "Dysk";
                oSheet.Cells[1, 8] = "Plik stronicowania";

                oSheet.get_Range("A1", "H1").Font.Bold = true;

                for (int i = 0; i < last; i++)
                {
                    oSheet.Cells[i + 2, 1] = history.computerDataHistoryElements[i].Date.ToLongTimeString();
                    oSheet.Cells[i + 2, 2] = history.computerDataHistoryElements[i].ComputerData.ComputerName;
                    oSheet.Cells[i + 2, 3] = history.computerDataHistoryElements[i].ComputerData.ComputerLocation;
                    oSheet.Cells[i + 2, 4] = history.computerDataHistoryElements[i].ComputerData.ComputerCPU.ToString();
                    oSheet.Cells[i + 2, 5] = history.computerDataHistoryElements[i].ComputerData.ComputerRAM.ToString();
                    oSheet.Cells[i + 2, 6] = history.computerDataHistoryElements[i].ComputerData.ComputerAvailableRAM.ToString();
                    oSheet.Cells[i + 2, 7] = history.computerDataHistoryElements[i].ComputerData.ComputerDisk.ToString();
                    oSheet.Cells[i + 2, 8] = history.computerDataHistoryElements[i].ComputerData.ComputerPageFile.ToString();
                }

                oXL.Visible = false;
                oXL.UserControl = false;
                oWB.SaveAs("~\\PracaMagisterska\\Zad2\\Wyniki.xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                    false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                MessageBox.Show("Zrobione!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (oWB != null)
                    oWB.Close();
            }
        }
    }
}