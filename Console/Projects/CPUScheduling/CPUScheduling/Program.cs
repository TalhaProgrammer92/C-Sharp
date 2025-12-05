namespace CPUScheduling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Process> processes = new List<Process>();

            for (int i = 0; i < 5; i++)
            {
                processes.Add(new Process(
                    burstTime: i + 3,
                    arrivalTime: i + 2));
            }

            GanttChart chart = Scheduler.FirstComeFirstServe(processes)!;
        }
    }
}
