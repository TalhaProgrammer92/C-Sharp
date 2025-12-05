namespace CPUScheduling
{
    public class Scheduler
    {
        // This scheduler follows the FCFS method to produce a GANTT Chart
        public static GanttChart? FirstComeFirstServe(List<Process> processes)
        {
            if (processes.Count == 0) return null;
            
            GanttChart ganttChart = new();
            ReadyQueue readyQueue = new();

            // Adding processes to the ready queue
            int index = Misc.GetEarliestProcessIndex(processes);
            for (int i = 1; i < processes.Count; i++)
            {
                var filteredProcesses = processes.Where(p => p.ArrivalTime > index).ToList();
                foreach (var process in processes)
                {
                    if (filteredProcesses.Count == 0)
                    {
                        i = processes.Count;    // Break outer loop
                        break;  // Break inner loop
                    }

                    index = Misc.GetEarliestProcessIndex(filteredProcesses);
                }
            }

            // Generating Gantt Chart
            for (int i = 0; i < readyQueue.ProcessesIndex.Count; i++)
            {
                int processIndex = readyQueue.ProcessesIndex[i];
                var process = processes[processIndex];
                var recentGanttBlock = ganttChart.GetRecentGanttBlock;
                int startTime = (recentGanttBlock is null) ? 0 : recentGanttBlock.Duration;

                // Process has arrived
                if (process.ArrivalTime <= startTime)
                    ganttChart.AddGanttBlock(new GanttBlock(startTime, startTime + process.BurstTime, processIndex));
                // Process has not arrived
                else
                {
                    ganttChart.AddGanttBlock(new GanttBlock(startTime, startTime + process.ArrivalTime));
                    i--;    // Make sure the recent process in ready queue won't skip
                }
            }

            // Updating the processes' data based on the Gantt chart
            foreach (var ganttBlock in ganttChart.GanttBlocks)
            {
                if (ganttBlock.IsIdle) continue;

                processes[ganttBlock.ProcessIndex!.Value].CompletionTime = ganttBlock.Duration;
            }

            return ganttChart;
        }
    }
}
