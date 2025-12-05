namespace CPUScheduling
{
    public class GanttBlock
    {
        // Attributes
        public int StartTime { get; set; }
        public int Duration { get; set; }
        public int? ProcessIndex { get; private set; }
        public bool IsIdle => ProcessIndex is null;

        // Constructor
        public GanttBlock(int startTime, int duration, int? processIndex = null)
        {
            StartTime = startTime;
            Duration = duration;
            ProcessIndex = processIndex;
        }

        // Method - Display the block
        public override string ToString()
        {
            return $"Start: {StartTime} -- Duration: {Duration}";
        }  
    }
}
