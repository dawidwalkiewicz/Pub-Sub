using System;

namespace PracaMagisterskaPublisher
{
    public class ComputerData
    {
        public string ComputerName { get; set; }
        public string ComputerLocation { get; set; }
        public int ComputerCPU { get; set; }
        public int ComputerRAM { get; set; }
        public int ComputerAvailableRAM { get; set; }
        public double ComputerDisk { get; set; }
        public int ComputerPageFile { get; set; }

        public ComputerData(String computerName, String computerLocation, int computerCPU, int computerRAM, int computerAvailableRAM, double computerDisk,
            int computerPageFile)
        {
            ComputerName = computerName;
            ComputerLocation = computerLocation;
            ComputerCPU = computerCPU;
            ComputerRAM = computerRAM;
            ComputerAvailableRAM = computerAvailableRAM;
            ComputerDisk = computerDisk;
            ComputerPageFile = computerPageFile;
        }
    }
}