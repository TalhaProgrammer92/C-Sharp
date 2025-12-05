namespace CPUScheduling
{
    public class ReadyQueue<P> where P : class
    {
        // Attributes
        public List<P> Processes { get; private set; }

        // Constructor
        public ReadyQueue()
        {
            Processes = new List<P>();
        }

        // Method - Add a process
        public void AddProcess(P process)
        {
            Processes.Add(process);
        }

        // Method - Get a process
        public P? GetProcess(int? index = null)
        {
            // CASE 1: There are no process in the queue
            if (Processes.Count == 0) return null;

            // CASE 2: The given index is out of range
            if (index < 0 || index >= Processes.Count) return null;

            // CASE 3: Both queue contain processes and the given index is in range, are true conditions
            // If given index is null then return first process else return process at the given index
            var process = (index is null) ? Processes[0] : Processes[index!.Value];

            Processes.Remove(process);

            return process;
        }
    }
}
