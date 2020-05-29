using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TestEvents
{
    class Line : IDisposable, INotifyPropertyChanged
    {
        private List<int> line;
        private int _threshold;
        public int Threshold
        {
            get { return _threshold; }
            set
            {
                if (_threshold == value) return;
                _threshold = value;
                OnPropertyChanged("Threshold");
            }
        }
        
        public event EventHandler<SpecialEventArgs> SpecialEvent;
        public event PropertyChangedEventHandler PropertyChanged;
        public Line()
        {
            line = new List<int>();
            Threshold = 1;
        }

        public void SetThreshold(int threshold)
        {
            Threshold = threshold;
        }
        public void AddNewLineMember(int newListMember)
        {
            line.Add(newListMember);
            if (line.Count > Threshold)
                if (SpecialEvent != null)
                    OnSpecialEvent("В очереди более "+ Threshold + " участников", line.Count);
        }
        public void RemoveLineMember()
        {
            if (line.Count != 0)
                line.Remove(line[0]);

            if (line.Count == 0)
                if (SpecialEvent != null)
                    OnSpecialEvent("В очереди никого нет", line.Count);
        }
        private void OnSpecialEvent(string message, int countOfMembers)
        {
            if (SpecialEvent != null)
                SpecialEvent(this,
                    new SpecialEventArgs(message, countOfMembers));
        }
        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public void Dispose()
        {
            if (SpecialEvent != null)
                foreach (EventHandler<SpecialEventArgs> ev in SpecialEvent.GetInvocationList())
                {
                    SpecialEvent -= ev;
                }

            if (PropertyChanged != null)
                foreach (PropertyChangedEventHandler ev in PropertyChanged.GetInvocationList())
                {
                    PropertyChanged -= ev;
                }
        }

    }

    class SpecialEventArgs: EventArgs
    {
        public SpecialEventArgs(string message, int countOfMembers)
        {
            Message = message;
            CountOfMembers = countOfMembers;
        }
        public string Message { get; private set; }
        public int CountOfMembers { get; private set; }

    }
}
