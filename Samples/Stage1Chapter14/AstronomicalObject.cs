using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Stage1Chapter14

{
    [Serializable]
    public class AstronomicalObject : INotifyPropertyChanged
    {
        private string _name = "";
        private decimal _radius = 0;
        private bool _lightEmission = false;

        private string PrivateProperty { get { return "This is a value PrivateProperty for test of reflection!"; } set { } }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (_name != value)
                {
                    _name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public decimal Radius
        {
            get
            {
                return _radius;
            }

            set
            {
                if (_radius != value)
                {
                    _radius = value;
                    NotifyPropertyChanged();
                }
                
            }
        }
        public bool LightEmission
        {
            get
            {
                return _lightEmission;
            }

            set
            {
                if (_lightEmission != value)
                {
                    _lightEmission = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public AstronomicalObject(string name = "No name", decimal radius = 0, bool lightEmission = false)
        {
            _name = name;
            _radius = radius;
            _lightEmission = lightEmission;
        }

        // Для сериализации в xml
        public AstronomicalObject()
        {
            _name = "No name";
            _radius = 0;
            _lightEmission = false;
        }

        public double GetSurfaceArea()
        {
            return 4 * Math.PI * (double)_radius * (double)_radius;
        }

    }


}
