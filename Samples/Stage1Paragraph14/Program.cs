using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph14
{
    class Program
    {
        static void ShowFirstTask()
        {
            Student student = new Student()
            {
                Name = "Ирина Савельева",
                Group = "NNG-01",
                Specialty = "Информатика и иностранные языки",
                LearningYear = 1
            };

            StudentsLog studentsLog = new StudentsLog(student);

            student.LearningYear = 2;
            student.Name = "Ирина Горбунова";

            studentsLog.Print();
        }

        static void ShowSecondTask()
        {
            Queue queue = new Queue()
                { MaxValue = 3 };
            QueueSubscriber queueSubscriber = new QueueSubscriber(queue);


            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
        }

        public static void Main()
        {
            ShowFirstTask();

            ShowSecondTask();

            Console.ReadLine();
        }
    }
}