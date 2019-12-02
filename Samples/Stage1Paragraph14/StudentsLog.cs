using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph14
{
    class StudentsLog
    {
        List<string> records = new List<string>();

        public StudentsLog(Student student)
        {
            student.PropertyChanged += AddRecord;
        }

        void AddRecord(object sender, PropertyChangedEventArgs e)
        {
            records.Add($"Изменено свойство: {e.PropertyName}");
        }

        public void Print()
        {
            foreach (var e in records)
            {
                Console.WriteLine(e);
            }
        }
    }
}