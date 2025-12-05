namespace CPUScheduling
{
    public class Scheduler
    {
        // This scheduler follows the FCFS method to produce a GANTT Chart
        public static GanttChart? FirstComeFirstServe(List<Process> processes)
        {
            if (processes.Count == 0) return null;
            
            GanttChart ganttChart = new GanttChart();
            ReadyQueue<Process> readyQueue = new ReadyQueue<Process>();

            // Adding processes to the ready queue
            int lowestTime = -1;
            for (int i = 0; i < processes.Count; i++)
            {
                // Get the process having earliest arrival time
                var process = Misc.GetEarliestProcess(
                    processes.Where(p => p.ArrivalTime > lowestTime).ToList());

                readyQueue.AddProcess(process!);
                lowestTime = process!.ArrivalTime;
            }

            return ganttChart;
        }
    }
}
