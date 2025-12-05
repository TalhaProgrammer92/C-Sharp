namespace CPUScheduling
{
    public class GanttChart
    {
        // Attributes
        public List<GanttBlock> GanttBlocks { get; private set; }
        
        // Constructor
        public GanttChart()
        {
            GanttBlocks = new List<GanttBlock>();
        }

        // Method - Add a gantt block
        public void AddGanttBlock(GanttBlock ganttBlock)
        {
            GanttBlocks.Add(ganttBlock);
        }

        // Method - Get recent block of the Gantt chart
        public GanttBlock? GetRecentGanttBlock => (GanttBlocks.Count > 0) ? GanttBlocks[GanttBlocks.Count - 1] : null;

        // Method - Display Gantt Chart
        public void Display(List<Process> processes)
        {
            foreach (var block in GanttBlocks)
            {
                string message = block.ToString();
                message = (block.IsIdle) ? message + " -- IDLE" : message + $" -- {processes[block.ProcessIndex!.Value].Label}";
                
                Console.WriteLine(message);
            }
        }
    }
}
