using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    //public delegate void TemperatureChangeHandler(string message);
    public class TemperatureChangedEventArgs : EventArgs
    {
        // Property holding the temperature
        public int Temperature { get; }

        // constructor
        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }

    public class TemperatureMonitor
    {
        public event EventHandler<TemperatureChangedEventArgs> OnTemperatureChanged;
        //public event TemperatureChangeHandler OnTemperatureChanged;

        private int _temperature;
        public int Temperature 
        {  
            get 
            { 
                return _temperature; 
            }
            set
            {
                if (_temperature != value)
                {
                    TemperatureChangedEventArgs args = new TemperatureChangedEventArgs(value);
                    // Raise Event !!
                    RaiseTemperatureChangedEvent(args);
                }
                _temperature = value;
            }
        }

        protected virtual void RaiseTemperatureChangedEvent(TemperatureChangedEventArgs eventArgs)
        {
            OnTemperatureChanged?.Invoke(this, eventArgs);
        }
    }

    public class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs eventArgs)
        {
            Console.WriteLine($"Alert : temperature is {eventArgs.Temperature} sender is : {sender}");
        }
    }
}
