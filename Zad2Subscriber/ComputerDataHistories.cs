using System.Collections.Generic;
using System.Linq;

namespace PracaMagisterskaSubscriber
{
    public class ComputerDataHistories
    {
        List<ComputerDataHistory> computerDataHistories;

        public ComputerDataHistories()
        {
            computerDataHistories = new List<ComputerDataHistory>();
        }

        public void Add(ComputerData computerData)
        {
            var history = computerDataHistories.FirstOrDefault(p => p.ComputerName == computerData.ComputerName);
            if (history != null && history.ComputerName == computerData.ComputerName)
            {
                var historyElement = new ComputerDataHistoryElement(computerData);
                history.Add(historyElement);
            }
            else
            {
                var newHistory = new ComputerDataHistory(computerData.ComputerName);
                var historyElement = new ComputerDataHistoryElement(computerData);
                newHistory.Add(historyElement);
                computerDataHistories.Add(newHistory);
            }
        }
        public ComputerDataHistory GetHistory(int index)
        {
            var history = computerDataHistories[index];
            return history;
        }
    }
}