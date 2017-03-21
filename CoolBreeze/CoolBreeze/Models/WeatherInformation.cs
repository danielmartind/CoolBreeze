using System;
using CoolBreeze.Common;

namespace CoolBreeze.Models
{
    public class WeatherInformation : ObservableBase
    {
        private string _conditions;

        private string _description;

        private string _displayName;

        private int _humidity;

        private string _icon;
        private int _id;

        private int _maxTemperature;

        private int _minTemperature;

        private int _temperature;

        private DateTime _timeStamp;

        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        public string DisplayName
        {
            get { return _displayName; }
            set { SetProperty(ref _displayName, value); }
        }

        public int Temperature
        {
            get { return _temperature; }
            set { SetProperty(ref _temperature, value); }
        }

        public int Humidity
        {
            get { return _humidity; }
            set { SetProperty(ref _humidity, value); }
        }

        public int MinTemperature
        {
            get { return _minTemperature; }
            set { SetProperty(ref _minTemperature, value); }
        }

        public int MaxTemperature
        {
            get { return _maxTemperature; }
            set { SetProperty(ref _maxTemperature, value); }
        }

        public string Conditions
        {
            get { return _conditions; }
            set { SetProperty(ref _conditions, value); }
        }

        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        public string Icon
        {
            get { return _icon; }
            set { SetProperty(ref _icon, value); }
        }

        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { SetProperty(ref _timeStamp, value); }
        }
    }
}