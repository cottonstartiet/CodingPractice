namespace CodingPractice
{
    public class EventProcessor
    {
        private int currentTime;
        private List<string> currentEvents = new List<string>();
        public int BatchSize { get; private set; }
        public int MaxTimeoutSeconds { get; private set; }

        public EventProcessor(int batchSize, int maxTimeoutSeconds)
        {
            MaxTimeoutSeconds = maxTimeoutSeconds;
            BatchSize = batchSize;
            currentTime = 0;
        }

        public void ProcessEvents(List<string> events)
        {
            if (events == null)
            {
                return;
            }

        }

        public void NextTick()
        {
            currentTime++;
            if (currentTime % MaxTimeoutSeconds == 0)
            {
                SaveToDb();
            }
        }
    }
}