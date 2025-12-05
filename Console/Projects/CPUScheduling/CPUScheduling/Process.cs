namespace CPUScheduling
{
    public class Process
    {
        // Attributes
        protected static int number = 0;
        protected static Random random = new Random();
        public string Label { get; }
        public int BurstTime { get; }
        public int ArrivalTime { get; }
        protected int? completionTime;
        public int TurnAroundTime => Math.Abs(CompletionTime - ArrivalTime);
        public int WaitingTime => Math.Abs(TurnAroundTime - BurstTime);

        // Constructors
        public Process(int burstTime, int arrivalTime, string? label = null)
        {
            Label = label ?? $"P-{++number}";
            BurstTime = Math.Abs(burstTime);
            ArrivalTime = Math.Abs(arrivalTime);
            completionTime = null;
        }

        // Getters & Setters
        public int CompletionTime
        {
            get => (completionTime is null) ? ArrivalTime + BurstTime : completionTime.Value;
            set
            {
                if (completionTime is not null)
                    throw new InvalidOperationException($"Completion time is already set to {completionTime}");

                if (value < ArrivalTime + BurstTime)
                    throw new Exception($"Invalid completion time value. Is must be either greater or equal to {ArrivalTime + BurstTime}");

                completionTime = value;
            }
        }

        // Method - Print info
        public void DisplayInfo()
        {
            string sep = new string('*', 10);
            Console.WriteLine(
                $"{sep} {Label} {sep}"
              + $"\nArrival Time:\t\t{ArrivalTime}"
              + $"\nBurst Time:\t\t{BurstTime}"
              + $"\nCompletion Time:\t{CompletionTime}"
              + $"\nTurn Around Time:\t{TurnAroundTime}"
              + $"\nWaiting Time:\t\t{WaitingTime}");
        }

        // Methods - Comparision Operators
        public static bool operator==(Process left, Process right)
        {
            return left.Label.ToLower() == right.Label.ToLower()
                && left.BurstTime == right.BurstTime
                && left.ArrivalTime == right.ArrivalTime;
        }
        public static bool operator!=(Process left, Process right) => !(left == right);
    }
}
