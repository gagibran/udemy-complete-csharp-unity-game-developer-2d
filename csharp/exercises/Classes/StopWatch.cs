using System;

namespace Classes
{
    /// <summary>
    /// Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
    /// provide two methods: Start and Stop.We call the start method first, and the stop method next.
    /// Then we ask the stopwatch about the duration between start and stop.Duration should be a
    /// value in TimeSpan.Display the duration on the console.
    /// <para />
    /// We should also be able to use a stopwatch multiple times.So we may start and stop it and then
    /// start and stop it again. Make sure the duration value each time is calculated properly.
    /// <para />
    /// We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
    /// start time). So the class should throw an InvalidOperationException if its started twice.
    /// </summary>
    /// <remarks>
    /// Educational tip: The aim of this exercise is to make you understand that a class should be
    /// always in a valid state.We use encapsulation and information hiding to achieve that.The class
    /// should not reveal its implementation detail.It only reveals a little bit, like a blackbox.From the
    /// outside, you should not be able to misuse a class because you shouldn’t be able to see the
    /// implementation detail.
    /// </remarks>
    public class StopWatch
    {
        private TimeSpan _currentSpan
        private DateTime _startingTime
        private int _timesStopped
        private bool _hasStopWatchStarted

        public StopWatch()
        {
            ResetTimer();
        }

        public void Start()
        {
            if (_hasStopWatchStarted)
            {
                throw new InvalidOperationException("Cannot start a running timer twice in a row.");
            }
            _startingTime = DateTime.Now;
            _hasStopWatchStarted = true;
        }

        public void Stop()
        {
            if (!_hasStopWatchStarted)
            {
                throw new InvalidOperationException("Cannot stop a already stopped timer.");
            }
            _timesStopped++;
            _currentSpan += DateTime.Now - _startingTime;
            Console.WriteLine($"Stop no. {_timesStopped} (minutes, seconds, milliseconds): {_currentSpan.ToString(@"mm\:ss\:ff")}");
            _hasStopWatchStarted = false;
        }

        public void ResetTimer()
        {
            _currentSpan = new TimeSpan(0, 0, 0);
            _timesStopped = 0;
            _hasStopWatchStarted = false;
        }
    }
}
