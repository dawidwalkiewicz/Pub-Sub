using NetMQ;
using NetMQ.Sockets;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracaMagisterskaSubscriber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitGrid();
            var t = Task.Run(() => Subscriber());
        }
        
        bool runProcess = true;
        bool isConnected = false;
        int computersCounter = 0;
        public string computerName;
        public string computerLocation;
        public string computerCPU;
        public string computerRAM;
        public string computerAvailableRAM;
        public string computerPhysicalDisk;
        public string computerPagingFile;
        public static IList<string> allowableCommandLineArgs
            = new[] { "Processor", "RAM", "Disk", "All" };
        List<ComputerData> computerDataList;
        BindingList<ComputerData> bindingList;
        BindingSource source;
        ComputerDataHistories CompDataHistories;

        public delegate void CpuDataDelegate();

        public void InitGrid()
        {
            CompDataHistories = new ComputerDataHistories();
            computerDataList = new List<ComputerData>();
            bindingList = new BindingList<ComputerData>(computerDataList);
            source = new BindingSource(bindingList, null);
            computersDataGridView1.DataSource = source;
            computersDataGridView1.Visible = true;
            computersDataGridView1.AllowUserToAddRows = false;
            computersDataGridView1.AutoGenerateColumns = false;
            ComputersLabel.Text = "Podłączone komputery: " + computersCounter;

            DataGridViewTextBoxColumn CompName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn CompLocation = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn CompCPU = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn CompRAM = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn CompAvailableRAM = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn CompPhyDisk = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn CompPageFile = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn CompDetails = new DataGridViewTextBoxColumn();

            computersDataGridView1.Columns[0].HeaderText = "Nazwa komputera";
            computersDataGridView1.Columns[1].HeaderText = "Sala";
            computersDataGridView1.Columns[2].HeaderText = "Procesor";
            computersDataGridView1.Columns[3].HeaderText = "Dostępna pamięć RAM";
            computersDataGridView1.Columns[4].HeaderText = "Całkowita pamięć RAM";
            computersDataGridView1.Columns[5].HeaderText = "Dysk fizyczny";
            computersDataGridView1.Columns[6].HeaderText = "Plik strony";
        }
        
        public void Subscriber()
        {
            runProcess = true;

            using (var subSocket = new ResponseSocket())
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                var serverIP = host.AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
                subSocket.Bind("tcp://" + serverIP + ":12322");
                DataGridViewButtonColumn DetailsButton = new DataGridViewButtonColumn
                {
                    Name = "CompDetailsButton",
                    HeaderText = "Szczegóły",
                    Text = "Szczegóły",
                    UseColumnTextForButtonValue = true
                };
                if (computersDataGridView1.Columns["CompDetailsButton"] == null)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        computersDataGridView1.Columns.Insert(7, DetailsButton);
                    });
                }
                computersDataGridView1.CellClick += DetailsButton_Click;

                while (runProcess)
                {
                    isConnected = true;
                    string messageReceived = subSocket.ReceiveFrameString();
                    subSocket.SendFrame("OK");
                    WyswietlWszystko(messageReceived);
                    ComputerData computerData = JsonConvert.DeserializeObject<ComputerData>(messageReceived);
                    AddComputerDataToList(computerDataList, computerData);
                    CompDataHistories.Add(computerData);
                    DisplayAlarms(computerDataList, computerData);
                    this.Invoke((MethodInvoker)delegate
                    {
                        ChangeData();
                    });
                }
                computersCounter = computersDataGridView1.RowCount;
            }
        }
        public void ChangeData()
        {
            source = new BindingSource(bindingList, null);
            computersDataGridView1.DataSource = source;
        }

        public void AddComputerDataToList(List<ComputerData> computerDataList, ComputerData computerData)
        {
            var comp = computerDataList.FirstOrDefault(p => p.ComputerName == computerData.ComputerName);
            if (comp != null && comp.ComputerName == computerData.ComputerName)
            {
                comp.ComputerLocation = computerData.ComputerLocation;
                comp.ComputerCPU = computerData.ComputerCPU;
                comp.ComputerRAM = computerData.ComputerRAM;
                comp.ComputerAvailableRAM = computerData.ComputerAvailableRAM;
                comp.ComputerDisk = computerData.ComputerDisk;
                comp.ComputerPageFile = computerData.ComputerPageFile;
            }
            else
            {
                computerDataList.Add(computerData);
            }
        }

        public void DisplayAlarms(List<ComputerData> computerDataList, ComputerData computerData)
        {
            var comp = computerDataList.FirstOrDefault(p => p.ComputerName == computerData.ComputerName);
            if (comp.ComputerCPU > 90)
            {
                richTextBox1.Text = "\nZbyt duże przeciążenie procesora!\n";
            }
            if (comp.ComputerRAM <= 500)
            {
                richTextBox1.Text = "\nZa mało dostępnej pamięci!\n";
            }
            if (comp.ComputerDisk > 1000)
            {
                richTextBox1.Text = "\nZbyt duże obciążenie dysku!\n";
            }
            if (comp.ComputerPageFile > 50)
            {
                richTextBox1.Text = "\nZbyt duże obciążenie pliku stronicowania!\n";
            }
        }

        public void WyswietlWszystko(string messageReceived)
        {
            richTextBox1.InvokeIfRequired(() =>
            {
                richTextBox1.AppendText(messageReceived + Environment.NewLine);
            });
        }

        private void DetailsButton_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == computersDataGridView1.Columns["CompDetailsButton"].Index)
            {
                var history = CompDataHistories.GetHistory(e.RowIndex);
                Details details = new Details(history);
                details.Show(this);
            }
        }
    }
}
