using System;
using System.Linq;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class QueryableLinqTest
    {
        private readonly string[] _teams = {"Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона"};

        [Test]
        public void Test1()
        {
            var selectedTeams = _teams.Where(t => t.ToUpper().StartsWith("Б")).OrderBy(t => t);
            Console.WriteLine("Выведем команды на букву Б ");
            foreach (string s in selectedTeams)
            {
                Console.WriteLine(s);
            }
        }

        [Test]
        public void Test2()
        {
            var selectedTeams = _teams.Select(x => x.ToUpper()[0]).GroupBy(x => x);
            foreach (var g in selectedTeams)
            {
                Console.WriteLine($"На букву {g.Key}, начинается {g.Count()} команд");
            }
        }
    }
}