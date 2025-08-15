using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MiscUtils
{
    class GameTimer
    {
        // Attributes
        DateTime? startTime, elpasedTime;

        // Constructor
        public GameTimer()
        {
            startTime = null;
            elpasedTime = null;
        }

        // Method - Start the timer
        public void Start()
        {
            startTime = DateTime.Now;
        }

        // Method - Update the timer
        public void Update()
        {
            if (startTime.HasValue)
            {
                DateTime currentTime = DateTime.Now;
                elpasedTime = Convert.ToDateTime(currentTime - startTime);
            }
        }

        // Method - Get the elapsed time
        public DateTime? GetElapsedTime()
        {
            return elpasedTime;
        }

        // Method - Get the number of seconds elapsed
        public int GetSecondsElapsed()
        {
            if (startTime.HasValue && elpasedTime.HasValue)
            {
                TimeSpan elapsed = elpasedTime.Value - startTime.Value;
                return (int)elapsed.TotalSeconds;
            }

            return 0;
        }

        // Method - Reset the timer
        public void Reset()
        {
            startTime = null;
            elpasedTime = null;
        }

        // Method - Check if the timer is running
        public bool IsRunning()
        {
            return startTime.HasValue;
        }

        // Method - Reset and Start the timer
        public void ResetAndStart()
        {
            Reset();
            Start();
        }
    }
}
