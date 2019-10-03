using System;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class OopTest
    {
        [Test]
        public void Test1()
        {
            var letters = new BaseLetter[] {new Letter() {Title = "simple letter"}, new SecureLetter() {Title = "secure letter"}};
            foreach (var letter in letters)
            {
                letter.Send(); // отправляем письма
            }
        }

        public abstract class BaseLetter
        {
            public string SendTo { get; set; }
            public string Author { get; set; }
            public string Title { get; set; }

            public void Send()
            {
                Console.WriteLine(Title);
                var body = CreateLetterBody();
                Save(body);
                Sending(body);
            }

            protected abstract object CreateLetterBody();

            private void Sending(object body)
            {
                Console.WriteLine("отправляем сообщение");
            }

            private void Save(object body)
            {
                Console.WriteLine("сохраняем сообщение");
            }
        }

        public class Letter : BaseLetter
        {
            protected override object CreateLetterBody()
            {
                Console.WriteLine("создаем тело сообщения");
                return new object(); // создаем тело сообщения
            }
        }

        public class SecureLetter : Letter
        {
            protected override object CreateLetterBody()
            {
                var body = base.CreateLetterBody();
                var encBody = Encrypt(body);
                return encBody;
            }

            private object Encrypt(object body)
            {
                Console.WriteLine("шифруем тело сообщения");
                return body; // шифруем тело сообщения
            }
        }
    }
}