using System;
using System.Collections.Generic;

namespace CodingPractice
{
    public class EventProcessor<T>
    {
        public int MaxEvents { get; set; }
        public int BufferTimeout { get; set; }
        private int currentTime = 0;
        private List<T> buffer = new List<T>();

        public EventProcessor(int maxEventsCount, int bufferTimeout)
        {
            BufferTimeout = bufferTimeout;
            MaxEvents = maxEventsCount;
        }

        public void ProcessEvents(List<T> events)
        {
            Console.WriteLine($"Events received: {events.Count}");
            buffer.AddRange(events);
            Console.WriteLine($"Events in buffer: {buffer.Count}");
            if (buffer.Count >= MaxEvents)
            {
                Save(buffer);
            }
        }

        public EventProcessor<T> Tick()
        {
            currentTime++;
            Console.WriteLine($"Current time: {currentTime}");
            if (currentTime % BufferTimeout == 0)
            {
                Save(buffer);
            }
            return this;
        }

        private void Save(List<T> events)
        {
            Console.WriteLine($"Events saved: {events.Count}");
            Console.WriteLine($"Current time: {currentTime}");
            buffer.Clear();
        }
    }
}