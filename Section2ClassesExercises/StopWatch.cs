using System;

namespace Section2ClassesExercises
{
    class StopWatch
    {
        private DateTime? startTime;
        private DateTime? stopTime;

        private bool running;

        public void start()
        {
            if (running) throw new InvalidOperationException();

            running = true;
            startTime = DateTime.Now;
        }

        public void stop()
        {

            if (!running) throw new InvalidOperationException();

            running = false;
            stopTime = DateTime.Now;
        }

        public TimeSpan? getDuration()
        {
            if (running || startTime == null || stopTime == null) throw new InvalidOperationException();

            return stopTime - startTime;
        }
    }
}
