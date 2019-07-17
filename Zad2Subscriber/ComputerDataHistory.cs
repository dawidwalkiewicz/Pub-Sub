using System;
using System.Collections.Generic;

namespace PracaMagisterskaSubscriber
{
    public class ComputerDataHistory
    {
        public String ComputerName { get; set; }
        public List<ComputerDataHistoryElement> computerDataHistoryElements;

        public ComputerDataHistory(String computerName)
        {
            computerDataHistoryElements = new List<ComputerDataHistoryElement>();
            ComputerName = computerName;
        }
        public void Add(ComputerDataHistoryElement element)
        {
            computerDataHistoryElements.Add(element);
        }

        public List<ComputerDataHistoryElement> GetHistory()
        {
            return computerDataHistoryElements;
        }
    }
}
