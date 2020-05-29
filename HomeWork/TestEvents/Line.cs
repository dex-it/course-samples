using System;
using System.Collections.Generic;
using System.Text;

namespace TestEvents
{
    class Line : IDisposable
    {
        private List<int> line;
        public int Threshold { get; set; }
        public event EventHandler<SpecialEventArgs> SpecialEvent;
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
                    SpecialEvent(this,
                    new SpecialEventArgs("В очереди более "+ Threshold + " участников", line.Count));
        }

        public void RemoveLineMember()
        {
            if (line.Count != 0)
                line.Remove(line[0]);

            if (line.Count == 0)
                if (SpecialEvent != null)
                    SpecialEvent(this,
                    new SpecialEventArgs("В очереди никого нет", line.Count));
        }

        public void Dispose()
        {
            if (SpecialEvent != null)
                foreach (EventHandler<SpecialEventArgs> ev in SpecialEvent.GetInvocationList())
                {
                    SpecialEvent -= ev;
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
