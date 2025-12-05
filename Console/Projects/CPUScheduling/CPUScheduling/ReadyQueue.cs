namespace CPUScheduling
{
    public class ReadyQueue
    {
        // Attributes
        public List<int> ProcessesIndex { get; private set; }

        // Constructor
        public ReadyQueue()
        {
            ProcessesIndex = new List<int>();
        }

        // Method - Add a process
        public void AddProcessIndex(int index)
        {
            if (index >= 0)
                ProcessesIndex.Add(index);
        }
    }
}
