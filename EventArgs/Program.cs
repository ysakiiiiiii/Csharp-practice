namespace EventsApp
{
    public delegate void TemperatureChangeHandler(string messgage);

    public class TemperatureChangedEventArgs : EventArgs
    {
        public int Temperature { get; }

        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }

    public class TemperatureMonitor
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        //public event TemperatureChangeHandler TemperatureChange;
        private int _temperature;

        public int Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    OnTemperatureChanged(new TemperatureChangedEventArgs(Temperature));
                }
            }

        }

        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }
    }

    public class TemperatureAlert
    {
        public void onTemperatureChange(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Alet : temperature is {e.Temperature} sender is {sender}");
        }
    }

    public class TempCoolingAlert
    {
        public void onTemperatureChange(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"TEMP COOLING ALERT : temperature is {e.Temperature} sender is {sender}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor temperatureMonitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            TempCoolingAlert coolingAlert = new TempCoolingAlert();

            temperatureMonitor.TemperatureChanged += alert.onTemperatureChange;
            temperatureMonitor.TemperatureChanged += coolingAlert.onTemperatureChange;


            temperatureMonitor.Temperature = 34;
            temperatureMonitor.Temperature = 24;




            }
        }
}
