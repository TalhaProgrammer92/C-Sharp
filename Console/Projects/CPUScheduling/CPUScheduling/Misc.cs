namespace CPUScheduling
{
    public class Misc
    {
        // Method - Get earliest process based of arrival time
        public static Process? GetEarliestProcess(List<Process> processes)
        {
            if (processes.Count == 0)
                return null;

            // Find the earliest process in the given list
            var process = processes[0];
            foreach (var p in processes)
            {
                if (p.ArrivalTime < process.ArrivalTime)
                    process = p;
            }

            return process;
        }
    }
}
