using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph14
{
    public class Student : INotifyPropertyChanged
    {
        string _name;
        string _group;
        string _specialty;
        int _learningYear;

        public string Name
        {
            get { return _name; }
            set
            {
                SetProperty(ref _name, value);
            }
        }
        public string Group
        {
            get { return _group; }
            set
            {
                SetProperty(ref _group, value);
            }
        }
        public string Specialty
        {
            get { return _specialty; }
            set
            {
                SetProperty(ref _specialty, value);
            }
        }
        public int LearningYear
        {
            get { return _learningYear; }
            set
            {
                SetProperty(ref _learningYear, value);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void SetProperty<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
        {
            storage = value;
            OnPropertyChanged(propertyName);
        }
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}