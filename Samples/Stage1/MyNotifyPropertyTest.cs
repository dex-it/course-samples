using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using NUnit.Framework;
using Stage1.Annotations;

namespace Stage1
{
    [TestFixture]
    public class MyNotifyPropertyTest
    {
        // реализовать интерфейс INotifyPropertyChanged на произвольном классе,
        //   продемонстрировать его работу


        [Test]
        public void PropertyChangedTest()
        {
            var person = new Person();
            
            PropertyChangedEventHandler handler = (s, e) =>
            {
                Assert.AreEqual("FirstName",e.PropertyName);
            };
            
            person.PropertyChanged += handler;

            person.FirstName = "NewFirstname";
            
            
            person.PropertyChanged -= handler;
            person.LastName = "NewLastName";

        }

        public class Person : INotifyPropertyChanged
        {
            
            private string _firstName;
            private string _lastName;
            private DateTime _birthDay;

            public string FirstName
            {
                get => _firstName;
                set
                {
                    if (value == _firstName) return;
                    _firstName = value;
                    OnPropertyChanged();
                }
            }

            public string LastName
            {
                get => _lastName;
                set
                {
                    if (value == _lastName) return;
                    _lastName = value;
                    OnPropertyChanged();
                }
            }

            public DateTime BirthDay
            {
                get => _birthDay;
                set
                {
                    if (value.Equals(_birthDay)) return;
                    _birthDay = value;
                    OnPropertyChanged();
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}