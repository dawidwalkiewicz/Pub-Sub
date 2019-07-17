using System;

namespace PracaMagisterskaSubscriber
{
    public class ComputerDataHistoryElement
    {
        public DateTime Date { get; set; }
        public ComputerData ComputerData { get; set; }
        public ComputerDataHistoryElement(ComputerData comp)
        {
            Date = DateTime.Now;
            ComputerData = comp;
        }
    }
}
