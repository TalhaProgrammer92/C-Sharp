namespace CPUScheduling
{
    public class Misc
    {
        // Method - Get earliest process based of arrival time
        public static int GetEarliestProcessIndex(List<Process> processes)
        {
            if (processes.Count == 0) return -1;

            // Find the earliest process in the given list
            int index = 0;
            for (int i = 1; i < processes.Count; i++)
            {
                var process = processes[i];
                if (process.ArrivalTime < processes[index].ArrivalTime)
                    index = i;
            }

            return index;
        }
    }
}
