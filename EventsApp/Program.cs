namespace EventsApp
{
    public delegate void TemperatureChangeHandler(string messgage);

    public class TemperatureMonitor
    {
        public event TemperatureChangeHandler TemperatureChange;
        private int _temperature;

        public int Temperature { get { return _temperature; }
            set
            {
                _temperature = value;
                if (_temperature > 30)
                {
                    RaiseTemperatureChangeEvent("Temperature is above threshold");

                }
            }
                
        }

        protected virtual void RaiseTemperatureChangeEvent(string messgage)
        {
            TemperatureChange?.Invoke(messgage);
        }
    }

    public class TemperatureAlert
    {
        public void onTemperatureChange(string messgage)
        {
            Console.WriteLine($"Alet : {messgage}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor temperatureMonitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();

            temperatureMonitor.TemperatureChange += alert.onTemperatureChange;

            temperatureMonitor.Temperature = 34;
            
            
        }
    }
}
